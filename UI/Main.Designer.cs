using System.Windows.Forms;

namespace DemoApp
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {

            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();

            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbIncidentType = new System.Windows.Forms.ComboBox();
            this.cbReportUser = new System.Windows.Forms.ComboBox();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.cbDeadline = new System.Windows.Forms.ComboBox();
            this.tbIncidentSubject = new System.Windows.Forms.TextBox();
            this.rtbTicketDescription = new System.Windows.Forms.RichTextBox();
            this.btnCancelTicket = new System.Windows.Forms.Button();
            this.btnSubmitTicket = new System.Windows.Forms.Button();
            this.pnlCreateTicket = new System.Windows.Forms.Panel();
            this.lblCreateTicketError = new System.Windows.Forms.Label();
            this.dtpTicketDate = new System.Windows.Forms.DateTimePicker();
            this.pnlAddUser = new System.Windows.Forms.Panel();
            this.lblUserNameExistence = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtBoxUserName = new System.Windows.Forms.TextBox();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.checkBoxSendpassword = new System.Windows.Forms.CheckBox();
            this.lblSendPassword = new System.Windows.Forms.Label();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtBoxEmailAddress = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.txtBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.comboBoxTypeOfUser = new System.Windows.Forms.ComboBox();
            this.lblTypeOfUser = new System.Windows.Forms.Label();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.chrtFrequancyOfIncidents = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.btnShowList = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblIncidentDeadlineTickets = new System.Windows.Forms.Label();
            this.lblOpenTickets = new System.Windows.Forms.Label();
            this.lblIncidentDeadline = new System.Windows.Forms.Label();
            this.lblUnresolvedIncident = new System.Windows.Forms.Label();
            this.lblCurrentIncident = new System.Windows.Forms.Label();
            this.pltIncident = new ScottPlot.FormsPlot();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pnlTicketOverview = new System.Windows.Forms.Panel();
            this.btnArchive = new System.Windows.Forms.Button();
            this.lbArchive = new System.Windows.Forms.Label();
            this.DTPArichive = new System.Windows.Forms.DateTimePicker();
            this.btnTransferTicket = new System.Windows.Forms.Button();
            this.txtBox_FilterBy = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCreateTicket = new System.Windows.Forms.Button();
            this.btnEscalateTicket = new System.Windows.Forms.Button();
            this.btnCloseTicket = new System.Windows.Forms.Button();
            this.btnTicketArchive = new System.Windows.Forms.Button();
            this.lvTicketOverview = new System.Windows.Forms.ListView();
            this.clSubject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clUser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvUserOverview = new System.Windows.Forms.ListView();
            this.userId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ticket = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlUserOverview = new System.Windows.Forms.Panel();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblIncidentMonitor = new MaterialSkin.Controls.MaterialLabel();
            this.chrtUrgentIncident = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblNumberOfUrgentTicket = new System.Windows.Forms.Label();
            this.pnlCreateTicket.SuspendLayout();
            this.pnlAddUser.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtFrequancyOfIncidents)).BeginInit();
            this.pnlTicketOverview.SuspendLayout();
            this.pnlUserOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtUrgentIncident)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;

            this.label1.Location = new System.Drawing.Point(129, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);

            this.label1.TabIndex = 0;
            this.label1.Text = "DateTime Reported";
            // 
            // label2
            // 
            this.label2.AutoSize = true;

            this.label2.Location = new System.Drawing.Point(129, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 25);

            this.label2.TabIndex = 1;
            this.label2.Text = "Subject of incident";
            // 
            // label3
            // 
            this.label3.AutoSize = true;

            this.label3.Location = new System.Drawing.Point(122, 297);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 25);

            this.label3.TabIndex = 2;
            this.label3.Text = "Type of Incident";
            // 
            // label4
            // 
            this.label4.AutoSize = true;

            this.label4.Location = new System.Drawing.Point(122, 408);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 25);

            this.label4.TabIndex = 3;
            this.label4.Text = "Reported by user";
            // 
            // label5
            // 
            this.label5.AutoSize = true;

            this.label5.Location = new System.Drawing.Point(129, 539);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);

            this.label5.TabIndex = 4;
            this.label5.Text = "Priority";
            // 
            // label6
            // 
            this.label6.AutoSize = true;

            this.label6.Location = new System.Drawing.Point(129, 642);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 25);

            this.label6.TabIndex = 5;
            this.label6.Text = "Deadline/Followup";
            // 
            // label7
            // 
            this.label7.AutoSize = true;

            this.label7.Location = new System.Drawing.Point(122, 772);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);

            this.label7.TabIndex = 6;
            this.label7.Text = "Description";
            // 
            // cbIncidentType
            // 
            this.cbIncidentType.FormattingEnabled = true;

            this.cbIncidentType.Location = new System.Drawing.Point(476, 284);
            this.cbIncidentType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbIncidentType.Name = "cbIncidentType";
            this.cbIncidentType.Size = new System.Drawing.Size(394, 33);

            this.cbIncidentType.TabIndex = 8;
            // 
            // cbReportUser
            // 
            this.cbReportUser.FormattingEnabled = true;

            this.cbReportUser.Location = new System.Drawing.Point(476, 395);
            this.cbReportUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbReportUser.Name = "cbReportUser";
            this.cbReportUser.Size = new System.Drawing.Size(394, 33);

            this.cbReportUser.TabIndex = 9;
            // 
            // cbPriority
            // 
            this.cbPriority.FormattingEnabled = true;

            this.cbPriority.Location = new System.Drawing.Point(476, 508);
            this.cbPriority.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(394, 33);

            this.cbPriority.TabIndex = 10;
            // 
            // cbDeadline
            // 
            this.cbDeadline.FormattingEnabled = true;

            this.cbDeadline.Location = new System.Drawing.Point(476, 630);
            this.cbDeadline.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbDeadline.Name = "cbDeadline";
            this.cbDeadline.Size = new System.Drawing.Size(394, 33);

            this.cbDeadline.TabIndex = 11;
            // 
            // tbIncidentSubject
            // 

            this.tbIncidentSubject.Location = new System.Drawing.Point(476, 183);
            this.tbIncidentSubject.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbIncidentSubject.Name = "tbIncidentSubject";
            this.tbIncidentSubject.Size = new System.Drawing.Size(394, 31);

            this.tbIncidentSubject.TabIndex = 12;
            // 
            // rtbTicketDescription
            // 

            this.rtbTicketDescription.Location = new System.Drawing.Point(476, 767);
            this.rtbTicketDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbTicketDescription.Name = "rtbTicketDescription";
            this.rtbTicketDescription.Size = new System.Drawing.Size(394, 279);

            this.rtbTicketDescription.TabIndex = 13;
            this.rtbTicketDescription.Text = "";
            // 
            // btnCancelTicket
            // 

            this.btnCancelTicket.Location = new System.Drawing.Point(476, 1155);
            this.btnCancelTicket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelTicket.Name = "btnCancelTicket";
            this.btnCancelTicket.Size = new System.Drawing.Size(146, 59);

            this.btnCancelTicket.TabIndex = 14;
            this.btnCancelTicket.Text = "Cancel";
            this.btnCancelTicket.UseVisualStyleBackColor = true;
            this.btnCancelTicket.Click += new System.EventHandler(this.btnCancelTicket_Click);
            // 
            // btnSubmitTicket
            // 
            this.btnSubmitTicket.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSubmitTicket.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;

            this.btnSubmitTicket.Location = new System.Drawing.Point(726, 1155);
            this.btnSubmitTicket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmitTicket.Name = "btnSubmitTicket";
            this.btnSubmitTicket.Size = new System.Drawing.Size(146, 59);

            this.btnSubmitTicket.TabIndex = 15;
            this.btnSubmitTicket.Text = "Submit Ticket";
            this.btnSubmitTicket.UseVisualStyleBackColor = false;
            this.btnSubmitTicket.Click += new System.EventHandler(this.btnSubmitTicket_Click);
            // 
            // pnlCreateTicket
            // 
            this.pnlCreateTicket.Controls.Add(this.lblCreateTicketError);
            this.pnlCreateTicket.Controls.Add(this.dtpTicketDate);
            this.pnlCreateTicket.Controls.Add(this.label1);
            this.pnlCreateTicket.Controls.Add(this.label2);
            this.pnlCreateTicket.Controls.Add(this.label3);
            this.pnlCreateTicket.Controls.Add(this.label4);
            this.pnlCreateTicket.Controls.Add(this.label5);
            this.pnlCreateTicket.Controls.Add(this.label6);
            this.pnlCreateTicket.Controls.Add(this.label7);
            this.pnlCreateTicket.Controls.Add(this.cbIncidentType);
            this.pnlCreateTicket.Controls.Add(this.cbReportUser);
            this.pnlCreateTicket.Controls.Add(this.cbPriority);
            this.pnlCreateTicket.Controls.Add(this.cbDeadline);
            this.pnlCreateTicket.Controls.Add(this.tbIncidentSubject);
            this.pnlCreateTicket.Controls.Add(this.rtbTicketDescription);
            this.pnlCreateTicket.Controls.Add(this.btnCancelTicket);
            this.pnlCreateTicket.Controls.Add(this.btnSubmitTicket);

            this.pnlCreateTicket.Location = new System.Drawing.Point(2, 33);
            this.pnlCreateTicket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCreateTicket.Name = "pnlCreateTicket";
            this.pnlCreateTicket.Size = new System.Drawing.Size(1192, 1359);

            this.pnlCreateTicket.TabIndex = 16;
            // 
            // lblCreateTicketError
            // 
            this.lblCreateTicketError.AutoSize = true;

            this.lblCreateTicketError.Location = new System.Drawing.Point(476, 1270);
            this.lblCreateTicketError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreateTicketError.Name = "lblCreateTicketError";
            this.lblCreateTicketError.Size = new System.Drawing.Size(0, 25);

            this.lblCreateTicketError.TabIndex = 18;
            // 
            // dtpTicketDate
            // 

            this.dtpTicketDate.Location = new System.Drawing.Point(476, 78);
            this.dtpTicketDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpTicketDate.Name = "dtpTicketDate";
            this.dtpTicketDate.Size = new System.Drawing.Size(394, 31);

            this.dtpTicketDate.TabIndex = 17;
            // 
            // pnlAddUser
            // 
            this.pnlAddUser.Controls.Add(this.lblUserNameExistence);
            this.pnlAddUser.Controls.Add(this.lblUsername);
            this.pnlAddUser.Controls.Add(this.txtBoxUserName);
            this.pnlAddUser.Controls.Add(this.btnCreateUser);
            this.pnlAddUser.Controls.Add(this.btnCancel);
            this.pnlAddUser.Controls.Add(this.lblDisplay);
            this.pnlAddUser.Controls.Add(this.checkBoxSendpassword);
            this.pnlAddUser.Controls.Add(this.lblSendPassword);
            this.pnlAddUser.Controls.Add(this.comboBoxLocation);
            this.pnlAddUser.Controls.Add(this.lblLocation);
            this.pnlAddUser.Controls.Add(this.txtBoxEmailAddress);
            this.pnlAddUser.Controls.Add(this.lblEmailAddress);
            this.pnlAddUser.Controls.Add(this.txtBoxPhoneNumber);
            this.pnlAddUser.Controls.Add(this.lblPhoneNumber);
            this.pnlAddUser.Controls.Add(this.comboBoxTypeOfUser);
            this.pnlAddUser.Controls.Add(this.lblTypeOfUser);
            this.pnlAddUser.Controls.Add(this.txtBoxLastName);
            this.pnlAddUser.Controls.Add(this.lblLastName);
            this.pnlAddUser.Controls.Add(this.txtBoxFirstName);
            this.pnlAddUser.Controls.Add(this.lblFirstName);

            this.pnlAddUser.Location = new System.Drawing.Point(8, 38);
            this.pnlAddUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlAddUser.Name = "pnlAddUser";
            this.pnlAddUser.Size = new System.Drawing.Size(1192, 1359);

            this.pnlAddUser.TabIndex = 18;
            // 
            // lblUserNameExistence
            // 
            this.lblUserNameExistence.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameExistence.Location = new System.Drawing.Point(214, 258);
            this.lblUserNameExistence.Name = "lblUserNameExistence";
            this.lblUserNameExistence.Size = new System.Drawing.Size(488, 23);
            this.lblUserNameExistence.TabIndex = 20;
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(67, 282);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(100, 23);
            this.lblUsername.TabIndex = 19;
            this.lblUsername.Text = "User Name";
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.Location = new System.Drawing.Point(210, 280);
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.Size = new System.Drawing.Size(492, 26);
            this.txtBoxUserName.TabIndex = 18;
            this.txtBoxUserName.TextChanged += new System.EventHandler(this.txtBoxUserName_TextChanged);
            // 
            // btnCreateUser
            // 

            this.btnCreateUser.Location = new System.Drawing.Point(720, 823);
            this.btnCreateUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(270, 72);

            this.btnCreateUser.TabIndex = 17;
            this.btnCreateUser.Text = "Create";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnCancel
            // 

            this.btnCancel.Location = new System.Drawing.Point(345, 823);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(270, 72);

            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.lblDisplay.Location = new System.Drawing.Point(26, 17);
            this.lblDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(524, 75);

            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "Create New User";
            // 
            // checkBoxSendpassword
            // 
            this.checkBoxSendpassword.Location = new System.Drawing.Point(310, 686);
            this.checkBoxSendpassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxSendpassword.Name = "checkBoxSendpassword";
            this.checkBoxSendpassword.Size = new System.Drawing.Size(471, 38);

            this.checkBoxSendpassword.TabIndex = 14;
            this.checkBoxSendpassword.Text = "yes, a password email will be sent to user";
            this.checkBoxSendpassword.UseVisualStyleBackColor = true;
            // 
            // lblSendPassword
            // 

            this.lblSendPassword.Location = new System.Drawing.Point(94, 688);
            this.lblSendPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSendPassword.Name = "lblSendPassword";
            this.lblSendPassword.Size = new System.Drawing.Size(207, 36);

            this.lblSendPassword.TabIndex = 13;
            this.lblSendPassword.Text = "Send Passsword?";
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLocation.FormattingEnabled = true;

            this.comboBoxLocation.Location = new System.Drawing.Point(278, 606);
            this.comboBoxLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(655, 33);

            this.comboBoxLocation.TabIndex = 12;
            // 
            // lblLocation
            // 

            this.lblLocation.Location = new System.Drawing.Point(94, 611);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(182, 36);

            this.lblLocation.TabIndex = 11;
            this.lblLocation.Text = "Location/Branch: ";
            // 
            // txtBoxEmailAddress
            // 

            this.txtBoxEmailAddress.Location = new System.Drawing.Point(278, 533);
            this.txtBoxEmailAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxEmailAddress.Name = "txtBoxEmailAddress";
            this.txtBoxEmailAddress.Size = new System.Drawing.Size(655, 31);

            this.txtBoxEmailAddress.TabIndex = 10;
            // 
            // lblEmailAddress
            // 

            this.lblEmailAddress.Location = new System.Drawing.Point(104, 531);
            this.lblEmailAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(206, 36);

            this.lblEmailAddress.TabIndex = 9;
            this.lblEmailAddress.Text = "Email address: ";
            // 
            // txtBoxPhoneNumber
            // 

            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(278, 450);
            this.txtBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(655, 31);

            this.txtBoxPhoneNumber.TabIndex = 8;
            // 
            // lblPhoneNumber
            // 

            this.lblPhoneNumber.Location = new System.Drawing.Point(104, 448);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(218, 36);

            this.lblPhoneNumber.TabIndex = 7;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // comboBoxTypeOfUser
            // 
            this.comboBoxTypeOfUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeOfUser.FormattingEnabled = true;

            this.comboBoxTypeOfUser.Location = new System.Drawing.Point(278, 338);
            this.comboBoxTypeOfUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxTypeOfUser.Name = "comboBoxTypeOfUser";
            this.comboBoxTypeOfUser.Size = new System.Drawing.Size(655, 33);

            this.comboBoxTypeOfUser.TabIndex = 6;
            // 
            // lblTypeOfUser
            // 

            this.lblTypeOfUser.Location = new System.Drawing.Point(104, 339);
            this.lblTypeOfUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeOfUser.Name = "lblTypeOfUser";
            this.lblTypeOfUser.Size = new System.Drawing.Size(150, 36);

            this.lblTypeOfUser.TabIndex = 5;
            this.lblTypeOfUser.Text = "Type of User:  ";
            // 
            // txtBoxLastName
            // 

            this.txtBoxLastName.Location = new System.Drawing.Point(278, 250);
            this.txtBoxLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(655, 31);

            this.txtBoxLastName.TabIndex = 4;
            // 
            // lblLastName
            // 

            this.lblLastName.Location = new System.Drawing.Point(104, 248);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(150, 36);

            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name: ";
            // 
            // txtBoxFirstName
            // 

            this.txtBoxFirstName.Location = new System.Drawing.Point(278, 167);
            this.txtBoxFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(655, 31);

            this.txtBoxFirstName.TabIndex = 2;
            // 
            // lblFirstName
            // 

            this.lblFirstName.Location = new System.Drawing.Point(104, 166);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(150, 36);

            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.incidentManagementToolStripMenuItem,
            this.userManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 48);

            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";

            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(149, 44);

            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // incidentManagementToolStripMenuItem
            // 
            this.incidentManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTicketToolStripMenuItem});
            this.incidentManagementToolStripMenuItem.Name = "incidentManagementToolStripMenuItem";

            this.incidentManagementToolStripMenuItem.Size = new System.Drawing.Size(270, 44);

            this.incidentManagementToolStripMenuItem.Text = "Incident Management";
            this.incidentManagementToolStripMenuItem.Click += new System.EventHandler(this.incidentManagementToolStripMenuItem_Click);
            // 
            // createTicketToolStripMenuItem
            // 
            this.createTicketToolStripMenuItem.Name = "createTicketToolStripMenuItem";

            this.createTicketToolStripMenuItem.Size = new System.Drawing.Size(286, 44);

            this.createTicketToolStripMenuItem.Text = "Create Ticket";
            this.createTicketToolStripMenuItem.Click += new System.EventHandler(this.createTicketToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createUserToolStripMenuItem});
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";

            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(231, 44);

            this.userManagementToolStripMenuItem.Text = "User Management";
            this.userManagementToolStripMenuItem.Click += new System.EventHandler(this.userManagementToolStripMenuItem_Click);
            // 
            // createUserToolStripMenuItem
            // 
            this.createUserToolStripMenuItem.Name = "createUserToolStripMenuItem";

            this.createUserToolStripMenuItem.Size = new System.Drawing.Size(270, 44);

            this.createUserToolStripMenuItem.Text = "Create User";
            this.createUserToolStripMenuItem.Click += new System.EventHandler(this.createUserToolStripMenuItem_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.lblNumberOfUrgentTicket);
            this.pnlDashboard.Controls.Add(this.chrtUrgentIncident);
            this.pnlDashboard.Controls.Add(this.lblIncidentMonitor);
            this.pnlDashboard.Controls.Add(this.chrtFrequancyOfIncidents);
            this.pnlDashboard.Controls.Add(this.richTextBox3);
            this.pnlDashboard.Controls.Add(this.formsPlot1);
            this.pnlDashboard.Controls.Add(this.btnShowList);
            this.pnlDashboard.Controls.Add(this.lblIncidentDeadlineTickets);
            this.pnlDashboard.Controls.Add(this.lblOpenTickets);
            this.pnlDashboard.Controls.Add(this.lblIncidentDeadline);
            this.pnlDashboard.Controls.Add(this.lblUnresolvedIncident);
            this.pnlDashboard.Controls.Add(this.lblCurrentIncident);
            this.pnlDashboard.Controls.Add(this.pltIncident);
            this.pnlDashboard.Controls.Add(this.richTextBox2);
            this.pnlDashboard.Controls.Add(this.richTextBox1);

            this.pnlDashboard.Location = new System.Drawing.Point(2, 42);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1191, 1300);
            this.pnlDashboard.TabIndex = 18;
            // 
            // chrtFrequancyOfIncidents
            // 
            chartArea4.Name = "ChartArea1";
            this.chrtFrequancyOfIncidents.ChartAreas.Add(chartArea4);
            legend2.Name = "Legend1";
            this.chrtFrequancyOfIncidents.Legends.Add(legend2);
            this.chrtFrequancyOfIncidents.Location = new System.Drawing.Point(105, 841);
            this.chrtFrequancyOfIncidents.Name = "chrtFrequancyOfIncidents";
            this.chrtFrequancyOfIncidents.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Number of Incident";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "unresolved Incident(%)";
            this.chrtFrequancyOfIncidents.Series.Add(series5);
            this.chrtFrequancyOfIncidents.Series.Add(series6);
            this.chrtFrequancyOfIncidents.Size = new System.Drawing.Size(994, 355);
            this.chrtFrequancyOfIncidents.TabIndex = 7;
            this.chrtFrequancyOfIncidents.Text = "frequancy";
            title2.Name = "Title1";
            title2.Text = "Frequancy of Incident(monthly)";
            this.chrtFrequancyOfIncidents.Titles.Add(title2);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(48, 814);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(1102, 451);

            this.richTextBox3.TabIndex = 6;
            this.richTextBox3.Text = "";
            // 
            // formsPlot1
            // 

            this.formsPlot1.Location = new System.Drawing.Point(1038, 362);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(8, 8);

            this.formsPlot1.TabIndex = 5;
            // 
            // btnShowList
            // 
            this.btnShowList.AutoSize = true;
            this.btnShowList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnShowList.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnShowList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnShowList.Depth = 0;
            this.btnShowList.ForeColor = System.Drawing.SystemColors.Window;
            this.btnShowList.Icon = null;

            this.btnShowList.Location = new System.Drawing.Point(970, 83);
            this.btnShowList.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Primary = true;
            this.btnShowList.Size = new System.Drawing.Size(167, 36);

            this.btnShowList.TabIndex = 4;
            this.btnShowList.Text = "SHOW LIST";
            this.btnShowList.UseVisualStyleBackColor = false;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click_1);
            // 
            // lblIncidentDeadlineTickets
            // 
            this.lblIncidentDeadlineTickets.AutoSize = true;
            this.lblIncidentDeadlineTickets.BackColor = System.Drawing.SystemColors.Window;
            this.lblIncidentDeadlineTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.lblIncidentDeadlineTickets.Location = new System.Drawing.Point(645, 284);
            this.lblIncidentDeadlineTickets.Name = "lblIncidentDeadlineTickets";
            this.lblIncidentDeadlineTickets.Size = new System.Drawing.Size(485, 29);

            this.lblIncidentDeadlineTickets.TabIndex = 1;
            this.lblIncidentDeadlineTickets.Text = "These tickets need your immediate attention";
            // 
            // lblOpenTickets
            // 
            this.lblOpenTickets.AutoSize = true;
            this.lblOpenTickets.BackColor = System.Drawing.SystemColors.Window;
            this.lblOpenTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.lblOpenTickets.Location = new System.Drawing.Point(182, 284);
            this.lblOpenTickets.Name = "lblOpenTickets";
            this.lblOpenTickets.Size = new System.Drawing.Size(272, 29);

            this.lblOpenTickets.TabIndex = 1;
            this.lblOpenTickets.Text = "All tickets currently open";
            // 
            // lblIncidentDeadline
            // 
            this.lblIncidentDeadline.AutoSize = true;
            this.lblIncidentDeadline.BackColor = System.Drawing.SystemColors.Window;
            this.lblIncidentDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.lblIncidentDeadline.Location = new System.Drawing.Point(724, 234);
            this.lblIncidentDeadline.Name = "lblIncidentDeadline";
            this.lblIncidentDeadline.Size = new System.Drawing.Size(343, 37);

            this.lblIncidentDeadline.TabIndex = 1;
            this.lblIncidentDeadline.Text = "Incidents past deadline";
            // 
            // lblUnresolvedIncident
            // 
            this.lblUnresolvedIncident.AutoSize = true;
            this.lblUnresolvedIncident.BackColor = System.Drawing.SystemColors.Window;
            this.lblUnresolvedIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.lblUnresolvedIncident.Location = new System.Drawing.Point(160, 234);
            this.lblUnresolvedIncident.Name = "lblUnresolvedIncident";
            this.lblUnresolvedIncident.Size = new System.Drawing.Size(312, 37);

            this.lblUnresolvedIncident.TabIndex = 1;
            this.lblUnresolvedIncident.Text = "Unresolved incidents";
            // 
            // lblCurrentIncident
            // 
            this.lblCurrentIncident.AutoSize = true;
            this.lblCurrentIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.lblCurrentIncident.Location = new System.Drawing.Point(60, 59);
            this.lblCurrentIncident.Name = "lblCurrentIncident";
            this.lblCurrentIncident.Size = new System.Drawing.Size(428, 61);
            this.lblCurrentIncident.TabIndex = 1;
            this.lblCurrentIncident.Text = "Current incidents";
            // 
            // pltIncident
            // 
            this.pltIncident.BackColor = System.Drawing.SystemColors.Window;
            this.pltIncident.Location = new System.Drawing.Point(96, 334);
            this.pltIncident.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.pltIncident.Name = "pltIncident";
            this.pltIncident.Size = new System.Drawing.Size(450, 450);
            this.pltIncident.TabIndex = 0;
            // 
            // richTextBox2
            // 

            this.richTextBox2.Location = new System.Drawing.Point(610, 188);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(540, 599);

            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 

            this.richTextBox1.Location = new System.Drawing.Point(48, 188);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(540, 599);

            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // pnlTicketOverview
            // 
            this.pnlTicketOverview.Controls.Add(this.btnArchive);
            this.pnlTicketOverview.Controls.Add(this.lbArchive);
            this.pnlTicketOverview.Controls.Add(this.DTPArichive);
            this.pnlTicketOverview.Controls.Add(this.btnTransferTicket);
            this.pnlTicketOverview.Controls.Add(this.txtBox_FilterBy);
            this.pnlTicketOverview.Controls.Add(this.label8);
            this.pnlTicketOverview.Controls.Add(this.btnCreateTicket);
            this.pnlTicketOverview.Controls.Add(this.btnEscalateTicket);
            this.pnlTicketOverview.Controls.Add(this.btnCloseTicket);
            this.pnlTicketOverview.Controls.Add(this.btnTicketArchive);
            this.pnlTicketOverview.Controls.Add(this.lvTicketOverview);

            this.pnlTicketOverview.Location = new System.Drawing.Point(0, 50);
            this.pnlTicketOverview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTicketOverview.Name = "pnlTicketOverview";
            this.pnlTicketOverview.Size = new System.Drawing.Size(1200, 1339);

            this.pnlTicketOverview.TabIndex = 18;
            // 
            // btnArchive
            // 

            this.btnArchive.Location = new System.Drawing.Point(117, 977);
            this.btnArchive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(170, 36);

            this.btnArchive.TabIndex = 25;
            this.btnArchive.Text = "Archive Tickets";
            this.btnArchive.UseVisualStyleBackColor = true;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // lbArchive
            // 
            this.lbArchive.AutoSize = true;

            this.lbArchive.Location = new System.Drawing.Point(298, 981);
            this.lbArchive.Name = "lbArchive";
            this.lbArchive.Size = new System.Drawing.Size(174, 25);

            this.lbArchive.TabIndex = 24;
            this.lbArchive.Text = "that made before";
            // 
            // DTPArichive
            // 

            this.DTPArichive.Location = new System.Drawing.Point(488, 980);
            this.DTPArichive.Name = "DTPArichive";
            this.DTPArichive.Size = new System.Drawing.Size(400, 31);

            this.DTPArichive.TabIndex = 23;
            // 
            // btnTransferTicket
            // 

            this.btnTransferTicket.Location = new System.Drawing.Point(920, 33);
            this.btnTransferTicket.Name = "btnTransferTicket";
            this.btnTransferTicket.Size = new System.Drawing.Size(170, 36);

            this.btnTransferTicket.TabIndex = 20;
            this.btnTransferTicket.Text = "Transfer Ticket ";
            this.btnTransferTicket.UseVisualStyleBackColor = true;
            this.btnTransferTicket.Click += new System.EventHandler(this.btnTransferTicket_Click);
            // 
            // txtBox_FilterBy
            // 
            this.txtBox_FilterBy.ForeColor = System.Drawing.Color.Gray;

            this.txtBox_FilterBy.Location = new System.Drawing.Point(116, 94);
            this.txtBox_FilterBy.Name = "txtBox_FilterBy";
            this.txtBox_FilterBy.Size = new System.Drawing.Size(356, 31);

            this.txtBox_FilterBy.TabIndex = 22;
            this.txtBox_FilterBy.Text = "Filter by subject...";
            this.txtBox_FilterBy.Click += new System.EventHandler(this.txtBox_FilterBy_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            this.label8.Location = new System.Drawing.Point(110, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(256, 37);

            this.label8.TabIndex = 21;
            this.label8.Text = "Ticket Overview";
            // 
            // btnCreateTicket
            // 

            this.btnCreateTicket.Location = new System.Drawing.Point(728, 33);
            this.btnCreateTicket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateTicket.Name = "btnCreateTicket";
            this.btnCreateTicket.Size = new System.Drawing.Size(170, 36);

            this.btnCreateTicket.TabIndex = 20;
            this.btnCreateTicket.Text = "Create Ticket";
            this.btnCreateTicket.UseVisualStyleBackColor = true;
            this.btnCreateTicket.Click += new System.EventHandler(this.btnCreateTicket_Click);
            // 
            // btnEscalateTicket
            // 

            this.btnEscalateTicket.Location = new System.Drawing.Point(728, 89);
            this.btnEscalateTicket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEscalateTicket.Name = "btnEscalateTicket";
            this.btnEscalateTicket.Size = new System.Drawing.Size(170, 36);

            this.btnEscalateTicket.TabIndex = 19;
            this.btnEscalateTicket.Text = "Escalate Ticket";
            this.btnEscalateTicket.UseVisualStyleBackColor = true;
            this.btnEscalateTicket.Click += new System.EventHandler(this.btnEscalateTicket_Click);
            // 
            // btnCloseTicket
            // 

            this.btnCloseTicket.Location = new System.Drawing.Point(920, 89);
            this.btnCloseTicket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCloseTicket.Name = "btnCloseTicket";
            this.btnCloseTicket.Size = new System.Drawing.Size(170, 36);

            this.btnCloseTicket.TabIndex = 1;
            this.btnCloseTicket.Text = "Close Ticket";
            this.btnCloseTicket.UseVisualStyleBackColor = true;
            this.btnCloseTicket.Click += new System.EventHandler(this.btnCloseTicket_Click);
            // 
            // btnTicketArchive
            // 
            this.btnTicketArchive.Enabled = false;

            this.btnTicketArchive.Location = new System.Drawing.Point(728, 89);
            this.btnTicketArchive.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTicketArchive.Name = "btnTicketArchive";
            this.btnTicketArchive.Size = new System.Drawing.Size(170, 36);

            this.btnTicketArchive.TabIndex = 18;
            this.btnTicketArchive.Text = "Ticket Archive";
            this.btnTicketArchive.UseVisualStyleBackColor = true;
            // 
            // lvTicketOverview
            // 
            this.lvTicketOverview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clSubject,
            this.clUser,
            this.clDate,
            this.clStatus});
            this.lvTicketOverview.FullRowSelect = true;
            this.lvTicketOverview.HideSelection = false;

            this.lvTicketOverview.Location = new System.Drawing.Point(116, 153);
            this.lvTicketOverview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvTicketOverview.MultiSelect = false;
            this.lvTicketOverview.Name = "lvTicketOverview";
            this.lvTicketOverview.Size = new System.Drawing.Size(972, 799);

            this.lvTicketOverview.TabIndex = 0;
            this.lvTicketOverview.UseCompatibleStateImageBehavior = false;
            this.lvTicketOverview.View = System.Windows.Forms.View.Details;
            this.lvTicketOverview.SelectedIndexChanged += new System.EventHandler(this.lvTicketOverview_SelectedIndexChanged);
            // 
            // clSubject
            // 
            this.clSubject.Text = "Subject";
            this.clSubject.Width = 150;
            // 
            // clUser
            // 
            this.clUser.Text = "User";
            this.clUser.Width = 150;
            // 
            // clDate
            // 
            this.clDate.Text = "Date";
            this.clDate.Width = 80;
            // 
            // clStatus
            // 
            this.clStatus.Text = "Status";
            this.clStatus.Width = 100;
            // 
            // lvUserOverview
            // 
            this.lvUserOverview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.userId,
            this.email,
            this.firstName,
            this.lastName,
            this.ticket});
            this.lvUserOverview.FullRowSelect = true;
            this.lvUserOverview.HideSelection = false;

            this.lvUserOverview.Location = new System.Drawing.Point(116, 153);
            this.lvUserOverview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvUserOverview.MultiSelect = false;
            this.lvUserOverview.Name = "lvUserOverview";
            this.lvUserOverview.Size = new System.Drawing.Size(972, 1043);

            this.lvUserOverview.TabIndex = 2;
            this.lvUserOverview.UseCompatibleStateImageBehavior = false;
            this.lvUserOverview.View = System.Windows.Forms.View.Details;
            // 
            // userId
            // 
            this.userId.Text = "ID";
            this.userId.Width = 50;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 150;
            // 
            // firstName
            // 
            this.firstName.Text = "First Name";
            this.firstName.Width = 100;
            // 
            // lastName
            // 
            this.lastName.Text = "Last Name";
            this.lastName.Width = 100;
            // 
            // ticket
            // 
            this.ticket.Text = "Subject";
            this.ticket.Width = 50;
            // 
            // pnlUserOverview
            // 
            this.pnlUserOverview.Controls.Add(this.btnAddUser);
            this.pnlUserOverview.Controls.Add(this.lvUserOverview);

            this.pnlUserOverview.Location = new System.Drawing.Point(0, 50);
            this.pnlUserOverview.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlUserOverview.Name = "pnlUserOverview";
            this.pnlUserOverview.Size = new System.Drawing.Size(1200, 1339);

            this.pnlUserOverview.TabIndex = 18;
            // 
            // btnAddUser
            // 

            this.btnAddUser.Location = new System.Drawing.Point(920, 89);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(170, 36);

            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Subject";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "User";
            this.columnHeader7.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Date";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Status";
            this.columnHeader9.Width = 100;
            // 
            // lblIncidentMonitor
            // 
            this.lblIncidentMonitor.AutoSize = true;
            this.lblIncidentMonitor.BackColor = System.Drawing.SystemColors.Window;
            this.lblIncidentMonitor.Depth = 0;
            this.lblIncidentMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblIncidentMonitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIncidentMonitor.Location = new System.Drawing.Point(206, 1199);
            this.lblIncidentMonitor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIncidentMonitor.Name = "lblIncidentMonitor";
            this.lblIncidentMonitor.Size = new System.Drawing.Size(373, 36);
            this.lblIncidentMonitor.TabIndex = 9;
            this.lblIncidentMonitor.Text = "the most frequent Incident: ";
            // 
            // chrtUrgentIncident
            // 
            chartArea3.Name = "ChartArea1";
            this.chrtUrgentIncident.ChartAreas.Add(chartArea3);
            this.chrtUrgentIncident.Location = new System.Drawing.Point(664, 358);
            this.chrtUrgentIncident.Name = "chrtUrgentIncident";
            this.chrtUrgentIncident.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            this.chrtUrgentIncident.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Yellow};
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Name = "urgentIncident";
            this.chrtUrgentIncident.Series.Add(series4);
            this.chrtUrgentIncident.Size = new System.Drawing.Size(450, 400);
            this.chrtUrgentIncident.TabIndex = 10;
            this.chrtUrgentIncident.Text = "chart1";
            // 
            // lblNumberOfUrgentTicket
            // 
            this.lblNumberOfUrgentTicket.AutoSize = true;
            this.lblNumberOfUrgentTicket.BackColor = System.Drawing.SystemColors.Window;
            this.lblNumberOfUrgentTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfUrgentTicket.Location = new System.Drawing.Point(849, 527);
            this.lblNumberOfUrgentTicket.Name = "lblNumberOfUrgentTicket";
            this.lblNumberOfUrgentTicket.Size = new System.Drawing.Size(57, 63);
            this.lblNumberOfUrgentTicket.TabIndex = 11;
            this.lblNumberOfUrgentTicket.Text = "..";
            // 
            // Main
            // 

            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1200, 1295);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.pnlCreateTicket);
            this.Controls.Add(this.pnlUserOverview);
            this.Controls.Add(this.pnlTicketOverview);
            this.Controls.Add(this.pnlAddUser);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "No Desk";
            this.pnlCreateTicket.ResumeLayout(false);
            this.pnlCreateTicket.PerformLayout();
            this.pnlAddUser.ResumeLayout(false);
            this.pnlAddUser.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtFrequancyOfIncidents)).EndInit();
            this.pnlTicketOverview.ResumeLayout(false);
            this.pnlTicketOverview.PerformLayout();
            this.pnlUserOverview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrtUrgentIncident)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbIncidentType;
        private System.Windows.Forms.ComboBox cbReportUser;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.ComboBox cbDeadline;
        private System.Windows.Forms.TextBox tbIncidentSubject;
        private System.Windows.Forms.RichTextBox rtbTicketDescription;
        private System.Windows.Forms.Button btnCancelTicket;
        private System.Windows.Forms.Button btnSubmitTicket;
        private System.Windows.Forms.Panel pnlCreateTicket;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTicketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createUserToolStripMenuItem;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.DateTimePicker dtpTicketDate;
        private System.Windows.Forms.Panel pnlAddUser;
        private Label lblUserNameExistence;
        private Label lblUsername;
        private TextBox txtBoxUserName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtBoxEmailAddress;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.TextBox txtBoxPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.ComboBox comboBoxTypeOfUser;
        private System.Windows.Forms.Label lblTypeOfUser;
        private System.Windows.Forms.CheckBox checkBoxSendpassword;
        private System.Windows.Forms.Label lblSendPassword;
        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Panel pnlTicketOverview;
        private System.Windows.Forms.ListView lvTicketOverview;
        private System.Windows.Forms.ColumnHeader clSubject;
        private System.Windows.Forms.ColumnHeader clUser;
        private System.Windows.Forms.ColumnHeader clDate;
        private System.Windows.Forms.ColumnHeader clStatus;
        private System.Windows.Forms.Button btnCloseTicket;
        private System.Windows.Forms.Panel pnlUserOverview;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ListView lvUserOverview;
        private System.Windows.Forms.ColumnHeader userId;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader lastName;
        private System.Windows.Forms.ColumnHeader ticket;
        private System.Windows.Forms.Button btnTicketArchive;
        private System.Windows.Forms.Button btnEscalateTicket;
        private System.Windows.Forms.Button btnTransferTicket;
        private System.Windows.Forms.TextBox txtBox_FilterBy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCreateTicket;
        private System.Windows.Forms.Button btnArchive;
        private System.Windows.Forms.Label lbArchive;
        private System.Windows.Forms.DateTimePicker DTPArichive;
        private ScottPlot.FormsPlot pltIncident;
        private System.Windows.Forms.Label lblOpenTickets;
        private System.Windows.Forms.Label lblUnresolvedIncident;
        private System.Windows.Forms.Label lblCurrentIncident;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblIncidentDeadlineTickets;
        private System.Windows.Forms.Label lblIncidentDeadline;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private MaterialSkin.Controls.MaterialRaisedButton btnShowList;
        private System.Windows.Forms.Label lblCreateTicketError;
        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtFrequancyOfIncidents;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private MaterialSkin.Controls.MaterialLabel lblIncidentMonitor;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtUrgentIncident;
        private System.Windows.Forms.Label lblNumberOfUrgentTicket;

    }
}