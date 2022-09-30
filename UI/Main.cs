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
using MongoDB.Bson;
using MongoDB.Driver;

namespace DemoApp
{
    public partial class Main : Form
    {

        Databases db;
        public Main()
        {
            InitializeComponent();
            db = new Databases();
            pnlCreateTicket.Show();
            InitComboBoxes();
        }

        private void InitComboBoxes()
        {
            //assignign values to comboBoxes from enumerations
            cbPriority.DataSource = Enum.GetValues(typeof(TicketPriority));
            cbDeadline.DataSource = Enum.GetValues(typeof(TicketDeadline));
            cbIncidentType.DataSource = Enum.GetValues(typeof(TicketType));
        }

        private void refreshCreateTicket()
        {
            //refreshing every element of panel createTicket
            InitComboBoxes();
            rtbTicketDescription.Clear();
            tbIncidentSubject.Clear();
        }


        private void btnSubmitTicket_Click(object sender, EventArgs e)
        {

            //creating new Ticket and assigning values to it
            Ticket ticket = new Ticket();
            ticket.ticketDeadline = (TicketDeadline)cbPriority.SelectedItem;
            ticket.description = rtbTicketDescription.Text;
            ticket.ticketPriority = (TicketPriority)cbPriority.SelectedItem;
            ticket.ticketType = (TicketType)cbIncidentType.SelectedItem;
            ticket.dateTime = DateTime.Now;
            ticket.subject = tbIncidentSubject.Text;

            //parsing ticket object to bson document sending it to db

            BsonDocument document = ticket.ToBsonDocument();
            db.AddDocumentToCollection(document, "Ticket");

            MessageBox.Show("The ticket has been submited", "Successful");

            refreshCreateTicket();

        }
    }
}
