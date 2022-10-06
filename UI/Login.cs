﻿using System;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using Logic;
using Model;
using System.Collections.Generic;
using MongoDB.Bson.Serialization;

namespace DemoApp
{
    public partial class Login : Form
    {
        private UserLogic userLogic;
        private User currentUser;
        public Login()
        {
            InitializeComponent();
            userLogic = new UserLogic();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;


            if (CheckCredentials(username,password))
            {
                Main main = new Main(currentUser);
                this.Hide();
                main.ShowDialog();              
            }

        }

        private bool CheckCredentials(string username, string password)
        {
            List<User> users = userLogic.GetAllUsers();

            foreach (User u in users)
            {
                Password pswrd = BsonSerializer.Deserialize<Password>(u.Password);
                if (u.Username == username && pswrd.Hash == password)
                {
                    currentUser = u;
                    return true;

                }
            }
            return false;

        }
    }
}