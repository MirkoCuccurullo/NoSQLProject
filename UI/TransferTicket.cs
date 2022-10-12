using Logic;
using Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoApp
{
    public partial class TransferTicket : Form
    {

      private  UserLogic ul = new UserLogic();
       private TicketLogic tl = new TicketLogic();
       private Ticket selectedTicket;
        private User currentTicketOwner;
        public TransferTicket(Ticket selectedTicket)
        {
            InitializeComponent();
            this.selectedTicket = selectedTicket;
            currentTicketOwner = ul.GetUserById(selectedTicket.UserID);
            Name ticketOwnerName = BsonSerializer.Deserialize<Name>(currentTicketOwner.Name);// must deserialize before could be used
            lblCurrentTicketUser.Text = "Current Ticket Owner: " + ticketOwnerName.First;
            InitComboBox();
        }

        private void InitComboBox()
        {
            comboBoxUsers.Items.Clear();

            List<User> users = ul.GetAllUsers();

            foreach (User user in users)
            {
                //cannot be compared with c# object because of name object on it  
                if (user.ToBsonDocument()!=currentTicketOwner.ToBsonDocument()) // not adding the user to combobox  when the current user 
                {
                    comboBoxUsers.Items.Add(user);
                    comboBoxUsers.Tag = user;
                }
            }
            comboBoxUsers.SelectedIndex = 0; // making the first default selection
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            User transferringUser = comboBoxUsers.SelectedItem as User;
            Name transferringUserName= BsonSerializer.Deserialize<Name>(transferringUser.Name);
            tl.UpdateTicketUser(selectedTicket, transferringUser);
            MessageBox.Show($"This Ticket has been transferred to {transferringUserName.First}.", "Successful");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
