using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderEmployeedManagementWindowsNative
{
    class OrdersESP
    {

        /*ID:Order, Employee, Client                x
         * DateTime: order initiated, date due      x
         * Amount collected                         x
         * Tax                                      x
         * Balance Remaining                     m
         * Cost: Materials + Labor + wasteItem   m
         * Completed(bool)                          x
         * Description(string)                      x
         * Debit(Method)  [amount - Balance]    m
         * Credit(Method) [amount + Balance]    m
         * 
         * Cost:    Labor 40%(off the top[comes from another data source])
         *          Item cost
         *          ItemWaste
         * OrderBalance:
         *                  (Cost * (margin +1)) - 
         */

        //contructor
        public OrdersESP(string clientIDCon, string employeeIDCon, DateTime orderInitiated, DateTime dateDueC, string descriptionNotesC,
            /*cost/Balance constructor values */decimal taxC, decimal amountCollected, decimal unitCost, int itemsSoldC, decimal margin, decimal labor/*end cost*/ )
        {
            clientID = clientIDCon;
            employeeID = employeeIDCon;
            orderInitiated = orderInitiatedDate;
            dateDue = dateDueC;

            descriptionNotes = descriptionNotesC;
            TaxSales = taxC;
            PaymentInitial = amountCollected;
            
            ItemUnitCost = unitCost;
            ItemsSold = itemsSoldC;
            MarginPercentage = margin;
            LaborPercentage = labor;
        }//end Constructor

        //OrderType
        public virtual string OrderType()
        {
            return "GreatOrders";
        }
        //ID Instance variables
        string orderID;
        string employeeID;
        string clientID;

        //OrderTotal Instance Variables
        decimal tax;
        decimal unitCostItem;
        int wasteItemsCount;
        int itemsSold;

        decimal marginPercentage;
        decimal laborPercentage;
        decimal paymentInitial;

        //Notes & Logs
        string descriptionNotes;


        //ID Number Section - - - - - - - - - - - - - - - -
        //Method OrderID
        public string OrderID()
        {
            return OrderInitiated.ToShortDateString() + ClientID.ToString() + DateDue.ToShortDateString() + ItemsSold.ToString();
        }//end Method OrderID


        //Property EmployeeID
        public string EmployeeID
        {
            get
            {
                return employeeID;
            }//end get
        }//end Property EmployeeID

        //Property ClientID
        public string ClientID
        {
            get
            {
                return clientID;
            }
        }//end Property ClientID

        //End Identification Section
        //- - - - - - - - - - - - - - - - - - - - - - 

        //Property TaxSales       
        public decimal TaxSales
        {
            get
            {
                return tax;
            }//end get
            set
            {
                if (value >= 0)
                    tax = value;
                else
                {
                    Exception taxNegative = new ArgumentOutOfRangeException("Tax rate out of range", "Please choose a tax rate consistent with legal practices");

                }//end if
            }//end set
        }//end Property TaxSales

        //Property ItemUnitCost
        public decimal ItemUnitCost
        {
            get
            {
                return unitCostItem;
            }//end get
            set
            {
                if (value > 0)
                    unitCostItem = value;
                else
                {
                    ArgumentOutOfRangeException unitcostOutOFRange = new ArgumentOutOfRangeException();
                    throw unitcostOutOFRange;
                }//end if
            }//end set
        }//end Property ItemUnitCost

        //Property WasteItemsCount
        public int WastItemsCount
        {
            get
            {
                return wasteItemsCount;
            }
            set
            {
                if (value > 0)
                    wasteItemsCount = value;
                else
                {
                    ArgumentOutOfRangeException wastedItemsOutOFRange = new ArgumentOutOfRangeException("Wasted Items cannot be negative", "WastedItemsOutOFRange");
                    throw wastedItemsOutOFRange;
                }
            }

        }

        //Property ItemsSold
        public int ItemsSold
        {
            get
            {
                return itemsSold;
            }//end get
            set
            {
                if (value >= 0)
                    itemsSold = value;
                else
                {
                    ArgumentOutOfRangeException itemsSoldException = new ArgumentOutOfRangeException("Are you done with the order?", "There are no items associated with this order.");
                    throw itemsSoldException;
                }//end if
            }//end set
        }//end property ItemsSold



        //Property MarginPercentage
        public decimal MarginPercentage
        {
            get
            {
                return marginPercentage;
            }//end get
            set
            {
                if (value >= 0)
                    marginPercentage = value;
                else
                {
                    ArgumentOutOfRangeException marginException = new ArgumentOutOfRangeException("Margin cannot be Zero(0)", "A margin needs to be present in order to make money in this world");
                    throw marginException;
                }//end if
            }//end set
        }//end Property MarginPercentage

        //Property LaborPercentage
        public decimal LaborPercentage
        {
            get
            {
                return laborPercentage;
            }//end get
            set
            {
                if (value >= 0)
                    laborPercentage = value;
                else
                {
                    ArgumentOutOfRangeException laborPercException = new ArgumentOutOfRangeException("Labor Cost Percentage", "Labor Cost Percentage Needs to be adderessed.");
                    throw laborPercException;
                }//end IF
            }//end set
        }//end Property LaborPercentage

        //Property PaymentInitial
        //Initial payment (if any) to the order upon creation
        public decimal PaymentInitial
        {
            get
            {
                return paymentInitial;
            }//end get
            set
            {
                if (value >= 0)
                    paymentInitial = value;
                else
                {
                    ArgumentOutOfRangeException paymentInitialException = new ArgumentOutOfRangeException("Initial Payment", "Initial Payment cannot be less than Zero(0)");
                    throw paymentInitialException;
                }//end IF

            }//end set
        }//end Property PaymentInitial

        //Property DescriptionNotes
        public string DescriptionNotes
        {
            get
            {
                return descriptionNotes;
            }//end get
        }//end Property DescriptionNotes


        //Method OrderTotal
        public virtual decimal OrderTotal()
        //this does not include any initial payment
        {
            //(TaxSalesX + ((UnitCost * WasteItems)+(ItemsSold * ScreensNeeded))) * (Margin%+1)
            return ((((ItemUnitCost * WastItemsCount) + (ItemsSold * ItemUnitCost)) * (TaxSales + 1)) * (MarginPercentage + LaborPercentage + 1));

        }//End OrderTotal

        //OrderBalance Instance Variables
        //


        //Method OrderBalance (after any intial payment)
        public decimal OrderBalance()
        {
            decimal orderTot = OrderTotal();
            return OrderTotal() - PaymentInitial;
        }






        //bool Completed, set to true after initial creation of the record

        //Method Order Status String
        public string OrderStatus()
        {
            if (OrderBalance() > 0)
                return "NotPaid";
            else //if(OrderBalance() <=0)
                return "PaidFull";
        }//end Method OrderStatusString


        //DateTime
        DateTime orderInitiatedDate;
        DateTime dateDue;
        DateTime now = new DateTime();

        //DateTime 
        DateTime OrderTimeStamp = new DateTime();

        public DateTime OrderInitiated
        {
            get
            {
                return orderInitiatedDate;
            }//end get
            set
            {
                orderInitiatedDate = value;
            }//end set
        }//end OrderInitiated Property(DAteTime)

        public DateTime DateDue
        {
            get
            {
                return dateDue;
            }
            set
            {
                if (value > now)
                {
                    dateDue = value;
                }
                else
                {
                    Exception chooseFutureDate = new ArgumentOutOfRangeException("The Date That was chosen is in the past.", "Please enter a future Date");
                    throw chooseFutureDate;
                }//end if
            }//end set
        }//end Property DateDue



        public override string ToString()
        {
            return "Order Type:\t\t" + OrderType() + "OrderID: \t\t" + OrderID().ToString() + "\n" + "ClientID: \t\t" + ClientID.ToString() + "\n" + "Completed Status\t\t" + OrderStatus() + "TAX:\t\t" + TaxSales.ToString() + "\n" + "Items Sold:\t\t" + ItemsSold.ToString() + "\n" + "Unit Cost:\t\t" + ItemUnitCost.ToString() + "\n" + "Remaining Balance:\t\t" + OrderBalance().ToString();
        }//end method ToString Override


    }//end class
}//end namespace
