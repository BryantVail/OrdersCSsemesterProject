using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderEmployeedManagementWindowsNative;


namespace OrderEmployeedManagementWindowsNative.ClassItemPlusInherited
{//
    class ItemBase
    {//This class is to contain any item or merchandise involved in a transaction
        //Properties of ItemOrder
        //ItemID - Price, ItemType, VendorName,  NameOfItem, description
        //"C" signifies constructor Value
        public ItemBase(decimal unitPriceC, string sizeC, string itemTypeC, string nameOfItemC, string vendorNameC, string descriptionC)
        {
             unitPrice = unitPriceC;
             size= sizeC;
             itemType=itemTypeC;
             nameOfItem=nameOfItemC;
             vendorName=vendorNameC;
             description= descriptionC;


        }//end constructor(whole)
    
        decimal unitPrice;
        string size;
        string itemType;
        string nameOfItem;
        string vendorName;
        string description;

    
        
        
        //Price Property
        public decimal UnitPrice
        {
            get
            {
                return unitPrice;
            }//end get
            set
            {
                if (value > 0)
                    unitPrice = value;
                else
                {
                    ArgumentOutOfRangeException priceException = new ArgumentOutOfRangeException("Price level Exception", "Price of item needs to be greater than Zero(0)");
                }//end if
                    

            }//end if
        }//end Property Price

        //Size Property
        public string SizeItem
        {
            get
            {
                return size;
            }//end get
        }//end size property

        public string ItemType
        {
            get
            {
                return itemType;
            }//end get
        }//end Property ItemType

        public string NameOfItem
        {
            get
            {
                return nameOfItem;
            }//end get
        }//end Property NameOfItem

        //Description of the item: longer string
        public string ItemDescription
        {
            get
            {
                return description;
            }//end get
        }//end Property ItemDescription

        public string VendorName
        {
            get
            {
                return vendorName;
            }//end get
        }//end Property VendorName
                
        //Methods-------------------------------------------
        //ItemID, 
        public string ItemID()
        {
            string itemID = DateTime.Today.ToBinary() + DateTime.Now.ToBinary().ToString();
            return itemID;
        }//End ID

        //Method to be used while in the selection process for fast access to estimates
        //Class Order Inheritance will have the order total & the tax as well
        //Method MultiplyShirts
        public decimal MultiplyItems(int itemCount)
        {
            return (this.UnitPrice * itemCount) * (OrdersESP.SalesTax()+1);
        }//end Method MultiplyShirts

        //
        //toString
        //
        public override string ToString()
        {
            //base ToString
            string toString = "ItemID:\t" + ItemID().ToString() + "Unit Price:\t\t\n" + UnitPrice.ToString() + "Item Type\t\t\n" + ItemType
                + "Size:\t\t\n" + SizeItem + "Name OF Item:\t\t\n" + NameOfItem + "Vendor Name:\t\t\n" 
                + VendorName + "\nDescripion/Notes:" + ItemDescription;

            return toString;

            /* decimal unitPrice;
        string size;
        string itemType;
        string nameOfItem;
        string vendorName;
        string description;
*/

        }

    }//end class ItemOrder
}//end NameSpace  OrderEmployeedManagementWindowsNative.ClassItemPlusInherited
