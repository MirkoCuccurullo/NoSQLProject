using Logic;
using Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using System;
using System.Windows.Forms;

namespace DemoApp
{
    public partial class TransferTicket : Form
    {
        private UserLogic userLogic;
        private TicketLogic ticketLogic;
        private Ticket selectedTicket;
        private User currentTicketOwner;
        private Main main;
        public TransferTicket(Ticket selectedTicket,Main main)
        {

            InitializeComponent();
            userLogic = new UserLogic();
            ticketLogic = new TicketLogic();
            this.selectedTicket = selectedTicket;
            this.main = main;
            currentTicketOwner = userLogic.GetUserById(selectedTicket.UserID);
            Name ticketOwnerName = BsonSerializer.Deserialize<Name>(currentTicketOwner.Name);// must deserialize before could be used
            lblCurrentTicketUser.Text = "Current Ticket Owner: " + ticketOwnerName.First;
            InitComboBox();

        }

        private void InitComboBox()
        {
            comboBoxUsers.Items.Clear();

            foreach (User user in userLogic.GetAllUsers())
            {
                //cannot be compared with c# object because of name object on it  
                if (user.ToBsonDocument() != currentTicketOwner.ToBsonDocument()) // not adding the user to combobox  when the current user 
                {
                    comboBoxUsers.Items.Add(user);
                    comboBoxUsers.Tag = user;
                }
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            User transferringUser = comboBoxUsers.SelectedItem as User;
            Name transferringUserName = BsonSerializer.Deserialize<Name>(transferringUser.Name);
            ticketLogic.UpdateTicketUser(selectedTicket, transferringUser);
            MessageBox.Show($"The  Ticket has been transferred from {BsonSerializer.Deserialize<Name>(currentTicketOwner.Name).First} to {transferringUserName.First}.", "Successful");
            main.PopulateTicketListView();  // refreshing the view 
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
