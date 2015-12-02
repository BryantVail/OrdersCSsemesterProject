using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderEmployeedManagementWindowsNative
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            OrderBuildTypeSelectionForm OrderTypeSelection = new OrderBuildTypeSelectionForm();
            OrderTypeSelection.Activate();
            OrderTypeSelection.Show();

            OrdersForm OrderForm = new OrdersForm();
            OrderForm.Hide();
        }
    }
}
