using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderEmployeedManagementWindowsNative.ClassItemPlusInherited;

namespace OrderEmployeedManagementWindowsNative.ClassItemPlusInherited
{
    class ItemShirt : ItemBase
    {
        public ItemShirt(/*Base Constructor Parameters*/ decimal priceC, string sizeC, string itemTypeC, string nameOfItemC, string vendorNameC, string descriptionC,/*endBaseConstPara*/ 
           /*ItemShirt Cosntructor Parameters*/ bool tagC, bool collarC, string sleeveLengthC, int screensC, string materialC) : base(priceC, sizeC, 
            itemTypeC, nameOfItemC, vendorNameC, descriptionC)
        {
            
            string material= materialC;            
            int screens=screensC;
            string sleeveLength=sleeveLengthC;            
            bool collar=collarC;
            bool tag =tagC;
            

        }//end constructor--------------------------------------------------------------------------------------------

        //Instance Variables
        string material; 
        int screens;       
        string sleeveLength;        
        bool tag;
        bool collar;
        
        //end Instance Variables

        //Properties- - - - - - - - - - - - - -----------------------------------------------------------------------

        //ItemType Property
        public string ItemType()
        {
            return "Shirt";
        }
        //Material Property
        public string Material
        {
            get
            {
                return material;
            }//end get
        }//end Property Material

        public int Screens
        {
            get
            {
                return screens;
            }//end get
            set
            {
                if (value > 0)
                    screens = value;
                else
                {
                    ArgumentOutOfRangeException screensException = new ArgumentOutOfRangeException("Screens Exception", "Screens must be at least 1");
                }//end if

            }//end get/set
        }//end Property Screens

        //SleeveLength Property
        public string SleeveLength
        {
            get
            {
                return sleeveLength;
            }//end get
        }//end Property SleeveLength

        //Tag property
        public bool Tag
        {
            get
            {
                return tag;
            }//end get
        }//end Property Tag

        //Collar property
        public bool Collar
        {
            get
            {
                return collar;
            }//end get
        }//end Property Collar

        //METHODS- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
        //Changes: Material, Screens, SleeveLength, Tag, Collar

        //Method ChangeMaterial
        public void ChangeMaterial(string materialM)
        {
            material = materialM;
        }//end ChangeMaterial method

        //Method ChangeScreensCount
        public void ChangeScreensCount(int screenCountM)
        {
            screens = screenCountM;
        }//end ScreensCount method

        //Method ChangeSleeveLenth
        public void ChangeSleeveLenth(string sleeveLengthM)
        {
            sleeveLength = sleeveLengthM;
        }//end SleeveLenth method

        //Method ChangeTag
        public void ChangeTag(bool tagM)
        {
            tag = tagM;
        }//end ChangeTag method

        //Method ChangeCollar
        public void ChangeCollar(bool collarM)
        {
            collar = collarM;
        }//end ChangeCollar method

        


        /*below to be overridden*/
        ////Method to be used while in the selection process for fast access to estimates
        ////Class Order Inheritance will have the order total & the tax as well
        ////Method MultiplyShirts
        //public decimal MultiplyItems(int itemCount)
        //{
        //    return this.UnitPrice * itemCount;
        //}//end Method MultiplyShirts


        //COLLECTIONS-----------------------------------------------------------------------------------------------------------
        //OrderCollection
        public List<OrdersESP> ClientOrdersList = new List<OrdersESP>();

        
        //
        //toString
        //
        public override string ToString()
        {
            string toString = "\nItem Type:\t\t" + ItemType() + "\nMaterial:\t\t" + Material 
                + "\nName of Item:\t\t" + NameOfItem + "\nVendor Name:\t\t" + VendorName + "\nSize:\t\t" + SizeItem 
                + "\nScreen Number:\t\t" + Screens + "\nUnit Price:\t\t" + UnitPrice.ToString()
                + "\nSleeve Style/Length:\t\t" + SleeveLength + "\nTag:\t\t" + Tag + "\nCollar:\t\t" + Collar 
                + "\nItem Description/Notes:\t\t" + ItemDescription;
            return toString;

        }

    }//end Class ItemShirt : ItemBase
}//end namespace OrderEmployeedManagementWindowsNative.ClassItemPlusInherited
