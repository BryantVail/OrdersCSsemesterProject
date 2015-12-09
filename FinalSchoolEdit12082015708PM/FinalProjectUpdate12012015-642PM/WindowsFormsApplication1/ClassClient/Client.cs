using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderEmployeedManagementWindowsNative.ClassClient
{
    class Client
    {
        //Fields to Hold the information for a Client
        //Also Methods to change these values with input
        //Constructor
        public Client(string companyNameC, string contactNameC, 
            /*Address*/ string addStreetNumC, string addStreetC, string addStreetTypeC,
            string addCityC, string addStateC, string addZipCodeC /*End Address*/

            , string emailC, string phone1C, string phone2C, decimal moneySpentC,   
              DateTime clientDateInitiatedC, string industryC, string clientNotesC )
        {
           
           companyName= companyNameC;
           contactName= contactNameC;
           email= emailC;
           phone1= phone1C;
           phone2= phone2C;
           //InitialPayment = initialPaymentC;
            MoneySpentTotal = moneySpentC;
           clientDateInitiated = clientDateInitiatedC;
            industry = industryC;
            clientNotes = clientNotesC;

            //Make methods for: 
                //OrderCount
                //MoneySpent
                //balance Method with another group of data
                //AddressFull
            
        }//end ConstructorFull

        //Consructor from DataSource, excludes Initial Payment,  

        //Constrctor Default
        //public Client()
        //{
        //    //default
        //}

        //instance Variables
            string companyName;
            string contactName;
            //string billingAddress;
            //Address
            string addStreetNum;
            string addStreet;
            string addStreetType;
            string addCity;
            string addState;
            string addZipCode;
            //end address
            string email;
            string phone1;
            string phone2;
            decimal moneySpent;
            //Initialize when order is submitted or 0(Zero) for Client build without order
            decimal balance;
            int orderCount;
            //end ^
            DateTime clientDateInitiated;
            string industry;
            string clientNotes;
            string iDnum; //Method
            
        
        //end instance variables

        //STRINGS
        //Property CompanyName
        public string CompanyName
            {
            get
                {
                    return companyName;
                }//end get
            }//end Property CompanyName

        //Property ContactName
        public string ContactName
        {
            get
            {
                return contactName;
            }//end get
        }//end Property ContactName

        //Property BillingAddressFull
        public string BillingAddressFull()
        {
           return AddStreetNum +" "+ AddStreetName +" "+AddStreetType+"- "+
            AddCity+", "+AddState+" ("+ AddZipCode+") ";
        }//end Property BillingAddress

        //
        //AddressProperties
        //

            //Address
        //string addStreetNum;
        //string addStreet;
        //string addStreetType;
        //string addCity;
        //string addState;
        //string addZipCode;
        //end address

        //Property AddStreetNum
        public string AddStreetNum
        {
            get
            {
                return addStreetNum;
            }//end get
            set
            {
                addStreetNum = value;
            }//end get/set
        }//end Property

        //Property AddStreetName
        public string AddStreetName
        {
            get
            {
                return addStreet;
            }//end get
            set
            {
                addStreet = value;
            }//end get/set
        }//end Property

        //Property AddStreetNum
        public string AddStreetType
        {
            get
            {
                return addStreetType;
            }//end get
            set
            {
                addStreetType = value;
            }//end get/set
        }//end Property

        //Property AddCity
        public string AddCity
        {
            get
            {
                return addCity;
            }//end get
            set
            {
                addCity = value;
            }//end get/set
        }//end Property AddCity

        //Property AddState
        public string AddState
        {
            get
            {
                return addState;
            }//end get
            set
            {
                addState = value;
            }//end get/set
        }//end Property AddState

        //Property AddZipCode
        public string AddZipCode
        {
            get
            {
                return addZipCode;
            }//end get
            set
            {
                addZipCode = value;
            }//end get/set
        }//end Property AddZipCode
        //
        //End Address
        //

        //Property IDNum
        public string ClientID
        {
            get
            {
                return iDnum;
            }//
            set
            {
                iDnum = value;
            }//end get/set
        }//end Property ClientID

        //Property Email
        public string Email
        {
            get
            {
                return email;
            }//end get
        }//end Property Email

        //Property Phone1
        public string Phone1
        {
            get
            {
                return phone1;
            }//end get
        }//end Property Phone1

        //Property Phone2
        public string Phone2
        {
            get
            {
                return phone2;
            }//end get
        }//end Property Phone2

        public string IndustryType
        {
            get
            {
                return industry;
            }
            set
            {
                industry = value;
            }//end get/set
        }//end Property IndustryType

        //Property ClientNotes
        public string ClientNotes
        {
            get
            {
                return clientNotes;
            }
            set
            {
                clientNotes = value;
            }//end get/set
        }//end Property ClientNotes

        //
        //END STRINGS
        //

        //
        //NUMBER VALUES
        //Property Balance
        

        ////Property InitialPayment   
        //public decimal InitialPayment
        //{
        //    get
        //    {
        //        return initialPayment;
        //    }//end get
        //    set
        //    {
        //        if (value >= 0)
        //            initialPayment = value;
        //        else
        //        {
        //            ArgumentOutOfRangeException InitialPaymentArgumentOutOfRangeException = new ArgumentOutOfRangeException();
        //        }//end if

            //}//end get/set
        //}//end Property

        //Property Decimal MoneySpentTotal
        public decimal MoneySpentTotal
        {
            get
            {
                return moneySpent;
            }
            set
            {
                if(value>=0M)
                    moneySpent = value;
                else
                {
                    ArgumentOutOfRangeException MoneySpentArgumentOutofRangeException = new ArgumentOutOfRangeException();
                    moneySpent = -1M;
                }//end if
            }//end get set
        }// end Property MoneySpentTotal

        //OrderCount
        public int OrderCount()
        {
            return orderCount;
        }//end OrderCount




               

        //Property DateTime ClientSinceDate
        public DateTime ClientSinceDate
        {
            get
            {
                return clientDateInitiated;
            }//end get
            set
            {
                if (value >= DateTime.Today)
                    clientDateInitiated = value;
            }//end get/set
        }//end Property ClientSinceDate



        //METHODS- - - - - - - - - - - - - - - - --------------------------------------------------------------------------------
        //Add/subtract: Balance, OrderCount, MoneySpent

        //Method ChangeBalance
        public void ChangeBalance(decimal numberM)
        {
            balance += numberM;
        }//end Method ChangeBalance

        //Method ChangeOrderCount
        public void ChangeOrderCount(int numberM)
        {
            orderCount += numberM;
        }//end Method ChangeOrderCount

        //Method ChangeMoneySpent
        public void ChangeMoneySpent(decimal numberM)
        {
            if (numberM>0)
            moneySpent += numberM;
        }//end Method ChangeMoneySpent


        //ClientIDGen, 
        public string ClientIDGen()
        {
            if(iDnum.Length>3)
            {
                iDnum = DateTime.Today.ToBinary().ToString() + DateTime.Now.ToBinary().ToString();
            return iDnum;
            }
            
            else
            {
                 return iDnum = ClientID;
            }//endIf
           
        }//End ID

        //COLLECTIONS------------------------------------------------------------------------------------------------------------
        //OrderCollection
        public List<OrdersESP> ClientOrdersList = new List<OrdersESP>();

        //
        //ToString
        //
        public override string ToString()
{
    string toString = "Client Name:\t\t" + CompanyName.ToString() + "\nContact Name:\t\t" + ContactName.ToString() + "\nBilling Address:\t\t" + BillingAddressFull().ToString() +
        "\nEmail Address:\t\t" + Email.ToString() 
        + "\nPhone:\t\t" + Phone1 
        + "\nPhone 2:\t\t" + Phone2 
        + "\nOrder Count:\t\t" + OrderCount() + "\nDate Initiated With Company:\t\t" + ClientSinceDate.ToLongDateString() 
        + "\nIndustry:\t\t" + IndustryType +"\nMoney Spent Total:\t\t"+MoneySpentTotal.ToString()
        +"\nClient Notes:\t\t" + ClientNotes; 
    return toString;
       
}//end ToString Override1

    }//end Client Class
}//End NameSpace OrderEmployeeManagementWindowsNative.ClassClient
