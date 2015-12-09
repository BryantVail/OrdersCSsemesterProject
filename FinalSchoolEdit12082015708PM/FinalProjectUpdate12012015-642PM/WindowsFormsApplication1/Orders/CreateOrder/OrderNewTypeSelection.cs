using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderEmployeedManagementWindowsNative.Orders;


namespace OrderEmployeedManagementWindowsNative
{
    public partial class OrderBuildTypeSelectionForm : Form
    {
        public OrderBuildTypeSelectionForm()
        {
            InitializeComponent();
        }

        private void OrderBuildForm_Load(object sender, EventArgs e)
        {
            //client selection combo box, add clients & a 'more' button to bring up a window with client's or 'new' to build one.
            //ClientSelectioncomboBox.Items.AddRange(object[] items)
            ClientSelectioncomboBox.Items.Add("New");
            ClientSelectioncomboBox.Items.Add("More");
        }

        private void CreateNewOrderbutton_Click(object sender, EventArgs e)
        {
            OrderShirtTypeForm ShirtOrderForm = new OrderShirtTypeForm();
            this.Hide();
            ShirtOrderForm.ShowDialog();
            
        }
    }
}
