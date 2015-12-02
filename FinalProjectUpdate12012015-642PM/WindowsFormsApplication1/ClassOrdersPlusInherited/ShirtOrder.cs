using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderEmployeedManagementWindowsNative.ClassOrdersPlusInherited
{
    class ShirtOrder : OrdersESP
    {
        public ShirtOrder(/*Shirt Specific Constructors*/  
            string itemIDCons, string orderTypeC, string materialC, decimal screenPrintPricePer, decimal screensNeeded,bool tagC,
            /*end Shirt Constructors*/
            /*BaseConstructor Orders*/string clientIDCon, string employeeIDCon,  DateTime orderInitiated, DateTime dateDueC, 
            string descriptionNotesC, 
            /*cost/Balance constructor values */decimal taxC, decimal amountCollected, decimal unitCost, 
            int itemsSoldC, decimal margin, decimal labor/*end cost & base*/)
            //Base ConstructorItemsBelow
            :base(clientIDCon, employeeIDCon, orderInitiated, dateDueC, descriptionNotesC, taxC, amountCollected,  
            unitCost, itemsSoldC, margin, labor)
        {
            /*
             * ItemID;
             * 
             */
             orderType = orderTypeC;
             material = materialC;
             boolTag = tagC;
             //boolCollar = collarC;
             //sleeveType = sleeveLengthC;
             ScreensNeeded = screensNeeded;
             
        }//end Constructor

        //ShirtOrder Instance Variables
        string itemID;
        string orderType;
        string material;
        //string sleeveType;
        decimal screensNeeded;
        decimal screenPrintPricePer;
        bool boolTag;
        //bool boolCollar;

        //Properties for ShirtOrder : OrdersESP

        //Property OrderType()
        public override string OrderType()
        {
            this.OrderType();
            return "Shirt Order";
        }//end Property OrderType()

        //Property Material
        //string comes from the Item.Material(string) property
        public string Material()
        {
            return material;
        }//end Property Material

        ////Property SleeveType
        //public string SleeveType()
        //{
        //    return sleeveType;
        //}//end Property SleeveType

        //Property ScreensNeeded
        public decimal ScreensNeeded
        {
            get
            {
                return screensNeeded;
            }//end get
            set
            {
                if(value >=0)
                    screensNeeded = value;
                else
                {
                    ArgumentOutOfRangeException screensCountException = new ArgumentOutOfRangeException("Must Select a value for Screen Count.", "IF 0 Screens are needed, then please select 0 for this value");
                    throw screensCountException;
                }// end if
            }//end set
        }//end Property ScreensNeeded

        //Property PricePerScreenPrint
        public decimal ScreenPrintPricePer
        {
            get
            {
                return screenPrintPricePer;
            }//end get
            set
            {
                if(value >0)
                    screenPrintPricePer = value;
                else
                {
                    ArgumentOutOfRangeException screenPrintPriceException = new ArgumentOutOfRangeException("Cost for Screen printing must be Added.", "Screen Print Price can be found in 'Order Defaults'");
                    throw screenPrintPriceException;
                }//end if
            }//end set
        }//end Property PricePerScreenPrint

        //Property TagBool
        public bool TagBool()
        {
            return boolTag;
        }//end Property TagBool

        //Property CollarBool
        //public bool CollarBool()
        //{
        //    return boolCollar;
        //}//end Property CollarBool

        //Methods- - - - - - - - - - - - - - - - - - - - - - - - -

        //Override Methods----------------------------------------------------------------------------------- - - - - -
        public override decimal OrderTotal()
{
            decimal totalWithoutScreens = base.OrderTotal();
            return totalWithoutScreens + (this.ScreensNeeded * this.ScreenPrintPricePer);
 	throw new NotImplementedException();
}//end OrderTotal Override

    }//end ShirtOrder : OrdersESP class
}//end Namespace
