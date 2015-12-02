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
    public partial class HomePageExecutiveForm : Form
    {
        public HomePageExecutiveForm()
        {
            InitializeComponent();
        }

        private void OrdersButtonToolTip_Popup(object sender, PopupEventArgs e)
        {

        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            OrdersForm OrderForm = new OrdersForm();
            //HomePageExecutiveForm HomePageExecutive = new HomePageExecutiveForm();
            this.Hide();
            OrderForm.Activate();
            OrderForm.Show();

            
        }

        private void OrdersButton_Hover(object sender, EventArgs e)
        {
            
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
