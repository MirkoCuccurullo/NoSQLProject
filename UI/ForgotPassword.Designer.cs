namespace DemoApp
{
    partial class ForgotPassword
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
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.EmailPass = new System.Windows.Forms.TextBox();
            this.NewPass = new System.Windows.Forms.TextBox();
            this.BackBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.confirmPasstb = new System.Windows.Forms.TextBox();
            this.labelWarning3 = new System.Windows.Forms.Label();
            this.labelWarning2 = new System.Windows.Forms.Label();
            this.labelWarning1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnChange = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password sent by email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "New Password:";
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(200, 149);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(340, 30);
            this.tbUsername.TabIndex = 3;
            // 
            // EmailPass
            // 
            this.EmailPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailPass.Location = new System.Drawing.Point(349, 221);
            this.EmailPass.Name = "EmailPass";
            this.EmailPass.Size = new System.Drawing.Size(191, 30);
            this.EmailPass.TabIndex = 4;
            // 
            // NewPass
            // 
            this.NewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPass.Location = new System.Drawing.Point(273, 299);
            this.NewPass.Name = "NewPass";
            this.NewPass.Size = new System.Drawing.Size(267, 30);
            this.NewPass.TabIndex = 5;
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(12, 23);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(92, 23);
            this.BackBtn.TabIndex = 7;
            this.BackBtn.Text = "Back to login";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Confirm Password:";
            // 
            // confirmPasstb
            // 
            this.confirmPasstb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasstb.Location = new System.Drawing.Point(311, 370);
            this.confirmPasstb.Name = "confirmPasstb";
            this.confirmPasstb.Size = new System.Drawing.Size(229, 30);
            this.confirmPasstb.TabIndex = 9;
            // 
            // labelWarning3
            // 
            this.labelWarning3.AutoSize = true;
            this.labelWarning3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWarning3.ForeColor = System.Drawing.Color.Red;
            this.labelWarning3.Location = new System.Drawing.Point(47, 342);
            this.labelWarning3.Name = "labelWarning3";
            this.labelWarning3.Size = new System.Drawing.Size(165, 17);
            this.labelWarning3.TabIndex = 10;
            this.labelWarning3.Text = "Passwords do not match!";
            // 
            // labelWarning2
            // 
            this.labelWarning2.AutoSize = true;
            this.labelWarning2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWarning2.ForeColor = System.Drawing.Color.Red;
            this.labelWarning2.Location = new System.Drawing.Point(47, 265);
            this.labelWarning2.Name = "labelWarning2";
            this.labelWarning2.Size = new System.Drawing.Size(353, 17);
            this.labelWarning2.TabIndex = 11;
            this.labelWarning2.Text = "This is not the password which has been sent by email!";
            // 
            // labelWarning1
            // 
            this.labelWarning1.AutoSize = true;
            this.labelWarning1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWarning1.ForeColor = System.Drawing.Color.Red;
            this.labelWarning1.Location = new System.Drawing.Point(47, 195);
            this.labelWarning1.Name = "labelWarning1";
            this.labelWarning1.Size = new System.Drawing.Size(129, 17);
            this.labelWarning1.TabIndex = 12;
            this.labelWarning1.Text = "User does not exist";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(121, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 39);
            this.label5.TabIndex = 13;
            this.label5.Text = "Change Password";
            // 
            // btnChange
            // 
            this.btnChange.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChange.Depth = 0;
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Icon = null;
            this.btnChange.Location = new System.Drawing.Point(185, 495);
            this.btnChange.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnChange.Name = "btnChange";
            this.btnChange.Primary = true;
            this.btnChange.Size = new System.Drawing.Size(155, 36);
            this.btnChange.TabIndex = 14;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 727);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelWarning1);
            this.Controls.Add(this.labelWarning2);
            this.Controls.Add(this.labelWarning3);
            this.Controls.Add(this.confirmPasstb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.NewPass);
            this.Controls.Add(this.EmailPass);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox EmailPass;
        private System.Windows.Forms.TextBox NewPass;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox confirmPasstb;
        private System.Windows.Forms.Label labelWarning3;
        private System.Windows.Forms.Label labelWarning2;
        private System.Windows.Forms.Label labelWarning1;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialRaisedButton btnChange;
    }
}