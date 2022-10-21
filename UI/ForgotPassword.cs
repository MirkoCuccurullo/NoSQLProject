using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApp
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }


        private void ChangePass_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string EmailPassword = EmailPass.Text;
            string NewPassword = NewPass.Text;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            tbUsername.Text = Login.username;
        }
    }
}
