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
    public partial class defaultLoginForm : Form
    {
        public defaultLoginForm()
        {
            InitializeComponent();
        }

        private void defaultLoginForm_Load(object sender, EventArgs e)
        {

        }

        private void SignInMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If you cannot sign in to your workstation, first reach out to your immediate manager", "Sign In Credentials", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                HomePageExecutiveForm Form2 = new HomePageExecutiveForm();
                
                
                this.Hide();


                Form2.Activate();
                Form2.Show();
                
            }
            catch(Exception exception)
            {
                string exceptionMessage;
                exceptionMessage = exception.Message + exception.StackTrace + exception.TargetSite;
                MessageBox.Show(exceptionMessage, "Contact Administrator", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }

}
