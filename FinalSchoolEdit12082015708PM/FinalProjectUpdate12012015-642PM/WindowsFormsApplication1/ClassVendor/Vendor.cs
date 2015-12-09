using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderEmployeedManagementWindowsNative.ClassVendor
{
    class Vendor
    {
        public Vendor(string companyNameC, string contactNameC, /*address*/ string addressNumC, string addressStC, string addressStTypeC, string addressCityC, string addressStateC,
            string addressZipCodeC, /*end address*/ string emailC, string websiteURLC, string phone1C, string phone2C,  string vendorNotesC )
    {
         companyName = companyNameC;
         contactName = contactNameC;
        //Address
         addressNum = addressNumC;
         addressSt = addressStC;
         addressStType= addressStTypeC;
         addressCity= addressCityC;
         addressState = addressStateC;
         addressZipCode=addressZipCodeC;
        //end address
         email= emailC;
         websiteURL = websiteURLC;
         phone1 =phone1C;
         phone2=phone2C;
        
         vendorNotes = vendorNotesC;
    }//end Constructor

        //Instance Variables
        string companyName;
        string contactName;
        //Address
        string addressNum;
        string addressSt;
        string addressStType;
        string addressCity;
        string addressState;
        string addressZipCode;
        //end address
        string email;
        string websiteURL;
        string phone1;
        string phone2;
        decimal moneySpent; // property only, MoneySpentWithAdd Method available for this decimal
        string vendorNotes;
        //end instance Variables for constructor

        //Properties
        
        //property CompanyName
       public string CompanyName
        {
            get
            {
                return companyName;
            }//end get
            set
            {
                if(value.Length >3)
                value = companyName;
                else
                {
                    ArgumentOutOfRangeException CompanyNameLengthException = new ArgumentOutOfRangeException();
                }//end if
            }//end get/set
        }//end Property CompanyName

        //property ContactName
       public string ContactName
        {
            get
            {
                return contactName;
            }//end get
            set
            {
                contactName = value;
            }//end get/set  
        }//end Property ContactName

        //property AddressNum
       public string AddressNum
        {
            get
            {
                 return addressNum;
            }//end get
            set
            {
                addressNum = value;
            }//end get/set
        }//end Property AddressNum

        //property AddressSt
       public string AddressSt
        {
            get
            {
                 return addressSt;
            }//end get
            set
            {
                addressSt = value;
            }//end set/get
        }//end Property AddressSt

        //property AddressStType
       public string AddressStType
        {
            get
            {
                return addressStType;
            }//end get
            set
            {
                addressStType = value;
            }//end get/set

        }//end Property AddressStType

        //property AddressCity
       public string AddressCity
        {
            get
            {
                return addressCity;
            }//end get
            set
            {
                addressCity=value;
            }//end get/set
        }//end Property AddressCity

        //property AddressState
        public string AddressState
        {
            get
            {
                return addressState;
            }//end get
            set
            {
               addressState =value;
            }//end get/set
        }//end Property AddressState

        //property AddressZipCode
        public string AddressZipCode
        {
            get
            {
                return addressZipCode;
            }//end get
            set
            {
                addressZipCode = value;
            }//end get/set
        }//end Property AddressZipCode

        //property Email
       public string Email
        {
            get
            {
                return email;
            }//end get
            set
            {
                email = value;
            }//end get/set
        }//end Property Email

        //property WebsiteURL
        public string WebsiteURL
        {
            get
            {
                return websiteURL;
            }//end get
            set
            {
                websiteURL = value;
            }//end get/set  
        }//end Property WebsiteURL

        //property Phone1
      public  string Phone1
        {
            get
            {
                return phone1;
            }//end get
            set
            {
                phone1 = value;
            }//end get/set
        }//end Property Phone1

        //property Phone2
       public string Phone2
        {
            get
            {
                return phone2;
            }//end get
            set
            {
                phone2 = value;
            }//end get/set
        }//end Property Phone2

        //Property MoneySpentWith
        public decimal MoneySpentWith
        {
            get
            {
                return moneySpent;

            }//end get
            set
            {
                if (value >= 0)
                    moneySpent = value;
                else
                {
                    Exception moneySpentException = new Exception();
                    moneySpentException.StackTrace.ToString();
                }
            }
        }

        //METHODS------------------------------------------------------------------------------------------------------------------------
        //alter MoneySpentWith value
        public void ChangeMoneySpentWith(decimal value)
        {
            if (value > 0)
                this.MoneySpentWith += value;
            else
            {
                ArgumentOutOfRangeException MoneySpentWithIncreaseException = new ArgumentOutOfRangeException();
            }//end if
        }//end Method ChangeMoneySpentWith

        //Method: AddressFull -> Concatenate Address
        public string AddressFull()
        {
            return this.AddressNum +" "+ this.AddressSt +" "+this.AddressStType +"- "+this.AddressCity +","+this.AddressState +"  ("+this.AddressZipCode+")";
        }//end String AddressFull

        //Method Update Address
        public void AddressUpdate(string addNum, string addSt, string addStType, string addCity, string addState, string addZipCode)
        {
            if(addNum.Length != 0 && addSt.Length != 0 && addStType.Length != 0 && addCity.Length != 0 && addState.Length != 0 && addZipCode.Length != 0)
            {
                 this.AddressNum = addNum;
            this.AddressSt = addSt;
            this.AddressStType=addStType;
            this.AddressCity=addCity;
            this.AddressState=addState;
            this.AddressZipCode=addZipCode;

            }//end conditional
            else
            {
                ArgumentOutOfRangeException AddressUpdateException = new ArgumentOutOfRangeException();
            }//end if
        }//end Method AddressUpdate

        //add MoneySpentWith
            public decimal MoneySpentWithAdd(decimal num)
            {
                return MoneySpentWith +=num;
            }// end MoneySpentWithAdd

        //END METHODS--------------------------------------------------------------------------------------------------------------------

    }//end class Vendor
}//end namespace OrderEmployeedManagementWindowsNative.ClassVendor
