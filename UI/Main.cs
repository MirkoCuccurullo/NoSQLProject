using System;
using System.Collections.Generic;
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
        UserLogic userLogic;
        List<User> users;

        public Main()
        {
            InitializeComponent();
            db = new Databases();
            userLogic = new UserLogic();
            users = userLogic.GetAllUsers();
            DisplayPanel("Dashboard");
            InitComboBoxes();
        }

        private void DisplayPanel(string panelName)
        {
            switch (panelName)
            {
                case "CreateTicket":
                    HideAllPanels();
                    pnlCreateTicket.Show();
                    break;
                case "Dashboard":
                    HideAllPanels();
                    pnlDashboard.Show();
                    break;
            }
        }

        private void HideAllPanels()
        {
            pnlDashboard.Hide();
            pnlCreateTicket.Hide();
        }

        private void InitComboBoxes()
        {
            //assignign values to comboBoxes from enumerations
            cbPriority.DataSource = Enum.GetValues(typeof(TicketPriority));
            cbDeadline.DataSource = Enum.GetValues(typeof(TicketDeadline));
            cbIncidentType.DataSource = Enum.GetValues(typeof(TicketType));


            //adding users to combobox and tagging them
            foreach (User u in users)
            {
                cbReportUser.Items.Add(u);
                cbReportUser.Tag = u;
            }

            cbReportUser.SelectedIndex = 0;


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

            ticket.ID = new BsonObjectId(ObjectId.GenerateNewId());
            ticket.ticketDeadline = (TicketDeadline)cbDeadline.SelectedItem;
            ticket.incidentDocument.Add(new BsonElement("description", rtbTicketDescription.Text));
            ticket.ticketPriority = (TicketPriority)cbPriority.SelectedItem;
            ticket.ticketType = (TicketType)cbIncidentType.SelectedItem;
            ticket.dateTime = dtpTicketDate.Value;
            ticket.incidentDocument.Add(new BsonElement("subject", tbIncidentSubject.Text));
            ticket.UserID = ((User)cbReportUser.SelectedItem).Id;

            //parsing ticket object to bson document sending it to db
            BsonDocument document = ticket.ToBsonDocument();
            db.AddDocumentToCollection(document, "Ticket");

            MessageBox.Show("The ticket has been submited", "Successful");

            refreshCreateTicket();

        }

        private void btnCancelTicket_Click(object sender, EventArgs e)
        {
            refreshCreateTicket();
        }

        private void createTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayPanel("CreateTicket");
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayPanel("Dashboard");
        }


    }
}
