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
            this.dtpTicketDate = new System.Windows.Forms.DateTimePicker();
            this.pnlAddUser = new System.Windows.Forms.Panel();
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
            this.pnlTicketOverview = new System.Windows.Forms.Panel();
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
            this.btnEscalateTicket = new System.Windows.Forms.Button();
            this.pnlCreateTicket.SuspendLayout();
            this.pnlAddUser.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlTicketOverview.SuspendLayout();
            this.pnlUserOverview.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "DateTime Reported";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject of incident";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type of Incident";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reported by user";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Priority";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Deadline/Followup";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(81, 494);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Description";
            // 
            // cbIncidentType
            // 
            this.cbIncidentType.FormattingEnabled = true;
            this.cbIncidentType.Location = new System.Drawing.Point(317, 182);
            this.cbIncidentType.Name = "cbIncidentType";
            this.cbIncidentType.Size = new System.Drawing.Size(264, 24);
            this.cbIncidentType.TabIndex = 8;
            // 
            // cbReportUser
            // 
            this.cbReportUser.FormattingEnabled = true;
            this.cbReportUser.Location = new System.Drawing.Point(317, 253);
            this.cbReportUser.Name = "cbReportUser";
            this.cbReportUser.Size = new System.Drawing.Size(264, 24);
            this.cbReportUser.TabIndex = 9;
            // 
            // cbPriority
            // 
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(317, 325);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(264, 24);
            this.cbPriority.TabIndex = 10;
            // 
            // cbDeadline
            // 
            this.cbDeadline.FormattingEnabled = true;
            this.cbDeadline.Location = new System.Drawing.Point(317, 403);
            this.cbDeadline.Name = "cbDeadline";
            this.cbDeadline.Size = new System.Drawing.Size(264, 24);
            this.cbDeadline.TabIndex = 11;
            // 
            // tbIncidentSubject
            // 
            this.tbIncidentSubject.Location = new System.Drawing.Point(317, 117);
            this.tbIncidentSubject.Name = "tbIncidentSubject";
            this.tbIncidentSubject.Size = new System.Drawing.Size(264, 22);
            this.tbIncidentSubject.TabIndex = 12;
            // 
            // rtbTicketDescription
            // 
            this.rtbTicketDescription.Location = new System.Drawing.Point(317, 491);
            this.rtbTicketDescription.Name = "rtbTicketDescription";
            this.rtbTicketDescription.Size = new System.Drawing.Size(264, 180);
            this.rtbTicketDescription.TabIndex = 13;
            this.rtbTicketDescription.Text = "";
            // 
            // btnCancelTicket
            // 
            this.btnCancelTicket.Location = new System.Drawing.Point(317, 739);
            this.btnCancelTicket.Name = "btnCancelTicket";
            this.btnCancelTicket.Size = new System.Drawing.Size(97, 38);
            this.btnCancelTicket.TabIndex = 14;
            this.btnCancelTicket.Text = "Cancel";
            this.btnCancelTicket.UseVisualStyleBackColor = true;
            this.btnCancelTicket.Click += new System.EventHandler(this.btnCancelTicket_Click);
            // 
            // btnSubmitTicket
            // 
            this.btnSubmitTicket.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnSubmitTicket.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmitTicket.Location = new System.Drawing.Point(484, 739);
            this.btnSubmitTicket.Name = "btnSubmitTicket";
            this.btnSubmitTicket.Size = new System.Drawing.Size(97, 38);
            this.btnSubmitTicket.TabIndex = 15;
            this.btnSubmitTicket.Text = "Submit Ticket";
            this.btnSubmitTicket.UseVisualStyleBackColor = false;
            this.btnSubmitTicket.Click += new System.EventHandler(this.btnSubmitTicket_Click);
            // 
            // pnlCreateTicket
            // 
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
            this.pnlCreateTicket.Location = new System.Drawing.Point(1, 21);
            this.pnlCreateTicket.Name = "pnlCreateTicket";
            this.pnlCreateTicket.Size = new System.Drawing.Size(795, 870);
            this.pnlCreateTicket.TabIndex = 16;
            // 
            // dtpTicketDate
            // 
            this.dtpTicketDate.Location = new System.Drawing.Point(317, 50);
            this.dtpTicketDate.Name = "dtpTicketDate";
            this.dtpTicketDate.Size = new System.Drawing.Size(264, 22);
            this.dtpTicketDate.TabIndex = 17;
            // 
            // pnlAddUser
            // 
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
            this.pnlAddUser.Location = new System.Drawing.Point(5, 24);
            this.pnlAddUser.Name = "pnlAddUser";
            this.pnlAddUser.Size = new System.Drawing.Size(795, 870);
            this.pnlAddUser.TabIndex = 18;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(480, 527);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(180, 46);
            this.btnCreateUser.TabIndex = 17;
            this.btnCreateUser.Text = "Create";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(230, 527);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 46);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(17, 11);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(349, 48);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "Create New User";
            // 
            // checkBoxSendpassword
            // 
            this.checkBoxSendpassword.Location = new System.Drawing.Point(207, 439);
            this.checkBoxSendpassword.Name = "checkBoxSendpassword";
            this.checkBoxSendpassword.Size = new System.Drawing.Size(314, 24);
            this.checkBoxSendpassword.TabIndex = 14;
            this.checkBoxSendpassword.Text = "yes, a password email will be sent to user";
            this.checkBoxSendpassword.UseVisualStyleBackColor = true;
            // 
            // lblSendPassword
            // 
            this.lblSendPassword.Location = new System.Drawing.Point(63, 440);
            this.lblSendPassword.Name = "lblSendPassword";
            this.lblSendPassword.Size = new System.Drawing.Size(138, 23);
            this.lblSendPassword.TabIndex = 13;
            this.lblSendPassword.Text = "Send Passsword?";
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Location = new System.Drawing.Point(185, 388);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(438, 24);
            this.comboBoxLocation.TabIndex = 12;
            // 
            // lblLocation
            // 
            this.lblLocation.Location = new System.Drawing.Point(63, 391);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(121, 23);
            this.lblLocation.TabIndex = 11;
            this.lblLocation.Text = "Location/Branch: ";
            // 
            // txtBoxEmailAddress
            // 
            this.txtBoxEmailAddress.Location = new System.Drawing.Point(185, 341);
            this.txtBoxEmailAddress.Name = "txtBoxEmailAddress";
            this.txtBoxEmailAddress.Size = new System.Drawing.Size(438, 22);
            this.txtBoxEmailAddress.TabIndex = 10;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.Location = new System.Drawing.Point(69, 340);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(137, 23);
            this.lblEmailAddress.TabIndex = 9;
            this.lblEmailAddress.Text = "Email address: ";
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(185, 288);
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(438, 22);
            this.txtBoxPhoneNumber.TabIndex = 8;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Location = new System.Drawing.Point(69, 287);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(145, 23);
            this.lblPhoneNumber.TabIndex = 7;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // comboBoxTypeOfUser
            // 
            this.comboBoxTypeOfUser.FormattingEnabled = true;
            this.comboBoxTypeOfUser.Location = new System.Drawing.Point(185, 216);
            this.comboBoxTypeOfUser.Name = "comboBoxTypeOfUser";
            this.comboBoxTypeOfUser.Size = new System.Drawing.Size(438, 24);
            this.comboBoxTypeOfUser.TabIndex = 6;
            // 
            // lblTypeOfUser
            // 
            this.lblTypeOfUser.Location = new System.Drawing.Point(69, 217);
            this.lblTypeOfUser.Name = "lblTypeOfUser";
            this.lblTypeOfUser.Size = new System.Drawing.Size(100, 23);
            this.lblTypeOfUser.TabIndex = 5;
            this.lblTypeOfUser.Text = "Type of User:  ";
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(185, 160);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(438, 22);
            this.txtBoxLastName.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(69, 159);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 23);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name: ";
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(185, 107);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(438, 22);
            this.txtBoxFirstName.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(69, 106);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(100, 23);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.incidentManagementToolStripMenuItem,
            this.userManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(96, 28);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // incidentManagementToolStripMenuItem
            // 
            this.incidentManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTicketToolStripMenuItem});
            this.incidentManagementToolStripMenuItem.Name = "incidentManagementToolStripMenuItem";
            this.incidentManagementToolStripMenuItem.Size = new System.Drawing.Size(168, 28);
            this.incidentManagementToolStripMenuItem.Text = "Incident Management";
            this.incidentManagementToolStripMenuItem.Click += new System.EventHandler(this.incidentManagementToolStripMenuItem_Click);
            // 
            // createTicketToolStripMenuItem
            // 
            this.createTicketToolStripMenuItem.Name = "createTicketToolStripMenuItem";
            this.createTicketToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.createTicketToolStripMenuItem.Text = "Create Ticket";
            this.createTicketToolStripMenuItem.Click += new System.EventHandler(this.createTicketToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createUserToolStripMenuItem});
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(144, 28);
            this.userManagementToolStripMenuItem.Text = "User Management";
            this.userManagementToolStripMenuItem.Click += new System.EventHandler(this.userManagementToolStripMenuItem_Click);
            // 
            // createUserToolStripMenuItem
            // 
            this.createUserToolStripMenuItem.Name = "createUserToolStripMenuItem";
            this.createUserToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.createUserToolStripMenuItem.Text = "Create User";
            this.createUserToolStripMenuItem.Click += new System.EventHandler(this.createUserToolStripMenuItem_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Location = new System.Drawing.Point(1, 27);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(794, 639);
            this.pnlDashboard.TabIndex = 18;
            // 
            // pnlTicketOverview
            // 
            this.pnlTicketOverview.Controls.Add(this.btnEscalateTicket);
            this.pnlTicketOverview.Controls.Add(this.btnCloseTicket);
            this.pnlTicketOverview.Controls.Add(this.btnTicketArchive);
            this.pnlTicketOverview.Controls.Add(this.lvTicketOverview);
            this.pnlTicketOverview.Location = new System.Drawing.Point(0, 32);
            this.pnlTicketOverview.Name = "pnlTicketOverview";
            this.pnlTicketOverview.Size = new System.Drawing.Size(800, 857);
            this.pnlTicketOverview.TabIndex = 18;
            // 
            // btnCloseTicket
            // 
            this.btnCloseTicket.Enabled = false;
            this.btnCloseTicket.Location = new System.Drawing.Point(613, 57);
            this.btnCloseTicket.Name = "btnCloseTicket";
            this.btnCloseTicket.Size = new System.Drawing.Size(113, 23);
            this.btnCloseTicket.TabIndex = 1;
            this.btnCloseTicket.Text = "Close Ticket";
            this.btnCloseTicket.UseVisualStyleBackColor = true;
            this.btnCloseTicket.Click += new System.EventHandler(this.btnCloseTicket_Click);
            // 
            // btnTicketArchive
            // 
            this.btnTicketArchive.Enabled = false;

            this.btnTicketArchive.Location = new System.Drawing.Point(366, 57);

            this.btnTicketArchive.Location = new System.Drawing.Point(485, 57);

            this.btnTicketArchive.Name = "btnTicketArchive";
            this.btnTicketArchive.Size = new System.Drawing.Size(113, 23);
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
            this.lvTicketOverview.Location = new System.Drawing.Point(77, 98);
            this.lvTicketOverview.MultiSelect = false;
            this.lvTicketOverview.Name = "lvTicketOverview";
            this.lvTicketOverview.Size = new System.Drawing.Size(649, 669);
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
            this.lvUserOverview.Location = new System.Drawing.Point(77, 98);
            this.lvUserOverview.MultiSelect = false;
            this.lvUserOverview.Name = "lvUserOverview";
            this.lvUserOverview.Size = new System.Drawing.Size(649, 669);
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
            this.ticket.Text = "# ticket";
            this.ticket.Width = 50;
            // 
            // pnlUserOverview
            // 
            this.pnlUserOverview.Controls.Add(this.btnAddUser);
            this.pnlUserOverview.Controls.Add(this.lvUserOverview);
            this.pnlUserOverview.Location = new System.Drawing.Point(0, 32);
            this.pnlUserOverview.Name = "pnlUserOverview";
            this.pnlUserOverview.Size = new System.Drawing.Size(800, 857);
            this.pnlUserOverview.TabIndex = 18;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Enabled = false;
            this.btnAddUser.Location = new System.Drawing.Point(613, 57);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(113, 23);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
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
            // btnEscalateTicket
            // 
            this.btnEscalateTicket.Enabled = false;
            this.btnEscalateTicket.Location = new System.Drawing.Point(485, 57);
            this.btnEscalateTicket.Name = "btnEscalateTicket";
            this.btnEscalateTicket.Size = new System.Drawing.Size(113, 23);
            this.btnEscalateTicket.TabIndex = 19;
            this.btnEscalateTicket.Text = "Escalate Ticket";
            this.btnEscalateTicket.UseVisualStyleBackColor = true;
            this.btnEscalateTicket.Click += new System.EventHandler(this.btnEscalateTicket_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 675);
            this.Controls.Add(this.menuStrip1);

            this.Controls.Add(this.pnlTicketOverview);

            this.Controls.Add(this.pnlAddUser);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.pnlCreateTicket);
            this.Controls.Add(this.pnlUserOverview);

            this.Controls.Add(this.pnlTicketOverview);

            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "No Desk";
            this.pnlCreateTicket.ResumeLayout(false);
            this.pnlCreateTicket.PerformLayout();
            this.pnlAddUser.ResumeLayout(false);
            this.pnlAddUser.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlTicketOverview.ResumeLayout(false);
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
    }
}