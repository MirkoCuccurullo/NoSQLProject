﻿using System.Windows.Forms;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.pnlCreateTicket = new System.Windows.Forms.Panel();
            this.btnCancelTicket = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSubmitTicket = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblCreateTicketError = new System.Windows.Forms.Label();
            this.dtpTicketDate = new System.Windows.Forms.DateTimePicker();
            this.pnlAddUser = new System.Windows.Forms.Panel();
            this.lblCreatingUserErrorMessage = new System.Windows.Forms.Label();
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
            this.lblNumberOfUnresolvedTicket = new System.Windows.Forms.Label();
            this.chrtUnresolvedIncident = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblNumberOfUrgentTicket = new System.Windows.Forms.Label();
            this.chrtUrgentIncident = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblIncidentMonitor = new MaterialSkin.Controls.MaterialLabel();
            this.chrtFrequancyOfIncidents = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.btnShowList = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblIncidentDeadlineTickets = new System.Windows.Forms.Label();
            this.lblOpenTickets = new System.Windows.Forms.Label();
            this.lblIncidentDeadline = new System.Windows.Forms.Label();
            this.lblUnresolvedIncident = new System.Windows.Forms.Label();
            this.lblCurrentIncident = new System.Windows.Forms.Label();
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
            this.lblUserOverview = new System.Windows.Forms.Label();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlCreateTicket.SuspendLayout();
            this.pnlAddUser.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrtUnresolvedIncident)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtUrgentIncident)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtFrequancyOfIncidents)).BeginInit();
            this.pnlTicketOverview.SuspendLayout();
            this.pnlUserOverview.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DateTime Reported";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject of incident";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type of Incident";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 212);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Reported by user";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 280);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Priority";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 334);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Deadline/Followup";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 401);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Description";
            // 
            // cbIncidentType
            // 
            this.cbIncidentType.FormattingEnabled = true;
            this.cbIncidentType.Location = new System.Drawing.Point(238, 148);
            this.cbIncidentType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbIncidentType.Name = "cbIncidentType";
            this.cbIncidentType.Size = new System.Drawing.Size(199, 21);
            this.cbIncidentType.TabIndex = 8;
            // 
            // cbReportUser
            // 
            this.cbReportUser.FormattingEnabled = true;
            this.cbReportUser.Location = new System.Drawing.Point(238, 205);
            this.cbReportUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbReportUser.Name = "cbReportUser";
            this.cbReportUser.Size = new System.Drawing.Size(199, 21);
            this.cbReportUser.TabIndex = 9;
            // 
            // cbPriority
            // 
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Location = new System.Drawing.Point(238, 264);
            this.cbPriority.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(199, 21);
            this.cbPriority.TabIndex = 10;
            // 
            // cbDeadline
            // 
            this.cbDeadline.FormattingEnabled = true;
            this.cbDeadline.Location = new System.Drawing.Point(238, 328);
            this.cbDeadline.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cbDeadline.Name = "cbDeadline";
            this.cbDeadline.Size = new System.Drawing.Size(199, 21);
            this.cbDeadline.TabIndex = 11;
            // 
            // tbIncidentSubject
            // 
            this.tbIncidentSubject.Location = new System.Drawing.Point(238, 95);
            this.tbIncidentSubject.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbIncidentSubject.Name = "tbIncidentSubject";
            this.tbIncidentSubject.Size = new System.Drawing.Size(199, 20);
            this.tbIncidentSubject.TabIndex = 12;
            // 
            // rtbTicketDescription
            // 
            this.rtbTicketDescription.Location = new System.Drawing.Point(238, 399);
            this.rtbTicketDescription.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.rtbTicketDescription.Name = "rtbTicketDescription";
            this.rtbTicketDescription.Size = new System.Drawing.Size(199, 147);
            this.rtbTicketDescription.TabIndex = 13;
            this.rtbTicketDescription.Text = "";
            // 
            // pnlCreateTicket
            // 
            this.pnlCreateTicket.Controls.Add(this.btnCancelTicket);
            this.pnlCreateTicket.Controls.Add(this.btnSubmitTicket);
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
            this.pnlCreateTicket.Location = new System.Drawing.Point(1, 17);
            this.pnlCreateTicket.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlCreateTicket.Name = "pnlCreateTicket";
            this.pnlCreateTicket.Size = new System.Drawing.Size(596, 707);
            this.pnlCreateTicket.TabIndex = 16;
            // 
            // btnCancelTicket
            // 
            this.btnCancelTicket.AutoSize = true;
            this.btnCancelTicket.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelTicket.Depth = 0;
            this.btnCancelTicket.Icon = null;
            this.btnCancelTicket.Location = new System.Drawing.Point(238, 597);
            this.btnCancelTicket.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelTicket.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelTicket.Name = "btnCancelTicket";
            this.btnCancelTicket.Primary = false;
            this.btnCancelTicket.Size = new System.Drawing.Size(73, 36);
            this.btnCancelTicket.TabIndex = 20;
            this.btnCancelTicket.Text = "Cancel";
            this.btnCancelTicket.UseVisualStyleBackColor = true;
            this.btnCancelTicket.Click += new System.EventHandler(this.btnCancelTicket_Click);
            // 
            // btnSubmitTicket
            // 
            this.btnSubmitTicket.AutoSize = true;
            this.btnSubmitTicket.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSubmitTicket.Depth = 0;
            this.btnSubmitTicket.Icon = null;
            this.btnSubmitTicket.Location = new System.Drawing.Point(366, 597);
            this.btnSubmitTicket.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubmitTicket.Name = "btnSubmitTicket";
            this.btnSubmitTicket.Primary = true;
            this.btnSubmitTicket.Size = new System.Drawing.Size(71, 36);
            this.btnSubmitTicket.TabIndex = 19;
            this.btnSubmitTicket.Text = "Submit";
            this.btnSubmitTicket.UseVisualStyleBackColor = true;
            this.btnSubmitTicket.Click += new System.EventHandler(this.btnSubmitTicket_Click_1);
            // 
            // lblCreateTicketError
            // 
            this.lblCreateTicketError.AutoSize = true;
            this.lblCreateTicketError.Location = new System.Drawing.Point(238, 660);
            this.lblCreateTicketError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreateTicketError.Name = "lblCreateTicketError";
            this.lblCreateTicketError.Size = new System.Drawing.Size(0, 13);
            this.lblCreateTicketError.TabIndex = 18;
            // 
            // dtpTicketDate
            // 
            this.dtpTicketDate.Location = new System.Drawing.Point(238, 41);
            this.dtpTicketDate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dtpTicketDate.Name = "dtpTicketDate";
            this.dtpTicketDate.Size = new System.Drawing.Size(199, 20);
            this.dtpTicketDate.TabIndex = 17;
            // 
            // pnlAddUser
            // 
            this.pnlAddUser.Controls.Add(this.lblCreatingUserErrorMessage);
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
            this.pnlAddUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlAddUser.Location = new System.Drawing.Point(4, 20);
            this.pnlAddUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlAddUser.Name = "pnlAddUser";
            this.pnlAddUser.Size = new System.Drawing.Size(596, 707);
            this.pnlAddUser.TabIndex = 18;
            // 
            // lblCreatingUserErrorMessage
            // 
            this.lblCreatingUserErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblCreatingUserErrorMessage.Location = new System.Drawing.Point(68, 520);
            this.lblCreatingUserErrorMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreatingUserErrorMessage.Name = "lblCreatingUserErrorMessage";
            this.lblCreatingUserErrorMessage.Size = new System.Drawing.Size(376, 19);
            this.lblCreatingUserErrorMessage.TabIndex = 21;
            // 
            // lblUserNameExistence
            // 
            this.lblUserNameExistence.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameExistence.Location = new System.Drawing.Point(145, 176);
            this.lblUserNameExistence.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserNameExistence.Name = "lblUserNameExistence";
            this.lblUserNameExistence.Size = new System.Drawing.Size(326, 17);
            this.lblUserNameExistence.TabIndex = 20;
            // 
            // lblUsername
            // 
            this.lblUsername.Location = new System.Drawing.Point(52, 195);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(69, 23);
            this.lblUsername.TabIndex = 19;
            this.lblUsername.Text = "User Name";
            // 
            // txtBoxUserName
            // 
            this.txtBoxUserName.Location = new System.Drawing.Point(142, 195);
            this.txtBoxUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxUserName.Name = "txtBoxUserName";
            this.txtBoxUserName.Size = new System.Drawing.Size(330, 20);
            this.txtBoxUserName.TabIndex = 18;
            this.txtBoxUserName.TextChanged += new System.EventHandler(this.txtBoxUserName_TextChanged);
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCreateUser.Location = new System.Drawing.Point(306, 545);
            this.btnCreateUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(135, 37);
            this.btnCreateUser.TabIndex = 17;
            this.btnCreateUser.Text = "Create";
            this.btnCreateUser.UseVisualStyleBackColor = false;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(91, 545);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 37);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(13, 9);
            this.lblDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(262, 39);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "Create New User";
            // 
            // checkBoxSendpassword
            // 
            this.checkBoxSendpassword.Location = new System.Drawing.Point(142, 467);
            this.checkBoxSendpassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkBoxSendpassword.Name = "checkBoxSendpassword";
            this.checkBoxSendpassword.Size = new System.Drawing.Size(236, 20);
            this.checkBoxSendpassword.TabIndex = 14;
            this.checkBoxSendpassword.Text = "yes, a password email will be sent to user";
            this.checkBoxSendpassword.UseVisualStyleBackColor = true;
            // 
            // lblSendPassword
            // 
            this.lblSendPassword.Location = new System.Drawing.Point(52, 467);
            this.lblSendPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSendPassword.Name = "lblSendPassword";
            this.lblSendPassword.Size = new System.Drawing.Size(104, 19);
            this.lblSendPassword.TabIndex = 13;
            this.lblSendPassword.Text = "Send Passsword?";
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Location = new System.Drawing.Point(142, 413);
            this.comboBoxLocation.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(330, 21);
            this.comboBoxLocation.TabIndex = 12;
            // 
            // lblLocation
            // 
            this.lblLocation.Location = new System.Drawing.Point(52, 413);
            this.lblLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(91, 19);
            this.lblLocation.TabIndex = 11;
            this.lblLocation.Text = "Location/Branch: ";
            // 
            // txtBoxEmailAddress
            // 
            this.txtBoxEmailAddress.Location = new System.Drawing.Point(142, 358);
            this.txtBoxEmailAddress.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBoxEmailAddress.Name = "txtBoxEmailAddress";
            this.txtBoxEmailAddress.Size = new System.Drawing.Size(330, 20);
            this.txtBoxEmailAddress.TabIndex = 10;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.Location = new System.Drawing.Point(52, 304);
            this.lblEmailAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(82, 19);
            this.lblEmailAddress.TabIndex = 9;
            this.lblEmailAddress.Text = "Email address: ";
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(142, 304);
            this.txtBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(330, 20);
            this.txtBoxPhoneNumber.TabIndex = 8;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Location = new System.Drawing.Point(52, 358);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(109, 19);
            this.lblPhoneNumber.TabIndex = 7;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // comboBoxTypeOfUser
            // 
            this.comboBoxTypeOfUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeOfUser.FormattingEnabled = true;
            this.comboBoxTypeOfUser.Location = new System.Drawing.Point(142, 250);
            this.comboBoxTypeOfUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxTypeOfUser.Name = "comboBoxTypeOfUser";
            this.comboBoxTypeOfUser.Size = new System.Drawing.Size(330, 21);
            this.comboBoxTypeOfUser.TabIndex = 6;
            // 
            // lblTypeOfUser
            // 
            this.lblTypeOfUser.Location = new System.Drawing.Point(52, 250);
            this.lblTypeOfUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypeOfUser.Name = "lblTypeOfUser";
            this.lblTypeOfUser.Size = new System.Drawing.Size(75, 19);
            this.lblTypeOfUser.TabIndex = 5;
            this.lblTypeOfUser.Text = "Type of User:  ";
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(142, 140);
            this.txtBoxLastName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(330, 20);
            this.txtBoxLastName.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.Location = new System.Drawing.Point(52, 140);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(75, 19);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name: ";
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(142, 86);
            this.txtBoxFirstName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(330, 20);
            this.txtBoxFirstName.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(56, 86);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(75, 19);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.incidentManagementToolStripMenuItem,
            this.userManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.dashboardToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(76, 22);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // incidentManagementToolStripMenuItem
            // 
            this.incidentManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTicketToolStripMenuItem});
            this.incidentManagementToolStripMenuItem.Name = "incidentManagementToolStripMenuItem";
            this.incidentManagementToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.incidentManagementToolStripMenuItem.Text = "Incident Management";
            this.incidentManagementToolStripMenuItem.Click += new System.EventHandler(this.incidentManagementToolStripMenuItem_Click);
            // 
            // createTicketToolStripMenuItem
            // 
            this.createTicketToolStripMenuItem.Name = "createTicketToolStripMenuItem";
            this.createTicketToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.createTicketToolStripMenuItem.Text = "Create Ticket";
            this.createTicketToolStripMenuItem.Click += new System.EventHandler(this.createTicketToolStripMenuItem_Click);
            // 
            // userManagementToolStripMenuItem
            // 
            this.userManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createUserToolStripMenuItem});
            this.userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            this.userManagementToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.userManagementToolStripMenuItem.Text = "User Management";
            this.userManagementToolStripMenuItem.Click += new System.EventHandler(this.userManagementToolStripMenuItem_Click);
            // 
            // createUserToolStripMenuItem
            // 
            this.createUserToolStripMenuItem.Name = "createUserToolStripMenuItem";
            this.createUserToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.createUserToolStripMenuItem.Text = "Create User";
            this.createUserToolStripMenuItem.Click += new System.EventHandler(this.createUserToolStripMenuItem_Click);
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.lblNumberOfUnresolvedTicket);
            this.pnlDashboard.Controls.Add(this.chrtUnresolvedIncident);
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
            this.pnlDashboard.Controls.Add(this.richTextBox2);
            this.pnlDashboard.Controls.Add(this.richTextBox1);
            this.pnlDashboard.Location = new System.Drawing.Point(1, 22);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(596, 676);
            this.pnlDashboard.TabIndex = 18;
            // 
            // lblNumberOfUnresolvedTicket
            // 
            this.lblNumberOfUnresolvedTicket.BackColor = System.Drawing.SystemColors.Window;
            this.lblNumberOfUnresolvedTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfUnresolvedTicket.Location = new System.Drawing.Point(126, 276);
            this.lblNumberOfUnresolvedTicket.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOfUnresolvedTicket.Name = "lblNumberOfUnresolvedTicket";
            this.lblNumberOfUnresolvedTicket.Size = new System.Drawing.Size(62, 33);
            this.lblNumberOfUnresolvedTicket.TabIndex = 13;
            this.lblNumberOfUnresolvedTicket.Text = "..";
            // 
            // chrtUnresolvedIncident
            // 
            chartArea7.Name = "ChartArea1";
            this.chrtUnresolvedIncident.ChartAreas.Add(chartArea7);
            this.chrtUnresolvedIncident.Location = new System.Drawing.Point(46, 187);
            this.chrtUnresolvedIncident.Margin = new System.Windows.Forms.Padding(2);
            this.chrtUnresolvedIncident.Name = "chrtUnresolvedIncident";
            this.chrtUnresolvedIncident.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.chrtUnresolvedIncident.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Yellow};
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series9.Name = "unreslovedIncident";
            this.chrtUnresolvedIncident.Series.Add(series9);
            this.chrtUnresolvedIncident.Size = new System.Drawing.Size(225, 208);
            this.chrtUnresolvedIncident.TabIndex = 12;
            this.chrtUnresolvedIncident.Text = "chart1";
            // 
            // lblNumberOfUrgentTicket
            // 
            this.lblNumberOfUrgentTicket.AutoSize = true;
            this.lblNumberOfUrgentTicket.BackColor = System.Drawing.SystemColors.Window;
            this.lblNumberOfUrgentTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfUrgentTicket.Location = new System.Drawing.Point(433, 278);
            this.lblNumberOfUrgentTicket.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumberOfUrgentTicket.Name = "lblNumberOfUrgentTicket";
            this.lblNumberOfUrgentTicket.Size = new System.Drawing.Size(22, 25);
            this.lblNumberOfUrgentTicket.TabIndex = 11;
            this.lblNumberOfUrgentTicket.Text = "..";
            // 
            // chrtUrgentIncident
            // 
            chartArea8.Name = "ChartArea1";
            this.chrtUrgentIncident.ChartAreas.Add(chartArea8);
            this.chrtUrgentIncident.Location = new System.Drawing.Point(332, 187);
            this.chrtUrgentIncident.Margin = new System.Windows.Forms.Padding(2);
            this.chrtUrgentIncident.Name = "chrtUrgentIncident";
            this.chrtUrgentIncident.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.chrtUrgentIncident.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0))))),
        System.Drawing.Color.Yellow};
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series10.Name = "urgentIncident";
            this.chrtUrgentIncident.Series.Add(series10);
            this.chrtUrgentIncident.Size = new System.Drawing.Size(225, 208);
            this.chrtUrgentIncident.TabIndex = 10;
            this.chrtUrgentIncident.Text = "chart1";
            // 
            // lblIncidentMonitor
            // 
            this.lblIncidentMonitor.AutoSize = true;
            this.lblIncidentMonitor.BackColor = System.Drawing.SystemColors.Window;
            this.lblIncidentMonitor.Depth = 0;
            this.lblIncidentMonitor.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblIncidentMonitor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblIncidentMonitor.Location = new System.Drawing.Point(103, 623);
            this.lblIncidentMonitor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIncidentMonitor.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblIncidentMonitor.Name = "lblIncidentMonitor";
            this.lblIncidentMonitor.Size = new System.Drawing.Size(194, 19);
            this.lblIncidentMonitor.TabIndex = 9;
            this.lblIncidentMonitor.Text = "the most frequent Incident: ";
            // 
            // chrtFrequancyOfIncidents
            // 
            chartArea9.Name = "ChartArea1";
            this.chrtFrequancyOfIncidents.ChartAreas.Add(chartArea9);
            legend3.Name = "Legend1";
            this.chrtFrequancyOfIncidents.Legends.Add(legend3);
            this.chrtFrequancyOfIncidents.Location = new System.Drawing.Point(52, 437);
            this.chrtFrequancyOfIncidents.Margin = new System.Windows.Forms.Padding(2);
            this.chrtFrequancyOfIncidents.Name = "chrtFrequancyOfIncidents";
            this.chrtFrequancyOfIncidents.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Number of Incident";
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "unresolved Incident";
            this.chrtFrequancyOfIncidents.Series.Add(series11);
            this.chrtFrequancyOfIncidents.Series.Add(series12);
            this.chrtFrequancyOfIncidents.Size = new System.Drawing.Size(497, 185);
            this.chrtFrequancyOfIncidents.TabIndex = 7;
            this.chrtFrequancyOfIncidents.Text = "frequancy";
            title3.Name = "Title1";
            title3.Text = "Frequancy of Incident";
            this.chrtFrequancyOfIncidents.Titles.Add(title3);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(24, 423);
            this.richTextBox3.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(553, 236);
            this.richTextBox3.TabIndex = 6;
            this.richTextBox3.Text = "";
            // 
            // formsPlot1
            // 
            this.formsPlot1.Location = new System.Drawing.Point(519, 188);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(4, 4);
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
            this.btnShowList.Location = new System.Drawing.Point(485, 43);
            this.btnShowList.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowList.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Primary = true;
            this.btnShowList.Size = new System.Drawing.Size(92, 36);
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
            this.lblIncidentDeadlineTickets.Location = new System.Drawing.Point(322, 148);
            this.lblIncidentDeadlineTickets.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIncidentDeadlineTickets.Name = "lblIncidentDeadlineTickets";
            this.lblIncidentDeadlineTickets.Size = new System.Drawing.Size(247, 15);
            this.lblIncidentDeadlineTickets.TabIndex = 1;
            this.lblIncidentDeadlineTickets.Text = "These tickets need your immediate attention";
            // 
            // lblOpenTickets
            // 
            this.lblOpenTickets.AutoSize = true;
            this.lblOpenTickets.BackColor = System.Drawing.SystemColors.Window;
            this.lblOpenTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenTickets.Location = new System.Drawing.Point(91, 148);
            this.lblOpenTickets.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpenTickets.Name = "lblOpenTickets";
            this.lblOpenTickets.Size = new System.Drawing.Size(137, 15);
            this.lblOpenTickets.TabIndex = 1;
            this.lblOpenTickets.Text = "All tickets currently open";
            // 
            // lblIncidentDeadline
            // 
            this.lblIncidentDeadline.AutoSize = true;
            this.lblIncidentDeadline.BackColor = System.Drawing.SystemColors.Window;
            this.lblIncidentDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncidentDeadline.Location = new System.Drawing.Point(362, 122);
            this.lblIncidentDeadline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIncidentDeadline.Name = "lblIncidentDeadline";
            this.lblIncidentDeadline.Size = new System.Drawing.Size(173, 20);
            this.lblIncidentDeadline.TabIndex = 1;
            this.lblIncidentDeadline.Text = "Incidents past deadline";
            // 
            // lblUnresolvedIncident
            // 
            this.lblUnresolvedIncident.AutoSize = true;
            this.lblUnresolvedIncident.BackColor = System.Drawing.SystemColors.Window;
            this.lblUnresolvedIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnresolvedIncident.Location = new System.Drawing.Point(80, 122);
            this.lblUnresolvedIncident.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUnresolvedIncident.Name = "lblUnresolvedIncident";
            this.lblUnresolvedIncident.Size = new System.Drawing.Size(156, 20);
            this.lblUnresolvedIncident.TabIndex = 1;
            this.lblUnresolvedIncident.Text = "Unresolved incidents";
            // 
            // lblCurrentIncident
            // 
            this.lblCurrentIncident.AutoSize = true;
            this.lblCurrentIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentIncident.Location = new System.Drawing.Point(30, 31);
            this.lblCurrentIncident.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentIncident.Name = "lblCurrentIncident";
            this.lblCurrentIncident.Size = new System.Drawing.Size(220, 31);
            this.lblCurrentIncident.TabIndex = 1;
            this.lblCurrentIncident.Text = "Current incidents";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(305, 98);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(272, 313);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(24, 98);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(272, 313);
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
            this.pnlTicketOverview.Location = new System.Drawing.Point(0, 26);
            this.pnlTicketOverview.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlTicketOverview.Name = "pnlTicketOverview";
            this.pnlTicketOverview.Size = new System.Drawing.Size(600, 696);
            this.pnlTicketOverview.TabIndex = 18;
            // 
            // btnArchive
            // 
            this.btnArchive.Location = new System.Drawing.Point(58, 508);
            this.btnArchive.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(85, 19);
            this.btnArchive.TabIndex = 25;
            this.btnArchive.Text = "Archive Tickets";
            this.btnArchive.UseVisualStyleBackColor = true;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // lbArchive
            // 
            this.lbArchive.AutoSize = true;
            this.lbArchive.Location = new System.Drawing.Point(149, 510);
            this.lbArchive.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbArchive.Name = "lbArchive";
            this.lbArchive.Size = new System.Drawing.Size(87, 13);
            this.lbArchive.TabIndex = 24;
            this.lbArchive.Text = "that made before";
            // 
            // DTPArichive
            // 
            this.DTPArichive.Location = new System.Drawing.Point(244, 510);
            this.DTPArichive.Margin = new System.Windows.Forms.Padding(2);
            this.DTPArichive.Name = "DTPArichive";
            this.DTPArichive.Size = new System.Drawing.Size(202, 20);
            this.DTPArichive.TabIndex = 23;
            // 
            // btnTransferTicket
            // 
            this.btnTransferTicket.Enabled = false;
            this.btnTransferTicket.Location = new System.Drawing.Point(460, 17);
            this.btnTransferTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btnTransferTicket.Name = "btnTransferTicket";
            this.btnTransferTicket.Size = new System.Drawing.Size(85, 19);
            this.btnTransferTicket.TabIndex = 20;
            this.btnTransferTicket.Text = "Transfer Ticket ";
            this.btnTransferTicket.UseVisualStyleBackColor = true;
            this.btnTransferTicket.Click += new System.EventHandler(this.btnTransferTicket_Click);
            // 
            // txtBox_FilterBy
            // 
            this.txtBox_FilterBy.ForeColor = System.Drawing.Color.Gray;
            this.txtBox_FilterBy.Location = new System.Drawing.Point(58, 49);
            this.txtBox_FilterBy.Margin = new System.Windows.Forms.Padding(2);
            this.txtBox_FilterBy.Name = "txtBox_FilterBy";
            this.txtBox_FilterBy.Size = new System.Drawing.Size(180, 20);
            this.txtBox_FilterBy.TabIndex = 22;
            this.txtBox_FilterBy.Text = "Filter by subject...";
            this.txtBox_FilterBy.Click += new System.EventHandler(this.txtBox_FilterBy_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(55, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Ticket Overview";
            // 
            // btnCreateTicket
            // 
            this.btnCreateTicket.Location = new System.Drawing.Point(364, 17);
            this.btnCreateTicket.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCreateTicket.Name = "btnCreateTicket";
            this.btnCreateTicket.Size = new System.Drawing.Size(85, 19);
            this.btnCreateTicket.TabIndex = 20;
            this.btnCreateTicket.Text = "Create Ticket";
            this.btnCreateTicket.UseVisualStyleBackColor = true;
            this.btnCreateTicket.Click += new System.EventHandler(this.btnCreateTicket_Click);
            // 
            // btnEscalateTicket
            // 
            this.btnEscalateTicket.Location = new System.Drawing.Point(364, 46);
            this.btnEscalateTicket.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnEscalateTicket.Name = "btnEscalateTicket";
            this.btnEscalateTicket.Size = new System.Drawing.Size(85, 19);
            this.btnEscalateTicket.TabIndex = 19;
            this.btnEscalateTicket.Text = "Escalate Ticket";
            this.btnEscalateTicket.UseVisualStyleBackColor = true;
            this.btnEscalateTicket.Click += new System.EventHandler(this.btnEscalateTicket_Click);
            // 
            // btnCloseTicket
            // 
            this.btnCloseTicket.Location = new System.Drawing.Point(460, 46);
            this.btnCloseTicket.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCloseTicket.Name = "btnCloseTicket";
            this.btnCloseTicket.Size = new System.Drawing.Size(85, 19);
            this.btnCloseTicket.TabIndex = 1;
            this.btnCloseTicket.Text = "Close Ticket";
            this.btnCloseTicket.UseVisualStyleBackColor = true;
            this.btnCloseTicket.Click += new System.EventHandler(this.btnCloseTicket_Click);
            // 
            // btnTicketArchive
            // 
            this.btnTicketArchive.Enabled = false;
            this.btnTicketArchive.Location = new System.Drawing.Point(364, 46);
            this.btnTicketArchive.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTicketArchive.Name = "btnTicketArchive";
            this.btnTicketArchive.Size = new System.Drawing.Size(85, 19);
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
            this.lvTicketOverview.Location = new System.Drawing.Point(58, 80);
            this.lvTicketOverview.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lvTicketOverview.MultiSelect = false;
            this.lvTicketOverview.Name = "lvTicketOverview";
            this.lvTicketOverview.Size = new System.Drawing.Size(488, 417);
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
            this.lvUserOverview.Location = new System.Drawing.Point(58, 80);
            this.lvUserOverview.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lvUserOverview.MultiSelect = false;
            this.lvUserOverview.Name = "lvUserOverview";
            this.lvUserOverview.Size = new System.Drawing.Size(488, 544);
            this.lvUserOverview.TabIndex = 2;
            this.lvUserOverview.UseCompatibleStateImageBehavior = false;
            this.lvUserOverview.View = System.Windows.Forms.View.Details;
            // 
            // userId
            // 
            this.userId.Text = "ID";
            this.userId.Width = 100;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 350;
            // 
            // firstName
            // 
            this.firstName.Text = "First Name";
            this.firstName.Width = 150;
            // 
            // lastName
            // 
            this.lastName.Text = "Last Name";
            this.lastName.Width = 150;
            // 
            // ticket
            // 
            this.ticket.Text = "Subject";
            this.ticket.Width = 300;
            // 
            // pnlUserOverview
            // 
            this.pnlUserOverview.Controls.Add(this.lblUserOverview);
            this.pnlUserOverview.Controls.Add(this.lvUserOverview);
            this.pnlUserOverview.Location = new System.Drawing.Point(0, 26);
            this.pnlUserOverview.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlUserOverview.Name = "pnlUserOverview";
            this.pnlUserOverview.Size = new System.Drawing.Size(600, 696);
            this.pnlUserOverview.TabIndex = 18;
            // 
            // lblUserOverview
            // 
            this.lblUserOverview.AutoSize = true;
            this.lblUserOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserOverview.Location = new System.Drawing.Point(55, 17);
            this.lblUserOverview.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserOverview.Name = "lblUserOverview";
            this.lblUserOverview.Size = new System.Drawing.Size(123, 20);
            this.lblUserOverview.TabIndex = 22;
            this.lblUserOverview.Text = "User Overview";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(600, 696);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.pnlCreateTicket);
            this.Controls.Add(this.pnlUserOverview);
            this.Controls.Add(this.pnlTicketOverview);
            this.Controls.Add(this.pnlAddUser);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
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
            ((System.ComponentModel.ISupportInitialize)(this.chrtUnresolvedIncident)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtUrgentIncident)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtFrequancyOfIncidents)).EndInit();
            this.pnlTicketOverview.ResumeLayout(false);
            this.pnlTicketOverview.PerformLayout();
            this.pnlUserOverview.ResumeLayout(false);
            this.pnlUserOverview.PerformLayout();
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
        private Label lblCreatingUserErrorMessage;
        private Label lblNumberOfUnresolvedTicket;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtUnresolvedIncident;
        private Label lblUserOverview;
        private MaterialSkin.Controls.MaterialRaisedButton btnSubmitTicket;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelTicket;
    }
}