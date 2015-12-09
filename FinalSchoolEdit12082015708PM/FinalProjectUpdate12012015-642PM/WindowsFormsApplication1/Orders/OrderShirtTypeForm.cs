using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderEmployeedManagementWindowsNative.ClassOrdersPlusInherited;
using OrderEmployeedManagementWindowsNative.ClassItemPlusInherited;
using OrderEmployeedManagementWindowsNative;
using OrderEmployeedManagementWindowsNative.ClassClient;
using OrderEmployeedManagementWindowsNative.ClassVendor;



namespace OrderEmployeedManagementWindowsNative.Orders
{
    public partial class OrderShirtTypeForm : Form
    {
        public OrderShirtTypeForm()
        {
            InitializeComponent();
        }
        

        //Control Variables by Tab#
        decimal amountPaid;
        DateTime dueDateSelector = new DateTime();
        DateTime orderTimeClock = new DateTime();
        string gender;
        string shirtType;
        string material;
        //size, quantity, screens
        string size;
        int quantity;
        decimal screens;
        bool tag;
        string descriptionNotes;
        decimal taxForm;
        decimal amountCollected;
        decimal margin;
        decimal labor;

        //initiate Control Values

        ////
        ////Initiate Order Object:
        //public void ObjectShirtOrderCreator()
        //{
        //    ShirtOrder currentOrder = new ShirtOrder("1243431", "Shirt Order", "100% Cotton", 5, screens, tag, "00090000C", "00090000E",
        //        orderTimeClock, dueDateSelector, descriptionNotes, taxForm, amountCollected, 5, 
        //        margin, labor);
        //}//End Initiate OrderObject

        private void OrderShirtTypeForm_Load(object sender, EventArgs e)
        {
            //Add tax to the screen for user
            TaxAmounttextBox.Text = OrdersESP.SalesTax().ToString();   
            //
            DateTime TimeStamp = new DateTime();
            TimeStamp = DateTime.Now;
            
            //ScreensNumberNumericUpDown.Select(1, 1);
            decimal.TryParse(TaxAmounttextBox.Text, out taxForm);

            //Fill & sort ComboBox
            List<string> StreetTypes = new List<string>();

            //Street, Circle, Road, Way, Avenue, Boulevard, Loop, Highway
            StreetTypes.Add("Street");
            StreetTypes.Add("Circle");
            StreetTypes.Add("Road");
            StreetTypes.Add("Way");
            StreetTypes.Add("Avenue");
            StreetTypes.Add("Boulevard");
            StreetTypes.Add("Loop");
            StreetTypes.Add("Highway");

            //sort StreetTypes List
            StreetTypes.Sort();
            //add to comboBox
            foreach(string streets in StreetTypes)
            {
                //StreetTypecomboBox.Items.Add(streets);
            }//end foreach

                     
         }//end Load Method

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dueDateSelector = DueDateDateTimePicker.Value;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void QuantitycomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int.TryParse(QuantityShirtscomboBox.Text, out quantity);
        }//end QuantityShirtsComboBox Handler(SelectedIndexChanged)


       
        private void Done_Click(object sender, EventArgs e)
        {

            //
            //ClientBuilder Controls Done_buttonClick
            //
            
            
                //Initialize Values
            string clientName;
            string contactName;
            //Address
            string addStreetNum;
            string addStreet;
            string addStreetType;
            string addCity;
            string addState;
            string addZipCode;
            //end address
            string email;
            string phonePrimary;
            string phoneSecondary;
            decimal paidUpFR;   
            //decimal balance; use a method to find this value
            //OrderCount
            //MoneySpent
            //string website;   Not sure if clients need websites, still could be optional?
            DateTime clientInitiatedDate;      
            string industry;
            string clientNotes;
                //End Initialize Values

            clientName = VendorCompanyNameTextBox.Text;
            contactName=ContactNameTextBox.Text;
            //Address
            addStreetNum = VendorStreetNumtextBox.Text;
            addStreet = VendorStreetNametextBox.Text;
            addStreetType = VendorStStylecomboBox.Text;
            addCity = VendorCitytextBox.Text;
            addState = VendorStatetextBox.Text;
            addZipCode = VendorZipCodetextBox.Text;
            //End Address
            email = ContactEmailTextBox.Text;
            phonePrimary = PrimaryPhonetextBox.Text;
            phoneSecondary = SecondPhoneTextBox.Text;
            /*Initial Payment*/ decimal.TryParse(AmountPaidtextBox.Text, out paidUpFR);
            
            clientInitiatedDate = DateTime.Today;
            industry = ClientIndustryComboBox.Text;
            clientNotes = "\t" + ClientNotestextBox.Text + "\n" + ClientContactNotesTextBox.Text;


            Client ClientCurrent = new Client(clientName, contactName,
                /*Address*/addStreetNum, addStreet, addStreetType, addCity, addState, addZipCode,/*End Address*/
                email, phonePrimary, phoneSecondary, paidUpFR, clientInitiatedDate, industry, clientNotes);

            //
            //test
            //
            ClientNotestextBox.Text = ClientCurrent.ToString();

            //End ClientBuilder                                        addZipCode;
            //

            //
            //Shirt ItemBuilder
            //
            decimal     unitPrice;
            string      size;
            int         itemsQuantity;
            string      type;
            string      material;
            string      sleeve;
            int         screens;
            string      gender;
            bool        tag;
            bool        collar;
            string      brandName;
            //
            //End Item Builder
            //


            


            //Passing values from controls to variables, then to constructor
            //Method "Update"
           
            try
            {
                //Parse amount paid from text box
                decimal.TryParse(this.AmountPaidtextBox.Text, out amountPaid);
                descriptionNotes = OrderDetailstextBox.Text;
                

            
            }//end try block
            finally
            {
                //great
            }
            
        }//end DoneButton Handler(click)

        
        private void ShirtTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            shirtType = ShirtTypeComboBox.Text;
        }//end ShirtTypeComboBox Handler(SelectedIndexChanged)

        private void GendercomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            gender = GenderComboBox.Text;
        }//end Gender Combo Box Handler(SelectedIndexChanged)

        private void MaterialcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            material = ShirtMaterialcomboBox.Text;
        }//end MaterialComboBox Handler(SelectedIndexChanged)

        private void SizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            size = SizeComboBox.Text;
        }

        private void ScreensNumberNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            screens = ScreensNumberNumericUpDown.Value;
        }//end ScreensNumberNumericUpDown Handler(ValueChanged)

        private void TagBoolcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TagBoolcomboBox.Text == "Y")
                tag = true;
            else if (TagBoolcomboBox.Text == "N")
                tag = false;
            else
                tag = true;
            //end if
        }//end TagBoolComboBox Handler(SelectedIndexChanged)


        
        //Add shirt/Create Item Button
                private void AddShirtDetailsbutton_Click(object sender, EventArgs e)
        {
           //
                    
                    //Shirt Builder Add Button
                    //Controls in TabOrder
                    /*

                     * ItemUnitPriceTextBox,SizeComboBox,  QuantityShirtscomboBox,ShirtTypeComboBox, ShirtMaterialcomboBox, SleeveComboBox
                        ScreensNumberNumericUpDown, GenderComboBox, TagBoolcomboBox,CollarBoolcomboBox,  ShirtBrandcomboBox,OrderDetailstextBox
                     */

                    decimal unitPriceControlConn;
                    decimal.TryParse(ItemUnitPriceTextBox.Text, out unitPriceControlConn);
                    //end convert
                    string sizeControlConn= SizeComboBox.Text;
                    //Quantity Convert int
                    int quantityControlConn;
                    int.TryParse(QuantityShirtscomboBox.Text, out quantityControlConn);
                    //end Convert
                    int.TryParse(QuantityShirtscomboBox.Text, out quantityControlConn);
                    //end convert
                    string shirtTypeControlConn = ShirtTypeComboBox.Text;
                    string materialControlConn = ShirtMaterialcomboBox.Text;
                    string sleeveControlConn= SleeveComboBox.Text;
                    //Screens Convert to int
                    
                    int screensControlConn = decimal.ToInt32(ScreensNumberNumericUpDown.Value);
                    //end convert
                    string genderControlConn = GenderComboBox.Text;
                    //bool if for Y & N in the Combo Box
                    //for TAG & Collar
                    bool tagControlConn;
                    bool collarControlConn;
                    if(TagBoolcomboBox.Text == "Y")
                        tagControlConn= true;
                    else
                        tagControlConn = false;
                    //endif Tag

                    if (CollarBoolcomboBox.Text == "Y")
                        collarControlConn = true;
                    else
                        collarControlConn = false;
                    //endif Collar
                    //end bool Manipulation
                    string brandF = ShirtBrandcomboBox.Text ;
                    string detailsF= OrderDetailstextBox.Text;
                    //
                    //end shirtItem Control Connection
                    //
                    //
                    //Vendor Control Connection
                    //
                        //VendorCompanyNameTextBox,VendorEmailTextBox,VendorPhonePrimaryTextBox,VendorPhone2TextBox,
                   /* VendorContactNameTextBox,VendorWebsiteTextBox,VendorNotestextBox,
                    * VendorStreetNumtextBox,VendorStreetNametextBox,VendorStStylecomboBox,VendorCitytextBox,VendorStatetextBox,
                    * VendorZipCodetextBox*/

                    string compName = VendorCompanyNameTextBox.Text;
                    string itemNameF = ShirtNameTextBox.Text;
                    string emailV = VendorEmailTextBox.Text;
                    string ph1 = VendorPhonePrimaryTextBox.Text;
                    string ph2 = VendorPhone2TextBox.Text;
                    string contactNameV=VendorContactNameTextBox.Text;
                    string vendorWebsite=VendorWebsiteTextBox.Text;
                    string notesV=VendorNotestextBox.Text;

                    //address
                    string streetNum=VendorStreetNumtextBox.Text;
                    string streetName = VendorStreetNametextBox.Text;
                    string streetType = VendorStStylecomboBox.Text;
                    string cityV = VendorCitytextBox.Text;
                    string stateV = VendorStatetextBox.Text;
                    string zipCodeV = VendorZipCodetextBox.Text;
                    //endAddress

                    //Add Control References

                    //end VendorControl Conenction

                    //
                    //ShirtOrder Control Items Connection
                    //
                    
                    

                   

                    Vendor NewVendor = new Vendor(compName, contactNameV,
                        /*address*/streetNum, streetName, streetType, cityV, stateV, zipCodeV,
                        emailV, vendorWebsite, ph1, ph2, notesV);

                    ItemShirt ShirtCurrent = new ItemShirt(unitPriceControlConn, sizeControlConn, shirtTypeControlConn, itemNameF,
                        NewVendor.CompanyName, detailsF, tagControlConn, collarControlConn, sleeveControlConn, screensControlConn, materialControlConn);
                     


                    OrderDetailstextBox.Text = ShirtCurrent.ToString();
                    ItemListlistBox.Items.Add(ShirtCurrent);
                    ShirtItemQtyListBox.Items.Add(quantityControlConn.ToString());


                    
        }//end AddShirtDetailsbutton_Click


        //Test=================================

        private void Calculatebutton_Click(object sender, EventArgs e)
        {
            //for(int i; i<1; i++)
            //{
            //    foreach(ItemBase item in ShirtDetailsAddlistBox.Items)
            //    {

            //    }
            //}//end for loop

            decimal taxF ;
            decimal paidUFForm;
            decimal marginL;
            decimal laborL;



             decimal.TryParse(MarginPercentageSelectorcomboBox.Text, out marginL);
            decimal.TryParse(AmountPaidtextBox.Text, out paidUFForm);
            decimal.TryParse(TaxAmounttextBox.Text, out taxF);
            decimal.TryParse(LaborPercentagecomboBox.Text, out laborL);
            DateTime dateDue = DueDateDateTimePicker.Value;
            ShirtOrder CurrentOrder = new ShirtOrder("ItemID", "Shirt Order", "Material", /*"PricePerScreen"*/ 1.04M, /*screens*/ 4, 
                         "ClientID", "employeeID", DateTime.Today, DueDateDateTimePicker.Value, OrderDetTextBox.Text,
                         taxF, paidUFForm , marginL , laborL );

           
               
                
               
            foreach (ItemBase i in ItemListlistBox.Items)
            { decimal RunningTotal = 0;
            CurrentOrder.AddItemsOrderedItemsList(i);
                foreach (int n in ShirtItemQtyListBox.Items)
                {
                    
                     //money = RunningTotal +  n * i.UnitPrice;
                }
            }//end foreach

            string strMoney;
            //strMoney = money.ToString();
            //TotalQuotetextBox.Text = strMoney;
            for(int i =0; i> CurrentOrder.OrderedItemsListCount(); i++)
            {
                
            }
            TotalQuotetextBox.Text = "Total" ;

                
            
                
           
            
            


        }//end CalculateButton_Click

        private void MarginPercentageSelectorcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                decimal.TryParse(MarginPercentageSelectorcomboBox.Text, out margin);

            }
            catch (FormatException notDecimal)
            {
                MessageBox.Show(notDecimal.StackTrace + notDecimal.Message, "A Decimal is needed for Margin");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message + ":" + exception.StackTrace);
            }
            finally
            {
                //horse
            }//End Try Statement
            
        }

        private void LaborPercentagecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                decimal.TryParse(LaborPercentagecomboBox.Text, out labor);

            }
            catch (FormatException notDecimal)
            {
                MessageBox.Show(notDecimal.StackTrace + notDecimal.Message, "A Decimal is needed for Margin");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message + ":" + exception.StackTrace);
            }
            finally
            {
                //horse
            }//End Try Statement

        }

        private void ItemsListlable_Click(object sender, EventArgs e)
        {

        }

        private void ClientNamecomboBox_Click(object sender, EventArgs e)
        {
            ClientNamecomboBox.Text = "";
        }

        private void VendorZipCode_Click(object sender, EventArgs e)
        {
            VendorZipCodetextBox.ForeColor = Color.Black;
            VendorZipCodetextBox.Text = string.Empty;
        }

        private void ShirtMaterialcomboBox_MouseClick(object sender, MouseEventArgs e)
        {
            ShirtMaterialcomboBox.Text = string.Empty;
        }

        private void CompanyNameTextBox_AcceptsTabChanged(object sender, EventArgs e)
        {
            VendorCompanyNameTextBox.Text = string.Empty;
            VendorCompanyNameTextBox.ForeColor = Color.Black;
        }

        private void VendorEmailTextBox_AcceptsTabChanged(object sender, EventArgs e)
        {
            VendorEmailTextBox.Text = string.Empty;
            VendorEmailTextBox.ForeColor = Color.Black;
        }

        private void PrimaryPhonetextBox_AcceptsTabChanged(object sender, EventArgs e)
        {
            VendorPhonePrimaryTextBox.Text = string.Empty;
            VendorPhonePrimaryTextBox.ForeColor = Color.Black;
        }

        private void VendorContactNameTextBox_AcceptsTabChanged(object sender, EventArgs e)
        {
            VendorContactNameTextBox.Text = string.Empty;
            VendorContactNameTextBox.ForeColor = Color.Black;
        }

        private void WebsiteTextBox_AcceptsTabChanged(object sender, EventArgs e)
        {
            VendorWebsiteTextBox.Text = string.Empty;
            VendorWebsiteTextBox.ForeColor = Color.Black;
        }

        private void VendorNotestextBox_AcceptsTabChanged(object sender, EventArgs e)
        {
            VendorNotestextBox.Text = string.Empty;
            VendorNotestextBox.ForeColor = Color.Black;
        }

        private void VendorStreetNumtextBox_AcceptsTabChanged(object sender, EventArgs e)
        {
            VendorStreetNumtextBox.Text = string.Empty;
            VendorStreetNumtextBox.ForeColor = Color.Black;
        }

        private void VendorStreetNametextBox_AcceptsTabChanged(object sender, EventArgs e)
        {
            VendorStreetNametextBox.Text = string.Empty;
            VendorStreetNametextBox.ForeColor = Color.Black;
        }

        private void VendorStStylecomboBox_MouseClick(object sender, MouseEventArgs e)
        {
            VendorStStylecomboBox.Text = string.Empty;
            VendorStStylecomboBox.ForeColor = Color.Black;
        }

        private void panelContactInfo1_Load(object sender, EventArgs e)
        {
            
        }

        private void OrderDetailsTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            OrderDetTextBox.Text = string.Empty;
            OrderDetTextBox.ForeColor = Color.Black;
        }

        private void OrderDetailstextBox_MouseDown_1(object sender, MouseEventArgs e)
        {
            OrderDetTextBox.Text = string.Empty;
            OrderDetTextBox.ForeColor = Color.Black;
        }

        private void panelContactInfo1_Load_1(object sender, EventArgs e)
        {

        }

        private void CompanyNameTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            VendorCompanyNameTextBox.Text = string.Empty;
            VendorCompanyNameTextBox.ForeColor = Color.Black;
        }

        private void VendorEmailTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            VendorEmailTextBox.Text = string.Empty;
            VendorEmailTextBox.ForeColor = Color.Black;
        }

        private void PrimaryPhonetextBox_MouseDown(object sender, MouseEventArgs e)
        {
            VendorPhonePrimaryTextBox.Text = string.Empty;
            VendorPhonePrimaryTextBox.ForeColor = Color.Black;
        }

        private void Phone2TextBox_MouseDown(object sender, MouseEventArgs e)
        {
            VendorPhone2TextBox.Text = string.Empty;
            VendorPhone2TextBox.ForeColor = Color.Black;
        }

        private void VendorContactNameTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            VendorContactNameTextBox.Text = string.Empty;
            VendorContactNameTextBox.ForeColor = Color.Black;
        }

        private void WebsiteTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            VendorWebsiteTextBox.Text = string.Empty;
            VendorWebsiteTextBox.ForeColor = Color.Black;
        }

        private void VendorNotestextBox_MouseDown(object sender, MouseEventArgs e)
        {
            VendorNotestextBox.Text = string.Empty;
            VendorNotestextBox.ForeColor = Color.Black;
        }

        private void VendorStreetNumtextBox_MouseDown(object sender, MouseEventArgs e)
        {
            VendorStreetNumtextBox.Text = string.Empty;
            VendorStreetNumtextBox.ForeColor = Color.Black;

        }

        private void VendorStreetNametextBox_MouseDown(object sender, MouseEventArgs e)
        {
            VendorStreetNametextBox.Text = string.Empty;
            VendorStreetNametextBox.ForeColor = Color.Black;
        }

        private void VendorStStylecomboBox_MouseDown(object sender, MouseEventArgs e)
        {
            VendorStStylecomboBox.Text = string.Empty;
            VendorStStylecomboBox.ForeColor = Color.Black;
        }

        private void VendorCitytextBox_MouseDown(object sender, MouseEventArgs e)
        {
            VendorCitytextBox.Text = string.Empty;
            VendorCitytextBox.ForeColor = Color.Black;
        }

        private void VendorStatetextBox_MouseDown(object sender, MouseEventArgs e)
        {
            VendorStatetextBox.Text = string.Empty;
            VendorStatetextBox.ForeColor = Color.Black;
        }

        private void VendorZipCodetextBox_MouseDown(object sender, MouseEventArgs e)
        {
            VendorZipCodetextBox.Text = string.Empty;
            VendorZipCodetextBox.ForeColor = Color.Black;
        }
        decimal unitPrice;
        private void ItemUnitPriceTextBox_Leave(object sender, EventArgs e)
        {
            string strUnitPrice = ItemUnitPriceTextBox.Text;
            decimal.TryParse(strUnitPrice, out unitPrice);
        }

        private void ClientNotestextBox_MouseDown(object sender, MouseEventArgs e)
        {
            ClientNotestextBox.Text = string.Empty;
            ClientNotestextBox.ForeColor = Color.Black;
        }

        private void VendorStreetNametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShirtItemDeletebutton_Click(object sender, EventArgs e)
        {
            ItemListlistBox.Items.RemoveAt(0);
            ShirtItemQtyListBox.Items.RemoveAt(0);

        }

        private void Finishbutton_Click(object sender, EventArgs e)
        {
            //Move items from prospective list down to the subtotal & clear 'ItemListlistBox'
            foreach (ItemBase item in ItemListlistBox.Items)
            {
                
                ShirtDetailsAddlistBox.Items.Add(item);
                foreach(int num in ShirtItemQtyListBox.Items )
                {
                    CheckoutQuanititylistBox.Items.Add(num);
                }
            }//end foreach
            ItemListlistBox.Items.Clear();

            //calculate price in the text boxes for the order
            //
            int amountOfShirts = 0;
            foreach (ItemBase item in ShirtDetailsAddlistBox.Items)
            {
                amountOfShirts += 0;
            }//end foreach ItemBase Manipulation

        }//end Handler Finishbutton_Click

        

    }//end class OrderShirtTypeForm : Form
}//end namespace
