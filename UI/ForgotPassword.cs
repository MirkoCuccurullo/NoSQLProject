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
            string confirmPass = confirmPasstb.Text;

            if (NewPassword != confirmPass)
            {
                labelWarning3.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            labelWarning1.Hide();
            labelWarning2.Hide();
            labelWarning3.Hide();

            tbUsername.Text = Login.username;

        }

    }
}
