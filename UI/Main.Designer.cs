﻿namespace DemoApp
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.lblIncidentMonitor = new System.Windows.Forms.Label();
            this.chrtAcomplishment = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.btnShowList = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblIncidentDeadlineTickets = new System.Windows.Forms.Label();
            this.lblOpenTickets = new System.Windows.Forms.Label();
            this.lblIncidentDeadline = new System.Windows.Forms.Label();
            this.lblUnresolvedIncident = new System.Windows.Forms.Label();
            this.lblCurrentIncident = new System.Windows.Forms.Label();
            this.pltUrgentIncident = new ScottPlot.FormsPlot();
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
            this.pnlCreateTicket.SuspendLayout();
            this.pnlAddUser.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtAcomplishment)).BeginInit();
            this.pnlTicketOverview.SuspendLayout();
            this.pnlUserOverview.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DateTime Reported";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject of incident";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type of Incident";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reported by user";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Priority";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 514);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Deadline/Followup";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 618);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Description";
            // 
            // cbIncidentType
            // 
            this.cbIncidentType.FormattingEnabled = true;
            this.cbIncidentType.Location = new System.Drawing.Point(357, 228);
            this.cbIncidentType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbIncidentType.Name = "cbIncidentType";
            this.cbIncidentType.Size = new System.Drawing.Size(296, 28);
            this.cbIncidentType.TabIndex = 8;
            // 
            // cbReportUser
            // 
            this.cbReportUser.FormattingEnabled = true;
            this.cbReportUser.Location = new System.Drawing.Point(357, 316);
            this.cbReportUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbReportUser.Name = "cbReportUser";
            this.cbReportUser.Size = new System.Drawing.Size(296, 28);
            this.cbReportUser.TabIndex = 9;
            // 
            // cbPriority
            // 
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(357, 406);
            this.cbPriority.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(296, 28);
            this.cbPriority.TabIndex = 10;
            // 
            // cbDeadline
            // 
            this.cbDeadline.FormattingEnabled = true;
            this.cbDeadline.Location = new System.Drawing.Point(357, 504);
            this.cbDeadline.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDeadline.Name = "cbDeadline";
            this.cbDeadline.Size = new System.Drawing.Size(296, 28);
            this.cbDeadline.TabIndex = 11;
            // 
            // tbIncidentSubject
            // 
            this.tbIncidentSubject.Location = new System.Drawing.Point(357, 146);
            this.tbIncidentSubject.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbIncidentSubject.Name = "tbIncidentSubject";
            this.tbIncidentSubject.Size = new System.Drawing.Size(296, 26);
            this.tbIncidentSubject.TabIndex = 12;
            // 
            // rtbTicketDescription
            // 
            this.rtbTicketDescription.Location = new System.Drawing.Point(357, 614);
            this.rtbTicketDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbTicketDescription.Name = "rtbTicketDescription";
            this.rtbTicketDescription.Size = new System.Drawing.Size(296, 224);
            this.rtbTicketDescription.TabIndex = 13;
            this.rtbTicketDescription.Text = "";
            // 
            // btnCancelTicket
            // 
            this.btnCancelTicket.Location = new System.Drawing.Point(357, 924);
            this.btnCancelTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancelTicket.Name = "btnCancelTicket";
            this.btnCancelTicket.Size = new System.Drawing.Size(109, 48);
            this.btnCancelTicket.TabIndex = 14;
            this.btnCancelTicket.Text = "Cancel";
            this.btnCancelTicket.UseVisualStyleBackColor = true;
            this.btnCancelTicket.Click += new System.EventHandler(this.btnCancelTicket_Click);
            // 
            // btnSubmitTicket
            // 
            this.btnSubmitTicket.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSubmitTicket.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmitTicket.Location = new System.Drawing.Point(544, 924);
            this.btnSubmitTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSubmitTicket.Name = "btnSubmitTicket";
            this.btnSubmitTicket.Size = new System.Drawing.Size(109, 48);
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
            this.pnlCreateTicket.Location = new System.Drawing.Point(1, 26);
            this.pnlCreateTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlCreateTicket.Name = "pnlCreateTicket";
            this.pnlCreateTicket.Size = new System.Drawing.Size(894, 1088);
            this.pnlCreateTicket.TabIndex = 16;
            // 
            // lblCreateTicketError
            // 
            this.lblCreateTicketError.AutoSize = true;
            this.lblCreateTicketError.Location = new System.Drawing.Point(357, 1016);
            this.lblCreateTicketError.Name = "lblCreateTicketError";
            this.lblCreateTicketError.Size = new System.Drawing.Size(0, 20);
            this.lblCreateTicketError.TabIndex = 18;
            // 
            // dtpTicketDate
            // 
            this.dtpTicketDate.Location = new System.Drawing.Point(357, 62);
            this.dtpTicketDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpTicketDate.Name = "dtpTicketDate";
            this.dtpTicketDate.Size = new System.Drawing.Size(296, 26);
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
            this.pnlAddUser.Location = new System.Drawing.Point(6, 30);
            this.pnlAddUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlAddUser.Name = "pnlAddUser";
            this.pnlAddUser.Size = new System.Drawing.Size(894, 1088);
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
            this.btnCreateUser.Location = new System.Drawing.Point(561, 655);
            this.btnCreateUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(202, 58);
            this.btnCreateUser.TabIndex = 17;
            this.btnCreateUser.Text = "Create";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(259, 657);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(202, 58);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(19, 14);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(393, 60);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "Create New User";
            // 
            // checkBoxSendpassword
            // 
            this.checkBoxSendpassword.Location = new System.Drawing.Point(214, 519);
            this.checkBoxSendpassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxSendpassword.Name = "checkBoxSendpassword";
            this.checkBoxSendpassword.Size = new System.Drawing.Size(353, 30);
            this.checkBoxSendpassword.TabIndex = 14;
            this.checkBoxSendpassword.Text = "yes, a password email will be sent to user";
            this.checkBoxSendpassword.UseVisualStyleBackColor = true;
            // 
            // lblSendPassword
            // 
            this.lblSendPassword.Location = new System.Drawing.Point(71, 523);
            this.lblSendPassword.Name = "lblSendPassword";
            this.lblSendPassword.Size = new System.Drawing.Size(155, 29);
            this.lblSendPassword.TabIndex = 13;
            this.lblSendPassword.Text = "Send Passsword?";
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Location = new System.Drawing.Point(210, 441);
            this.comboBoxLocation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(492, 28);
            this.comboBoxLocation.TabIndex = 12;
            // 
            // lblLocation
            // 
            this.lblLocation.Location = new System.Drawing.Point(67, 441);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(136, 29);
            this.lblLocation.TabIndex = 11;
            this.lblLocation.Text = "Location/Branch: ";
            // 
            // txtBoxEmailAddress
            // 
            this.txtBoxEmailAddress.Location = new System.Drawing.Point(210, 386);
            this.txtBoxEmailAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxEmailAddress.Name = "txtBoxEmailAddress";
            this.txtBoxEmailAddress.Size = new System.Drawing.Size(492, 26);
            this.txtBoxEmailAddress.TabIndex = 10;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.Location = new System.Drawing.Point(67, 384);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(154, 29);
            this.lblEmailAddress.TabIndex = 9;
            this.lblEmailAddress.Text = "Email address: ";
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(210, 333);
            this.txtBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(492, 26);
            this.txtBoxPhoneNumber.TabIndex = 8;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Location = new System.Drawing.Point(67, 332);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(163, 29);
            this.lblPhoneNumber.TabIndex = 7;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // comboBoxTypeOfUser
            // 
            this.comboBoxTypeOfUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeOfUser.FormattingEnabled = true;
            this.comboBoxTypeOfUser.Location = new System.Drawing.Point(210, 230);
            this.comboBoxTypeOfUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxTypeOfUser.Name = "comboBoxTypeOfUser";
            this.comboBoxTypeOfUser.Size = new System.Drawing.Size(492, 28);
            this.comboBoxTypeOfUser.TabIndex = 6;
            // 
            // lblTypeOfUser
            // 
            this.lblTypeOfUser.Location = new System.Drawing.Point(67, 230);
            this.lblTypeOfUser.Name = "lblTypeOfUser";
            this.lblTypeOfUser.Size = new System.Drawing.Size(112, 29);
            this.lblTypeOfUser.TabIndex = 5;
            this.lblTypeOfUser.Text = "Type of User:  ";
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(210, 179);
            this.txtBoxLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(492, 26);
            this.txtBoxLastName.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(67, 182);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(112, 29);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name: ";
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(210, 132);
            this.txtBoxFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(492, 26);
            this.txtBoxFirstName.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(67, 132);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(112, 29);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(900, 31);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // incidentManagementToolStripMenuItem
            // 
            this.incidentManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTicketToolStripMenuItem});
            this.incidentManagementToolStripMenuItem.Name = "incidentManagementToolStripMenuItem";
            this.incidentManagementToolStripMenuItem.Size = new System.Drawing.Size(201, 29);
            this.incidentManagementToolStripMenuItem.Text = "Incident Management";
            this.incidentManagementToolStripMenuItem.Click += new System.EventHandler(this.incidentManagementToolStripMenuItem_Click);
            // 
            // createTicketToolStripMenuItem
            // 
            this.createTicketToolStripMenuItem.Name = "createTicketToolStripMenuItem";
            this.createTicketToolStripMenuItem.Size = new System.Drawing.Size(214, 34);
            this.createTicketToolStripMenuItem.Text = "Create Ticket";
            this.createTicketToolStripMenuItem.Click += new System.EventHandler(this.createTicketToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createUserToolStripMenuItem});
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(173, 29);
            this.userManagementToolStripMenuItem.Text = "User Management";
            this.userManagementToolStripMenuItem.Click += new System.EventHandler(this.userManagementToolStripMenuItem_Click);
            // 
            // createUserToolStripMenuItem
            // 
            this.createUserToolStripMenuItem.Name = "createUserToolStripMenuItem";
            this.createUserToolStripMenuItem.Size = new System.Drawing.Size(204, 34);
            this.createUserToolStripMenuItem.Text = "Create User";
            this.createUserToolStripMenuItem.Click += new System.EventHandler(this.createUserToolStripMenuItem_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.lblIncidentMonitor);
            this.pnlDashboard.Controls.Add(this.chrtAcomplishment);
            this.pnlDashboard.Controls.Add(this.richTextBox3);
            this.pnlDashboard.Controls.Add(this.formsPlot1);
            this.pnlDashboard.Controls.Add(this.btnShowList);
            this.pnlDashboard.Controls.Add(this.lblIncidentDeadlineTickets);
            this.pnlDashboard.Controls.Add(this.lblOpenTickets);
            this.pnlDashboard.Controls.Add(this.lblIncidentDeadline);
            this.pnlDashboard.Controls.Add(this.lblUnresolvedIncident);
            this.pnlDashboard.Controls.Add(this.lblCurrentIncident);
            this.pnlDashboard.Controls.Add(this.pltUrgentIncident);
            this.pnlDashboard.Controls.Add(this.pltIncident);
            this.pnlDashboard.Controls.Add(this.richTextBox2);
            this.pnlDashboard.Controls.Add(this.richTextBox1);
            this.pnlDashboard.Location = new System.Drawing.Point(1, 34);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(893, 1040);
            this.pnlDashboard.TabIndex = 18;
            // 
            // lblIncidentMonitor
            // 
            this.lblIncidentMonitor.BackColor = System.Drawing.SystemColors.Window;
            this.lblIncidentMonitor.Location = new System.Drawing.Point(141, 970);
            this.lblIncidentMonitor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIncidentMonitor.Name = "lblIncidentMonitor";
            this.lblIncidentMonitor.Size = new System.Drawing.Size(543, 19);
            this.lblIncidentMonitor.TabIndex = 8;
            this.lblIncidentMonitor.Text = "the most frequent Incident: ";
            // 
            // chrtAcomplishment
            // 
            chartArea2.Name = "ChartArea1";
            this.chrtAcomplishment.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrtAcomplishment.Legends.Add(legend2);
            this.chrtAcomplishment.Location = new System.Drawing.Point(79, 672);
            this.chrtAcomplishment.Margin = new System.Windows.Forms.Padding(2);
            this.chrtAcomplishment.Name = "chrtAcomplishment";
            this.chrtAcomplishment.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Number of Incident resolved";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.MarkerSize = 2;
            series5.Name = "Subject1";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.MarkerSize = 2;
            series6.Name = "Subject2";
            this.chrtAcomplishment.Series.Add(series4);
            this.chrtAcomplishment.Series.Add(series5);
            this.chrtAcomplishment.Series.Add(series6);
            this.chrtAcomplishment.Size = new System.Drawing.Size(746, 284);
            this.chrtAcomplishment.TabIndex = 7;
            this.chrtAcomplishment.Text = "chrt";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(36, 651);
            this.richTextBox3.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(828, 362);
            this.richTextBox3.TabIndex = 6;
            this.richTextBox3.Text = "";
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(778, 290);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(6, 6);
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
            this.btnShowList.Location = new System.Drawing.Point(728, 66);
            this.btnShowList.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowList.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Primary = true;
            this.btnShowList.Size = new System.Drawing.Size(130, 36);
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
            this.lblIncidentDeadlineTickets.Location = new System.Drawing.Point(484, 228);
            this.lblIncidentDeadlineTickets.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIncidentDeadlineTickets.Name = "lblIncidentDeadlineTickets";
            this.lblIncidentDeadlineTickets.Size = new System.Drawing.Size(362, 22);
            this.lblIncidentDeadlineTickets.TabIndex = 1;
            this.lblIncidentDeadlineTickets.Text = "These tickets need your immediate attention";
            // 
            // lblOpenTickets
            // 
            this.lblOpenTickets.AutoSize = true;
            this.lblOpenTickets.BackColor = System.Drawing.SystemColors.Window;
            this.lblOpenTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenTickets.Location = new System.Drawing.Point(136, 228);
            this.lblOpenTickets.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpenTickets.Name = "lblOpenTickets";
            this.lblOpenTickets.Size = new System.Drawing.Size(205, 22);
            this.lblOpenTickets.TabIndex = 1;
            this.lblOpenTickets.Text = "All tickets currently open";
            // 
            // lblIncidentDeadline
            // 
            this.lblIncidentDeadline.AutoSize = true;
            this.lblIncidentDeadline.BackColor = System.Drawing.SystemColors.Window;
            this.lblIncidentDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncidentDeadline.Location = new System.Drawing.Point(543, 188);
            this.lblIncidentDeadline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIncidentDeadline.Name = "lblIncidentDeadline";
            this.lblIncidentDeadline.Size = new System.Drawing.Size(260, 29);
            this.lblIncidentDeadline.TabIndex = 1;
            this.lblIncidentDeadline.Text = "Incidents past deadline";
            // 
            // lblUnresolvedIncident
            // 
            this.lblUnresolvedIncident.AutoSize = true;
            this.lblUnresolvedIncident.BackColor = System.Drawing.SystemColors.Window;
            this.lblUnresolvedIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnresolvedIncident.Location = new System.Drawing.Point(120, 188);
            this.lblUnresolvedIncident.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnresolvedIncident.Name = "lblUnresolvedIncident";
            this.lblUnresolvedIncident.Size = new System.Drawing.Size(238, 29);
            this.lblUnresolvedIncident.TabIndex = 1;
            this.lblUnresolvedIncident.Text = "Unresolved incidents";
            // 
            // lblCurrentIncident
            // 
            this.lblCurrentIncident.AutoSize = true;
            this.lblCurrentIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentIncident.Location = new System.Drawing.Point(45, 48);
            this.lblCurrentIncident.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentIncident.Name = "lblCurrentIncident";
            this.lblCurrentIncident.Size = new System.Drawing.Size(321, 46);
            this.lblCurrentIncident.TabIndex = 1;
            this.lblCurrentIncident.Text = "Current incidents";
            // 
            // pltUrgentIncident
            // 
            this.pltUrgentIncident.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pltUrgentIncident.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pltUrgentIncident.BackColor = System.Drawing.SystemColors.Window;
            this.pltUrgentIncident.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pltUrgentIncident.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pltUrgentIncident.Location = new System.Drawing.Point(487, 268);
            this.pltUrgentIncident.Margin = new System.Windows.Forms.Padding(22, 24, 22, 24);
            this.pltUrgentIncident.Name = "pltUrgentIncident";
            this.pltUrgentIncident.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pltUrgentIncident.Size = new System.Drawing.Size(338, 360);
            this.pltUrgentIncident.TabIndex = 0;
            // 
            // pltIncident
            // 
            this.pltIncident.BackColor = System.Drawing.SystemColors.Window;
            this.pltIncident.Location = new System.Drawing.Point(72, 268);
            this.pltIncident.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pltIncident.Name = "pltIncident";
            this.pltIncident.Size = new System.Drawing.Size(338, 360);
            this.pltIncident.TabIndex = 0;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(458, 150);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(406, 480);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(36, 150);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(406, 480);
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
            this.pnlTicketOverview.Location = new System.Drawing.Point(0, 40);
            this.pnlTicketOverview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTicketOverview.Name = "pnlTicketOverview";
            this.pnlTicketOverview.Size = new System.Drawing.Size(900, 1071);
            this.pnlTicketOverview.TabIndex = 18;
            // 
            // btnArchive
            // 
            this.btnArchive.Location = new System.Drawing.Point(88, 781);
            this.btnArchive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(127, 29);
            this.btnArchive.TabIndex = 25;
            this.btnArchive.Text = "Archive Tickets";
            this.btnArchive.UseVisualStyleBackColor = true;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // lbArchive
            // 
            this.lbArchive.AutoSize = true;
            this.lbArchive.Location = new System.Drawing.Point(224, 785);
            this.lbArchive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbArchive.Name = "lbArchive";
            this.lbArchive.Size = new System.Drawing.Size(131, 20);
            this.lbArchive.TabIndex = 24;
            this.lbArchive.Text = "that made before";
            // 
            // DTPArichive
            // 
            this.DTPArichive.Location = new System.Drawing.Point(366, 784);
            this.DTPArichive.Margin = new System.Windows.Forms.Padding(2);
            this.DTPArichive.Name = "DTPArichive";
            this.DTPArichive.Size = new System.Drawing.Size(301, 26);
            this.DTPArichive.TabIndex = 23;
            // 
            // btnTransferTicket
            // 
            this.btnTransferTicket.Location = new System.Drawing.Point(690, 26);
            this.btnTransferTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btnTransferTicket.Name = "btnTransferTicket";
            this.btnTransferTicket.Size = new System.Drawing.Size(127, 29);
            this.btnTransferTicket.TabIndex = 20;
            this.btnTransferTicket.Text = "Transfer Ticket ";
            this.btnTransferTicket.UseVisualStyleBackColor = true;
            this.btnTransferTicket.Click += new System.EventHandler(this.btnTransferTicket_Click);
            // 
            // txtBox_FilterBy
            // 
            this.txtBox_FilterBy.ForeColor = System.Drawing.Color.Gray;
            this.txtBox_FilterBy.Location = new System.Drawing.Point(87, 75);
            this.txtBox_FilterBy.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_FilterBy.Name = "txtBox_FilterBy";
            this.txtBox_FilterBy.Size = new System.Drawing.Size(268, 26);
            this.txtBox_FilterBy.TabIndex = 22;
            this.txtBox_FilterBy.Text = "Filter by subject...";
            this.txtBox_FilterBy.Click += new System.EventHandler(this.txtBox_FilterBy_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(82, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 29);
            this.label8.TabIndex = 21;
            this.label8.Text = "Ticket Overview";
            // 
            // btnCreateTicket
            // 
            this.btnCreateTicket.Location = new System.Drawing.Point(546, 26);
            this.btnCreateTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateTicket.Name = "btnCreateTicket";
            this.btnCreateTicket.Size = new System.Drawing.Size(127, 29);
            this.btnCreateTicket.TabIndex = 20;
            this.btnCreateTicket.Text = "Create Ticket";
            this.btnCreateTicket.UseVisualStyleBackColor = true;
            this.btnCreateTicket.Click += new System.EventHandler(this.btnCreateTicket_Click);
            // 
            // btnEscalateTicket
            // 
            this.btnEscalateTicket.Location = new System.Drawing.Point(546, 71);
            this.btnEscalateTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEscalateTicket.Name = "btnEscalateTicket";
            this.btnEscalateTicket.Size = new System.Drawing.Size(127, 29);
            this.btnEscalateTicket.TabIndex = 19;
            this.btnEscalateTicket.Text = "Escalate Ticket";
            this.btnEscalateTicket.UseVisualStyleBackColor = true;
            this.btnEscalateTicket.Click += new System.EventHandler(this.btnEscalateTicket_Click);
            // 
            // btnCloseTicket
            // 
            this.btnCloseTicket.Location = new System.Drawing.Point(690, 71);
            this.btnCloseTicket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCloseTicket.Name = "btnCloseTicket";
            this.btnCloseTicket.Size = new System.Drawing.Size(127, 29);
            this.btnCloseTicket.TabIndex = 1;
            this.btnCloseTicket.Text = "Close Ticket";
            this.btnCloseTicket.UseVisualStyleBackColor = true;
            this.btnCloseTicket.Click += new System.EventHandler(this.btnCloseTicket_Click);
            // 
            // btnTicketArchive
            // 
            this.btnTicketArchive.Enabled = false;
            this.btnTicketArchive.Location = new System.Drawing.Point(546, 71);
            this.btnTicketArchive.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTicketArchive.Name = "btnTicketArchive";
            this.btnTicketArchive.Size = new System.Drawing.Size(127, 29);
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
            this.lvTicketOverview.Location = new System.Drawing.Point(87, 122);
            this.lvTicketOverview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvTicketOverview.MultiSelect = false;
            this.lvTicketOverview.Name = "lvTicketOverview";
            this.lvTicketOverview.Size = new System.Drawing.Size(730, 640);
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
            this.lvUserOverview.Location = new System.Drawing.Point(87, 122);
            this.lvUserOverview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvUserOverview.MultiSelect = false;
            this.lvUserOverview.Name = "lvUserOverview";
            this.lvUserOverview.Size = new System.Drawing.Size(730, 835);
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
            this.pnlUserOverview.Location = new System.Drawing.Point(0, 40);
            this.pnlUserOverview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlUserOverview.Name = "pnlUserOverview";
            this.pnlUserOverview.Size = new System.Drawing.Size(900, 1071);
            this.pnlUserOverview.TabIndex = 18;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(690, 71);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(127, 29);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(900, 844);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlAddUser);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.pnlCreateTicket);
            this.Controls.Add(this.pnlUserOverview);
            this.Controls.Add(this.pnlTicketOverview);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            ((System.ComponentModel.ISupportInitialize)(this.chrtAcomplishment)).EndInit();
            this.pnlTicketOverview.ResumeLayout(false);
            this.pnlTicketOverview.PerformLayout();
            this.pnlUserOverview.ResumeLayout(false);
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
        private ScottPlot.FormsPlot pltUrgentIncident;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private MaterialSkin.Controls.MaterialRaisedButton btnShowList;
        private System.Windows.Forms.Label lblCreateTicketError;
        private ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.Label lblIncidentMonitor;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtAcomplishment;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtBoxUserName;
        private System.Windows.Forms.Label lblUserNameExistence;
    }
}