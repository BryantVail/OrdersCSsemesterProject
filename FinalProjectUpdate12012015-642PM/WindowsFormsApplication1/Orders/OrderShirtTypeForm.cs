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


        //
        public void ObjectShirtOrderCreator()
        {
            ShirtOrder currentOrder = new ShirtOrder("1243431", "Shirt Order", "100% Cotton", 5, screens, tag, "00090000C", "00090000E",
                orderTimeClock, dueDateSelector, descriptionNotes, taxForm, amountCollected, 5, itemsPurchased,
                margin, labor);
        }

        private void OrderShirtTypeForm_Load(object sender, EventArgs e)
        {
            DateTime TimeStamp = new DateTime();
            ScreensNumberNumericUpDown.Select(1, 1);
            decimal.TryParse(TaxAmounttextBox.Text, out taxForm);
                     
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
            gender = GendercomboBox.Text;
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


            int itemsPurchased;
            int quantityChosenToAdd;
                private void AddShirtDetailsbutton_Click(object sender, EventArgs e)
        {
            int.TryParse(QuantityShirtscomboBox.Text, out quantityChosenToAdd);
                itemsPurchased += quantityChosenToAdd;
                ItemCounttextBox.Text = itemsPurchased.ToString();
        }


        //Test=================================

        private void Calculatebutton_Click(object sender, EventArgs e)
        {
            if (amountCollected > 0)
                amountCollected = amountCollected * 1;
            else
            {
                decimal.TryParse(AmountPaidtextBox.Text, out amountCollected);
            }//end IF

            ShirtOrder currentOrder = new ShirtOrder("1243431", "Shirt Order", "100% Cotton", 5, screens, tag, "00090000C", "00090000E",
                orderTimeClock, dueDateSelector, descriptionNotes, taxForm, amountCollected, 5, itemsPurchased,
                margin, labor);
            ObjectShirtOrderCreator();
            TotalQuotetextBox.Text = currentOrder.OrderTotal().ToString();

        }

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
            
        }//end LaborPercentagecomboBox Handler(SelectedIndexChange)

    }//end class OrderShirtTypeForm : Form
}//end namespace
