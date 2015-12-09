using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderEmployeedManagementWindowsNative 
{
    public partial class PanelContactInfo : UserControl
    {
        public PanelContactInfo()
        {
            InitializeComponent();
        }

        private void NameTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.Text = string.Empty;
        }

        

       

        private void ContactInfogroupBox_Enter(object sender, EventArgs e)
        {
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
            foreach (string streets in StreetTypes)
            {
                StStylecomboBox.Items.Add(streets);
            }//end foreach
        }

        private void CompanyNameTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            CompanyNameTextBox.Text=string.Empty;
            CompanyNameTextBox.ForeColor = Color.Black;
        }

        private void EmailTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            ContactEmailTextBox.Text = string.Empty;
            ContactEmailTextBox.ForeColor = Color.Black;
        }

        private void PrimaryPhonetextBox_MouseDown(object sender, MouseEventArgs e)
        {
            PrimaryPhonetextBox.Text = string.Empty;
            PrimaryPhonetextBox.ForeColor = Color.Black;
        }

        private void SecondPhoneTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            SecondPhoneTextBox.Text = string.Empty;
            SecondPhoneTextBox.ForeColor = Color.Black;
        }

        private void ContactNameTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            ContactNameTextBox.Text = string.Empty;
            ContactNameTextBox.ForeColor = Color.Black;
        }

        private void WebsiteTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            WebsiteTextBox.Text = string.Empty;
            WebsiteTextBox.ForeColor = Color.Black;
        }

        

        private void StreetNumtextBox_MouseDown(object sender, MouseEventArgs e)
        {
            StreetNumtextBox.Text = string.Empty;
            StreetNumtextBox.ForeColor = Color.Black;
        }

        private void StreetNametextBox_MouseDown(object sender, MouseEventArgs e)
        {
            StreetNametextBox.Text = string.Empty;
            StreetNametextBox.ForeColor = Color.Black;
        }

        private void StStylecomboBox_MouseDown(object sender, MouseEventArgs e)
        {
            StStylecomboBox.Text = string.Empty;
        }

        private void CitytextBox_MouseDown(object sender, MouseEventArgs e)
        {
            CitytextBox.Text = string.Empty;
            CitytextBox.ForeColor = Color.Black;
        }

        private void StatetextBox_MouseDown(object sender, MouseEventArgs e)
        {
            StatetextBox.Text = string.Empty;
            StatetextBox.ForeColor = Color.Black;
        }

        private void ZipCodetextBox_MouseDown(object sender, MouseEventArgs e)
        {
            ZipCodetextBox.Text = string.Empty;
            ZipCodetextBox.ForeColor = Color.Black;
        }

        private void ContactNotesTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            ContactNotesTextBox.Text = string.Empty;
            ContactNotesTextBox.ForeColor = Color.Black;
        }

       

        

        //private void CompanyNameTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    CompanyNameTextBox.Text=string.Empty;
        //    CompanyNameTextBox.ForeColor = Color.Black;

        //}//end Handler CompanyNameTextBox_TextChanged

       


    }//end class
}//end namespace
