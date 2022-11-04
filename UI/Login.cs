using System;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using Logic;
using Model;
using System.Collections.Generic;
using MongoDB.Bson.Serialization;
using System.Security.Cryptography;

namespace DemoApp
{
    public partial class Login : Form
    {
        private UserLogic userLogic;
        private User currentUser;
        private PasswordGenerator passwordGenerator;
        public static string username;
        public Login()
        {
            InitializeComponent();
            passwordGenerator = new PasswordGenerator();
            try
            {
                userLogic = new UserLogic();
            }
            catch (Exception e) 
            { 
                MessageBox.Show(e.Message,"Error");
            }
           
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            if (CheckCredentials(username, password))
            {
                Main main = new Main(currentUser);
                this.Hide();
                main.ShowDialog();
            }
            else {
                MessageBox.Show("Wrong pass");
            }
        }

        private bool CheckCredentials(string username, string password)
        {
            List<User> users = userLogic.GetAllUsers();

            foreach (User u in users)
            {
                Password pswrd = BsonSerializer.Deserialize<Password>(u.Password);
                if (u.Username == username && PasswordGenerator.ComparingPasswordToHash(password, pswrd.Salt, pswrd.Hash))
                {
                    currentUser = u;
                    return true;

                }
            }
            return false;
        }

        private void ForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUsername.Text))
            {
                MessageBox.Show("Which user are you? PLS enter your username");
            }
            else
            {

                DialogResult dialogResult = MessageBox.Show("An Email will be send with a new password", "Forgot Password", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        username = tbUsername.Text;
                        User user = userLogic.GetUserbyUsername(username);
                  
                        string randomPasswordTemp = passwordGenerator.RandomPasswordGenrator();
                        ForgotPassword forgotPassword = new ForgotPassword(randomPasswordTemp, user);
                        forgotPassword.Show();
                        //send email with random password
                        EmailServer.SendLoginDetailsThroughSMTP(user.Email, username, randomPasswordTemp);
                  
                    }
                    catch(Exception exp)
                    { MessageBox.Show(exp.Message); }

                }
                else if (dialogResult == DialogResult.No)
                {
                    //close
                }
            }
        }
    }
}
