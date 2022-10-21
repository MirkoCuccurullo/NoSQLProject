using Logic;
using Model;
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
    public partial class TransferTicket : Form
    {

        UserLogic ul = new UserLogic();
        TicketLogic tl = new TicketLogic();
        Ticket ticket;
        Main main;
        public TransferTicket(Ticket selectedTicket, Main main)
        {

            InitializeComponent();
            InitComboBox();

            ticket = selectedTicket;
            this.main = main;
            
        }

        private void InitComboBox()
        {
            comboBoxUsers.Items.Clear();

            List<User> users = ul.GetAllUsers();

            foreach (User u in users)
            {
                comboBoxUsers.Items.Add(u);
                comboBoxUsers.Tag = u;
            }

            comboBoxUsers.SelectedItem = 0;
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            User user = comboBoxUsers.SelectedItem as User;

            tl.UpdateTicketUser(ticket, user);
            main.PopulateTicketListView();
            
        }
    }
}
