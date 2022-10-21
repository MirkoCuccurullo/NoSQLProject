namespace DemoApp
{
    partial class TransferTicket
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
            this.lblTransferTicketNo = new System.Windows.Forms.Label();
            this.comboBoxUsers = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTransferTicketNo
            // 
            this.lblTransferTicketNo.Location = new System.Drawing.Point(64, 69);
            this.lblTransferTicketNo.Name = "lblTransferTicketNo";
            this.lblTransferTicketNo.Size = new System.Drawing.Size(221, 27);
            this.lblTransferTicketNo.TabIndex = 0;
            this.lblTransferTicketNo.Text = "Chose user to transfer ticket to:";
            // 
            // comboBoxUsers
            // 
            this.comboBoxUsers.FormattingEnabled = true;
            this.comboBoxUsers.Location = new System.Drawing.Point(47, 128);
            this.comboBoxUsers.Name = "comboBoxUsers";
            this.comboBoxUsers.Size = new System.Drawing.Size(416, 24);
            this.comboBoxUsers.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(47, 203);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(249, 203);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(155, 23);
            this.btnTransfer.TabIndex = 3;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // TransferTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 256);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.comboBoxUsers);
            this.Controls.Add(this.lblTransferTicketNo);
            this.Name = "TransferTicket";
            this.Text = "TransferTicket";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTransferTicketNo;
        private System.Windows.Forms.ComboBox comboBoxUsers;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnTransfer;
    }
}