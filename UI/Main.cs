using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Logic;
using Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;

namespace DemoApp
{
    public partial class Main : Form
    {
        private Databases db;
        private UserLogic userLogic;
        private TicketLogic ticketLogic;
        private List<User> users;
        private List<Ticket> tickets;
        private List<IncidentStatistics> incidentStatistics;
        private PasswordGenerator passwordGenerator;
        private string password;

        private User currentUser;


        public Main(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            db = new Databases();
            userLogic = new UserLogic();
            ticketLogic = new TicketLogic();
            passwordGenerator = new PasswordGenerator();
            incidentStatistics = new List<IncidentStatistics>();
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
                btnTransferTicket.Visible = false;
                btnCloseTicket.Visible = false;
                btnEscalateTicket.Visible = false;
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
            PopulateIncidentStatistics();
            DisplayUnresolvedIncidents();
            DisplayUrgentIncidents();
            DisplayFrequanciesOfIncidents();
        }

        private void PopulateIncidentStatistics()//Create incident statistic according to the type of incident
        {
            incidentStatistics.Clear();
            int[] serviceIncident = new int[] { 0, 0, 0 };
            int[] softwareIncident = new int[] { 0, 0, 0 };
            int[] hardwareIncident = new int[] { 0, 0, 0 };
            foreach (Ticket ticket in tickets)
            {
                switch (ticket.TicketType)//filter the tickets with the incident type(ticket type)
                {
                    case TicketType.Service:
                        serviceIncident[0]++;
                        if(ticket.Status.Equals(TicketStatus.Open))
                            serviceIncident[1]++;
                        if (ticket.Status.Equals(TicketStatus.Closed))
                            serviceIncident[2]++;
                        break;
                    case TicketType.Software:
                        softwareIncident[0]++;
                        if (ticket.Status.Equals(TicketStatus.Open))
                            softwareIncident[1]++;
                        if(ticket.Status.Equals(TicketStatus.Closed))
                            softwareIncident[2]++;
                        break;
                    case TicketType.Hardware:
                        hardwareIncident[0]++;
                        if(ticket.Status.Equals(TicketStatus.Open))
                            hardwareIncident[1]++;
                        if(ticket.Status.Equals(TicketStatus.Closed))
                            hardwareIncident[2]++;
                        break;
                    default:
                        break;
                }
            }
            incidentStatistics.Add(new IncidentStatistics(TicketType.Service, serviceIncident[0], serviceIncident[1], serviceIncident[2]));
            incidentStatistics.Add(new IncidentStatistics(TicketType.Software, softwareIncident[0], softwareIncident[1], softwareIncident[2]));
            incidentStatistics.Add(new IncidentStatistics(TicketType.Hardware, hardwareIncident[0], hardwareIncident[1], hardwareIncident[2]));
        }


        public void DisplayUnresolvedIncidents()
        {
            chrtUnresolvedIncident.Series[0].Points.Clear();
            if (tickets.Count.Equals(0))
                return;
            int numberOfUnresoledIncident = 0;
            foreach (IncidentStatistics inc in incidentStatistics)
            {
                numberOfUnresoledIncident += inc.OpenIncident;
            }

            double[] values = { tickets.Count, numberOfUnresoledIncident };
            string centerText = $"{values[1]}/{tickets.Count}";
            lblNumberOfUnresolvedTicket.Text = centerText;
            chrtUnresolvedIncident.Series["unreslovedIncident"].Points.AddXY("", values[0]);
            chrtUnresolvedIncident.Series["unreslovedIncident"].Points.AddXY("", values[1]);
        }

        public void DisplayUrgentIncidents()
        {
            chrtUrgentIncident.Series[0].Points.Clear();
            if (tickets.Count.Equals(0))
                return;
            int numberOfUrgentIncident = 0;
            foreach (Ticket ticket in tickets)
            {
                if (IsUrgentTicket(ticket))
                    numberOfUrgentIncident++;
            }

            double[] values = { tickets.Count,numberOfUrgentIncident };
            string centerText = $"{values[1]}";
            lblNumberOfUrgentTicket.Text =centerText;
            chrtUrgentIncident.Series["urgentIncident"].Points.AddXY("", values[0]);
            chrtUrgentIncident.Series["urgentIncident"].Points.AddXY("", values[1]);
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

        private void DisplayFrequanciesOfIncidents()
        {
            try
            {
                ClearIncidentFrequancyChart();

                lblIncidentMonitor.Text = string.Format($"The most frequant incident type: {mostFrequantIncidentType()}");
                chrtFrequancyOfIncidents.Series["Number of Incident"].Points.AddXY("Service", incidentStatistics[0].NumberOfIncident);
                chrtFrequancyOfIncidents.Series["Number of Incident"].Points.AddXY("Software", incidentStatistics[1].NumberOfIncident);
                chrtFrequancyOfIncidents.Series["Number of Incident"].Points.AddXY("Hardware", incidentStatistics[2].NumberOfIncident);
                chrtFrequancyOfIncidents.Series["unresolved Incident"].Points.AddXY("Service", incidentStatistics[0].OpenIncident);
                chrtFrequancyOfIncidents.Series["unresolved Incident"].Points.AddXY("Software", incidentStatistics[1].OpenIncident);
                chrtFrequancyOfIncidents.Series["unresolved Incident"].Points.AddXY("Hardware", incidentStatistics[2].OpenIncident);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private TicketType mostFrequantIncidentType()
        {
            int max = 0;
            TicketType ticketType=0;
            foreach(IncidentStatistics incidentType in incidentStatistics)
            {
                if (max < incidentType.NumberOfIncident) {
                    max = incidentType.NumberOfIncident;
                    ticketType = incidentType.TicketType;
                }
            }
            return ticketType;
        }

        private void ClearIncidentFrequancyChart() 
        {
            for(int i=0; i<chrtFrequancyOfIncidents.Series.Count; i++)
                chrtFrequancyOfIncidents.Series[i].Points.Clear();
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
             
            if (string.IsNullOrWhiteSpace(txtBoxFirstName.Text) || string.IsNullOrWhiteSpace(txtBoxLastName.Text) || string.IsNullOrWhiteSpace(txtBoxEmailAddress.Text)
               || string.IsNullOrWhiteSpace(txtBoxPhoneNumber.Text) || string.IsNullOrWhiteSpace(txtBoxUserName.Text))
            {
                lblCreatingUserErrorMessage.Text = " Fields cannot be left empty in order to create user ";
            }
            else 
            {
                User createdUser = CreateUser();
                string messageBoxMessage = "User has been created Suceessfully";
                // sending LoginDetails if user select CheckBox
                if (checkBoxSendpassword.Checked == true)
                {
                    try
                    {
                        EmailServer.SendLoginDetailsThroughSMTP(createdUser.Email, createdUser.Username, password);
                        messageBoxMessage = $"The login details have been sent to this email:{createdUser.Email}";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                MessageBox.Show(messageBoxMessage, "SucessFull");
                RefreshCreateUser();
                //parsing ticket object to bson document sending it to  DAL and adding to Database
                BsonDocument document = createdUser.ToBsonDocument();
                db.AddDocumentToCollection(Database.noSqlProject, document, Collection.Users);
                DisplayPanel(PanelName.UserOverview);
            }
           

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
                btnTransferTicket.Enabled = true;
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
            txtBoxUserName.Clear();
            lblUserNameExistence.Hide();
            lblCreatingUserErrorMessage.Hide();
            checkBoxSendpassword.Checked = false;
           
        }

        private void btnTransferTicket_Click(object sender, EventArgs e)
        {
            if (lvTicketOverview.SelectedItems.Count != 0)
            {
                Ticket ticket = lvTicketOverview.SelectedItems[0].Tag as Ticket;
                TransferTicket tranferTicketForm = new TransferTicket(ticket,this);
                tranferTicketForm.StartPosition = this.StartPosition;
                tranferTicketForm.ShowDialog();
            }
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

        private void btnSubmitTicket_Click_1(object sender, EventArgs e)
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

        private void btnCreateTicket_Click_1(object sender, EventArgs e)
        {
            DisplayPanel(PanelName.CreateTicket);
        }

        private void btnEscalateTicket_Click_1(object sender, EventArgs e)
        {
            if (lvTicketOverview.SelectedItems.Count != 0)
            {
                Ticket ticket = lvTicketOverview.SelectedItems[0].Tag as Ticket;
                ticketLogic.UpdateTicketStatus(ticket, TicketStatus.Escalated);
                PopulateTicketListView();
            }
        }

    }
}