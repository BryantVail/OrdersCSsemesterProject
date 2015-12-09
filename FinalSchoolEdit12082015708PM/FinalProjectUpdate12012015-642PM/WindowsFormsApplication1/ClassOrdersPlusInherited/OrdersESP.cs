using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderEmployeedManagementWindowsNative.ClassItemPlusInherited;


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
         *                  
         * List<Class ItemORdered> to hold the different Sizes, colors, prints of a shirt.
         * 
         * //Methods:
         * ID, PaymentReceived, 
         */

        //contructor
        public OrdersESP(string clientNameC, DateTime orderInitiated, DateTime dateDueC, string descriptionNotesC,
            /*cost/Balance constructor values */decimal taxC, decimal amountCollected,  
            decimal margin, decimal labor/*end cost*/ )
        {
            clientName = clientNameC;
            orderInitiated = orderInitiatedDate;
            dateDue = dateDueC;
            descriptionNotes = descriptionNotesC;
            TaxSales = taxC;
            AmountCollected = amountCollected;
            
            //ItemUnitCost = unitCost;
            
            MarginPercentage = margin;
            LaborPercentage = labor;


        }//end ConstructorFull

        public OrdersESP()
        {
            clientName =       string.Empty  ;
            orderInitiated =   DateTime.Now ;
            dateDue =         DateTime.Now.AddDays(7)  ;
            descriptionNotes = string.Empty  ;
            TaxSales =         0   ;
            AmountCollected =  0   ;
            ItemUnitCost =     0   ;
            ItemsSold =        0   ;
            MarginPercentage = 0   ;
            LaborPercentage = 0;
        }
        //late Initializers
            public void AddClientName(string clientN)
        {

        }//end Addition Tool


        //end LateInitializers

        //OrderType
        public virtual string OrderType()
        {
            return "GreatOrders";
        }
        //ID Instance variables
        string orderID;
        string employeeID;
        string clientName;

        //OrderTotal Instance Variables
        decimal tax;
        decimal unitCostItem;
        int wasteItemsCount;
        int itemsSold;

        decimal marginPercentage;
        decimal laborPercentage;
        decimal amountCollected;
        //
        //DateTime
        //
        DateTime orderInitiated;
        //DateTime orderDateDue;

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
                return clientName;
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

       
        //Property ItemsSold
        public int ItemsSold
        {
            get
            {
                return itemsSold;
            }//end get
            set
            {
                if (value > 0)
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
        public decimal AmountCollected
        {
            get
            {
                return amountCollected;
            }//end get
            set
            {
                if (value >= 0)
                    amountCollected = value;
                else
                {
                    ArgumentOutOfRangeException paymentInitialException = new ArgumentOutOfRangeException("Amount Collected", "Amount Collected cannot be less than Zero(0)");
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
            return ((((ItemsSold * ItemUnitCost)) * (TaxSales + 1)) * (MarginPercentage + LaborPercentage + 1));

        }//End OrderTotal

               

        //bool Completed, set to true after initial creation of the record

        //Method Order Status String
        public string OrderStatus()
        {
            if (OrderRemainingBalance() > 0)
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
                //if(value == DateTime.Today) /*not sure if this should be able to be manipulated for the use of the business)*/
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

        /*Collections
         * list<items> PreOrderList = new List<items>();
         * list<items> OrderedItemsList = new List<items>();         * 
         * 
         */

        //List to hold the items that go past the ItemBuilder Section & puts at the bottom of the page for calculation
        //List OrderedItemList
        List<ItemBase> OrderedItemsList = new List<ItemBase>();
        //end list OrderedItemList

        
        //List OrderedItemList
        List<ItemBase> PreOrderList = new List<ItemBase>();
        //end list OrderedItemList

        //add items
        public void AddItemsOrderedItemsList(ItemBase item)
        {
            OrderedItemsList.Add(item);
        }//end

        public int OrderedItemsListCount()
        {
            return this.OrderedItemsList.Count;
        }//end

        //End COLLECTIONS ----------------------------------------------------------------------------------------------------------------------

        //Average Unit Cose
        //public decimal AvgUnitCost(int quantityL)
        //{
            
            
        //}

        //Method Checkout
        public List<ItemBase> Checkout()
        {
            //Move Items from preOrder to Ordered
            foreach (ItemBase itemFE in PreOrderList)
            {
                OrderedItemsList.Add(itemFE);
            }//end foreach

            return OrderedItemsList;

            //clear PreOrderList
            PreOrderList.Clear();
         }//end CHeckout Method

        

            //Method OrderRemainingBalance()
            public decimal OrderRemainingBalance()
            {
                return OrderTotal() - AmountCollected; /*Order total does not include any payments received*/
            }//end OrderRemainingBalance

        //Method PaymentReceived
        public void PaymentReceived(decimal num)
            {
                AmountCollected += num;
            }//end PaymentReceived

        //Method String ItemList
        //public StringBuilder ItemList()
        //{
        //    foreach (ItemBase item in Checkout())
        //        return "TYPE:\t\t" + item.ItemType + "\n \t\t" + item.NameOfItem + "\n \t\t" + item.UnitPrice + "\n \t\t" + item.SizeItem + "\n \t\t" + item.VendorName
        //            + "\n \t\t" + item.ItemDescription;
        //}

                
        
        public override string ToString()
        {
            return "Order Type:\t\t" +this.OrderType().ToString() + "\nOrderID:\t\t"+this.OrderID().ToString()+ "\nClientID:\t\t" +this.ClientID+ 
                "\nOrder Status\t\t" +this.OrderStatus()+"\n\nTAX:\t\t" + this.TaxSales.ToString() + "\n" + "Items Sold:\t\t" + ItemsSold.ToString() + "\n" +
                "Unit Cost:\t\t" + this.ItemUnitCost.ToString() + "\n" + "Remaining Balance:\t\t" + this.OrderRemainingBalance().ToString()
                /*Lists*/ ;
        }//end method ToString Override

        //STATIC METHODS--------------------------------------------------------
        public static decimal SalesTax()
        {
            return .06M;
        }//end Static SalesTax

    }//end class
}//end namespace
