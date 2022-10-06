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
            DisplayPanel(PanelName.Dashboard);
            InitComboBoxes();
        }

        private void DisplayPanel(PanelName panelName)
        {
            switch (panelName)
            {
                case PanelName.CreateTicket:
                    HideAllPanels();
                    pnlCreateTicket.Show();
                    break;
                case PanelName.Dashboard:
                    HideAllPanels();
                    pnlDashboard.Show();
                    break;
            }
        }

        private void HideAllPanels()
        {
            pnlDashboard.Hide();
            pnlCreateTicket.Hide();
            pnlAddUser.Hide();
        }

        private void InitComboBoxes()
        {
            //assignign values to comboBoxes from enumerations
            cbPriority.DataSource = Enum.GetValues(typeof(TicketPriority));
            cbDeadline.DataSource = Enum.GetValues(typeof(TicketDeadline));
            cbIncidentType.DataSource = Enum.GetValues(typeof(TicketType));
            comboBoxTypeOfUser.DataSource= Enum.GetValues(typeof(UserRoles));
            comboBoxLocation.DataSource = Enum.GetValues(typeof(Branch));


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
            ticket.TicketDeadline = (TicketDeadline)cbDeadline.SelectedItem;
            ticket.IncidentDocument.Add(new BsonElement("description", rtbTicketDescription.Text));
            ticket.TicketPriority = (TicketPriority)cbPriority.SelectedItem;
            ticket.TicketType = (TicketType)cbIncidentType.SelectedItem;
            ticket.DateTime = dtpTicketDate.Value;
            ticket.IncidentDocument.Add(new BsonElement("subject", tbIncidentSubject.Text));
            ticket.UserID = ((User)cbReportUser.SelectedItem).Id;
            ticket.Status = false;

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
            DisplayPanel(PanelName.CreateTicket);
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayPanel(PanelName.Dashboard);
        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayPanel(PanelName.CreateTicket);
        }
    }
}
