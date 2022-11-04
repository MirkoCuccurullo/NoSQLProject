using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Logic;
using Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;

namespace DemoApp
{
    public partial class Main : Form
    {

        Databases db;
        UserLogic userLogic;
        TicketLogic ticketLogic;
        List<User> users;
        List<Ticket> tickets;

        private PasswordGenerator passwordGenerator;
        private string password;

        User currentUser;


        public Main(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            db = new Databases();
            userLogic = new UserLogic();
            ticketLogic = new TicketLogic();
            passwordGenerator = new PasswordGenerator();
            users = userLogic.GetAllUsers();
            DisplayPanel(PanelName.Dashboard);
            InitComboBoxes();
            SetRolePrivilege();
        }

        private void SetRolePrivilege()
        {
            if (currentUser.Role == UserRoles.Employee)
            {
                userManagementToolStripMenuItem.Visible = false;
                createTicketToolStripMenuItem.Visible = false;
                btnCreateTicket.Visible = false;
                btnTicketArchive.Visible = false;
                btnTransferTicket.Visible = false;
                btnCloseTicket.Visible = false;
                btnEscalateTicket.Visible = false;
                btnTicketArchive.Visible = false;
                btnArchive.Visible = false;
                lbArchive.Visible = false;
                DTPArichive.Visible = false;
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            Application.Exit();
        }

        private void DisplayPanel(PanelName panelName)
        {
            switch (panelName)
            {
                case PanelName.CreateTicket:
                    HideAllPanels();
                    pnlCreateTicket.Show();
                    InitComboBoxes();
                    break;
                case PanelName.Dashboard:
                    HideAllPanels();
                    pnlDashboard.Show();
                    InitDashboard();
                    break;
                case PanelName.CreateUser:
                    HideAllPanels();
                    pnlAddUser.Show();
                    break;
                case PanelName.TicketOverview:
                    HideAllPanels();
                    pnlTicketOverview.Show();
                    PopulateTicketListView();
                    InitComboBoxes();
                    break;
                case PanelName.UserOverview:
                    HideAllPanels();
                    pnlUserOverview.Show();
                    PopulateUserListView();
                    break;
                default:
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

            cbReportUser.Items.Clear();

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

        private void InitDashboard()
        {

            if (currentUser.Role == UserRoles.ServiceDeskEmployee)
            {
                tickets = ticketLogic.GetAllTicket();

            }
            else
            {
                tickets = ticketLogic.GetAllTicketOfCurrentUser(currentUser);
            }

            DisplayUnresolvedIncidents(tickets);
            DisplayUrgentIncidents(tickets);
            
        }

        public void DisplayUnresolvedIncidents(List<Ticket> tickets)
        {
            pltIncident.Plot.Clear();
            int numberOfResolvedIncident = 0;
            int numberOfUnsolvedIncident = 0;
            foreach (Ticket ticket in tickets)
            {
                if (ticket.Status == TicketStatus.Open)
                    numberOfUnsolvedIncident++;
                else
                    numberOfResolvedIncident++;
            }

            double[] values = { numberOfResolvedIncident, numberOfUnsolvedIncident };
            string centerText = $"{values[1]} / {tickets.Count}";

            var pie = pltIncident.Plot.AddPie(values);
            pie.DonutSize = .5;
            pie.CenterFont.Size = 25;
            pie.OutlineSize = 1;
            pie.DonutLabel = centerText;
            pie.CenterFont.Color = Color.Gray;
            pie.SliceFillColors = new Color[] { Color.DarkCyan, Color.Gray };
            pltIncident.Refresh(true);
        }

        public void DisplayUrgentIncidents(List<Ticket> tickets)
        {
            pltUrgentIncident.Plot.Clear();
            int numberOfUrgentIncident = 0;
            foreach (Ticket ticket in tickets)
            {
                if (IsUrgentTicket(ticket))
                    numberOfUrgentIncident++;
            }

            double[] values = { tickets.Count,numberOfUrgentIncident };
            string centerText = $"{values[1]}";

            var pie = pltUrgentIncident.Plot.AddPie(values);
            pie.DonutSize = .5;
            pie.CenterFont.Size = 15;
            pie.DonutLabel = centerText;
            pie.CenterFont.Color = Color.Gray;
            pie.SliceFillColors = new Color[] { Color.Gray, Color.DarkRed };
            pltUrgentIncident.Refresh(true);
        }

        private bool IsUrgentTicket(Ticket ticket)
        {
            if (ticket.Status == TicketStatus.Open)
            {
                DateTime deadline = new DateTime();
                deadline = ticket.DateTime.AddDays((double)ticket.TicketDeadline);

                return DateTime.Now.CompareTo(deadline) > 0;
            }
            return false;
        }

        public void PopulateTicketListView()
        {
            try
            {
                if (currentUser.Role == UserRoles.ServiceDeskEmployee)
                {
                    //retrieveing all tickets 

                    tickets = ticketLogic.GetAllTicket();

                }
                else
                {
                    tickets = ticketLogic.GetAllTicketOfCurrentUser(currentUser);
                }

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
                    li.SubItems.Add(ticket.Status.ToString());

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
                //tickets = ticketLogic.GetAllTicket();
                users = userLogic.GetAllUsers();
                lvUserOverview.Items.Clear();

                foreach (User user in users)
                {
                    Name name = BsonSerializer.Deserialize<Name>(user.Name);
                    Ticket userTicket=ticketLogic.GetTicketByUser(user);
                    Incident incident = BsonSerializer.Deserialize<Incident>(userTicket.IncidentDocument);
                    ListViewItem li = new ListViewItem(user.Id.ToString());
                    li.SubItems.Add(user.Email);
                    li.SubItems.Add(name.First);
                    li.SubItems.Add(name.Last);
                    if(userTicket.ID!=null)
                        li.SubItems.Add(incident.Subject);
                    lvUserOverview.Items.Add(li);
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

            if (rtbTicketDescription.Text == "" || tbIncidentSubject.Text == "")
            {
                lblCreateTicketError.ForeColor = Color.Red;
                lblCreateTicketError.Text = "Subject and Description can not be empty";
                return;
            }

            if (cbIncidentType.SelectedIndex == -1 || cbDeadline.SelectedIndex == -1 || cbPriority.SelectedIndex == -1 || cbReportUser.SelectedIndex == -1)
            {
                lblCreateTicketError.Text = "Fields can not be empty";
                return;
            }

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
            ticket.Status = TicketStatus.Open;

            //parsing ticket object to bson document sending it to db
            BsonDocument document = ticket.ToBsonDocument();
            db.AddDocumentToCollection(Database.noSqlProject, document, Collection.Ticket);

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
            Name name = new Name();
            name.First = txtBoxFirstName.Text;
            name.Last = txtBoxLastName.Text;
            BsonDocument nameDocument = name.ToBsonDocument();// parsing to Bson Document
            user.Name = nameDocument;
            user.Email = txtBoxEmailAddress.Text;
            user.PhoneNumber = txtBoxPhoneNumber.Text;
            user.Role = (UserRoles)comboBoxTypeOfUser.SelectedItem;
            user.Username = txtBoxUserName.Text;
            user.Location=(Branch)comboBoxLocation.SelectedItem;
            password= passwordGenerator.RandomPasswordGenrator();  
            
            // making the password hash using password generator class
            Dictionary<string, string> passwordDictionary = passwordGenerator.GenerateSaltedHash(password);
            Password passwordObject= new Password();
            passwordObject.Salt = passwordDictionary["Salt"];
            passwordObject.Hash= passwordDictionary["HashedPassword"]; 
            user.Password= passwordObject.ToBsonDocument();
            return user;

        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
             User createdUser=CreateUser();
            string outputMessage = "User has been created Suceessfully";
            // sending LoginDetails if user select CheckBox
            if (checkBoxSendpassword.Checked == true)
            {
                try
                {
                    EmailServer.SendLoginDetailsThroughSMTP(createdUser.Email, createdUser.Username, password);
                    outputMessage = $"The login details have been send to this email:{createdUser.Email}";
                }
                catch (Exception ex )
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            MessageBox.Show(outputMessage, "SucessFull");
            RefreshCreateUser();
            //parsing ticket object to bson document sending it to  DAL and adding to Database
            BsonDocument document = createdUser.ToBsonDocument();
            db.AddDocumentToCollection(Database.noSqlProject,document, Collection.Users);
            DisplayPanel(PanelName.UserOverview);

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
            if (lvTicketOverview.SelectedItems.Count != 0)
            {
                Ticket ticket = lvTicketOverview.SelectedItems[0].Tag as Ticket;
                ticketLogic.UpdateTicketStatus(ticket, TicketStatus.Closed);
                PopulateTicketListView();
            }

        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayPanel(PanelName.UserOverview);
        }

        private void btnEscalateTicket_Click(object sender, EventArgs e)
        {
            if (lvTicketOverview.SelectedItems.Count != 0)
            {
                Ticket ticket = lvTicketOverview.SelectedItems[0].Tag as Ticket;
                ticketLogic.UpdateTicketStatus(ticket, TicketStatus.Escalated);
                PopulateTicketListView();
            }


        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            RefreshCreateUser();
        }
        private void RefreshCreateUser()
        {
            //refreshing every element of panel Create user
            InitComboBoxes();
            txtBoxEmailAddress.Clear();
            txtBoxFirstName.Clear();
            txtBoxPhoneNumber.Clear();
            txtBoxLastName.Clear();
            checkBoxSendpassword.Checked = false;
           
        }

        private void btnTransferTicket_Click(object sender, EventArgs e)
        {
            if (lvTicketOverview.SelectedItems.Count != 0)
            {
                Ticket ticket = lvTicketOverview.SelectedItems[0].Tag as Ticket;
                TransferTicket tranferTicketForm = new TransferTicket(ticket, this);
                tranferTicketForm.StartPosition = this.StartPosition;
                tranferTicketForm.ShowDialog();
            }
        }
        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            DisplayPanel(PanelName.CreateTicket);
        }

        private void txtBox_FilterBy_Click(object sender, EventArgs e)
        {
            txtBox_FilterBy.Clear();
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            DateTime date = DTPArichive.Value;
            List<Ticket> expiredTickets = new List<Ticket>();

            foreach (Ticket ticket in tickets)
            {
                if (ticket.DateTime.CompareTo(date)<=0) { expiredTickets.Add(ticket); }
            }
            ticketLogic.ArchiveTickets(expiredTickets);

            MessageBox.Show("The tickets are stored in the archive database", "Successful");

            PopulateTicketListView();
        }

        private void btnShowList_Click_1(object sender, EventArgs e)
        {
            DisplayPanel(PanelName.TicketOverview);
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            DisplayPanel(PanelName.CreateUser);
        }

        private void txtBoxUserName_TextChanged(object sender, EventArgs e)
        {
            if (userLogic.CheckExistenceOfUserName(txtBoxUserName.Text))
            {
                lblUserNameExistence.Show();
                lblUserNameExistence.Text = $"{txtBoxUserName.Text} user name already exist";
                lblUserNameExistence.ForeColor = Color.Red;
                btnCreateUser.Enabled = false;
            }
            else {
                btnCreateUser.Enabled = true;
                lblUserNameExistence.Hide();
            }
        }
    }
}