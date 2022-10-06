using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Logic;
using Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

namespace DemoApp
{
    public partial class Main : Form
    {

        Databases db;
        UserLogic userLogic;
        TicketLogic ticketLogic;
        User currentUser;
        List<User> users;


        public Main(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            db = new Databases();
            userLogic = new UserLogic();
            ticketLogic = new TicketLogic();
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
                case PanelName.CreateUser:
                    HideAllPanels();
                    pnlAddUser.Show();
                    break;
                case PanelName.TicketOverview:
                    HideAllPanels();
                    pnlTicketOverview.Show();
                    PopulateTicketListView();
                    break;
                case PanelName.UserOverview:
                    HideAllPanels();
                    pnlUserOverview.Show();
                    PopulateUserListView();
                    break;
            }
        }

        private void HideAllPanels()
        {
            pnlDashboard.Hide();
            pnlCreateTicket.Hide();
            pnlAddUser.Hide();
            pnlTicketOverview.Hide();
            pnlUserOverview.Hide();
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

        private void PopulateTicketListView()
        {
            try
            {
                //retrieveing all ordered drinks
                List<Ticket> tickets = ticketLogic.GetAllTicket();

                //clearing preavious items
                lvTicketOverview.Items.Clear();

                //checking each item in the drinkList
                foreach (Ticket ticket in tickets)
                {
                    Incident incident = BsonSerializer.Deserialize<Incident>(ticket.IncidentDocument);

                    ListViewItem li = new ListViewItem(incident.Subject);

                    User user = userLogic.GetUserById(ticket.UserID);
                    Name name = BsonSerializer.Deserialize<Name>(user.Name);
                    li.SubItems.Add(name.First);
                    li.SubItems.Add(ticket.DateTime.ToString());

                    if (ticket.Status)
                    {
                        li.SubItems.Add("Close");
                    }
                    else
                    {
                        li.SubItems.Add("Open");

                    }

                    //adding item to the list
                    lvTicketOverview.Items.Add(li);
                    li.Tag = ticket;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error");
            }
        }

        private void PopulateUserListView()
        {
            try
            {
                List<Ticket> tickets = ticketLogic.GetAllTicket();

                lvUserOverview.Items.Clear();

                foreach (User user in users)
                {
                    Name name = BsonSerializer.Deserialize<Name>(user.Name);
                    Ticket userTicket=ticketLogic.GetTicketByUser(user);
                    
                    foreach (Ticket ticket in tickets)
                    {
                        ticket.UserID = user.Id;
                        userTicket = ticket;
                    }

                    ListViewItem li = new ListViewItem(user.Id.ToString());

                    li.SubItems.Add(user.Email);
                    li.SubItems.Add(name.First);
                    li.SubItems.Add(name.Last);
                    li.SubItems.Add(userTicket.ID.ToString());

                    //adding item to the list
                    lvTicketOverview.Items.Add(li);
                    li.Tag = user;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error");
            }
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
            DisplayPanel(PanelName.CreateUser);
        }

        private User CreateUser()
        {
            User user = new User();
            user.Id = new BsonObjectId(ObjectId.GenerateNewId());
            // making new document because it is a new object in NosqlDatabase
            BsonDocument nameDocument = new BsonDocument();
            nameDocument.Add("first",txtBoxFirstName.Text);
            nameDocument.Add("last",txtBoxLastName.Text);
            user.Name = nameDocument;
            user.Email = txtBoxEmailAddress.Text;
            user.PhoneNumber = txtBoxPhoneNumber.Text;
            user.Role = (UserRoles)comboBoxTypeOfUser.SelectedItem;
            user.Location=(Branch)comboBoxLocation.SelectedItem;
            return user;

        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
             User createdUser=CreateUser();
           
            //parsing ticket object to bson document sending it to  DAL and adding to Database
            BsonDocument document = createdUser.ToBsonDocument();
            db.AddDocumentToCollection(document, "Users");

            MessageBox.Show("The new user can be created", "Successful");
        }

        private void incidentManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayPanel(PanelName.TicketOverview);
        }

        private void lvTicketOverview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTicketOverview.SelectedItems.Count != 0)
            {
                btnCloseTicket.Enabled = true;
            }
        }

        private void btnCloseTicket_Click(object sender, EventArgs e)
        {
            Ticket ticket = lvTicketOverview.SelectedItems[0].Tag as Ticket;
            ticketLogic.CloseTicket(ticket);
            PopulateTicketListView();
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayPanel(PanelName.UserOverview);
        }
    }
}
