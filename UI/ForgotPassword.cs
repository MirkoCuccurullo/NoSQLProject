using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Model;

namespace DemoApp
{
    public partial class ForgotPassword : Form
    {
        private string tempPass;
        PasswordGenerator passwordGenerator;
        private User user;
        private UserLogic userLogic;
        public ForgotPassword(string tempPass,User user)
        {
            this.tempPass = tempPass;
            userLogic = new UserLogic();
            this.passwordGenerator = new PasswordGenerator();
            this.user = user;
            InitializeComponent();
        }
        
        private void ChangePass_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string EmailPassword = EmailPass.Text;
            string NewPassword = NewPass.Text;
            string confirmPass = confirmPasstb.Text;
            User user = userLogic.GetUserbyUsername(username);

            try
            {
                if (NewPassword != confirmPass)
                {
                    labelWarning3.Show();
                }
                else if (EmailPassword != tempPass)
                {

                    labelWarning2.Show();
                }
                else
                {
                    Dictionary<string, string> passwordDictionary = passwordGenerator.GenerateSaltedHash(NewPassword);
                    Password passwordObject = new Password();
                    passwordObject.Salt = passwordDictionary["Salt"];
                    passwordObject.Hash = passwordDictionary["HashedPassword"];
                    userLogic.UpdatePassword(user, passwordObject);
                    this.Close();
                }
            }catch(Exception expe)
            {
                MessageBox.Show(expe.Message);
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
