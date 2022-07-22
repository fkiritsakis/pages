namespace BankingSystem
{
    partial class frmEmployeeAccountCreation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeAccountCreation));
            this.pnlTopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnCreateAccount = new System.Windows.Forms.Button();
            this.pnlTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopPanel
            // 
            this.pnlTopPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlTopPanel.Controls.Add(this.label1);
            this.pnlTopPanel.Controls.Add(this.btnMinimize);
            this.pnlTopPanel.Controls.Add(this.btnExit);
            this.pnlTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlTopPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlTopPanel.Name = "pnlTopPanel";
            this.pnlTopPanel.Size = new System.Drawing.Size(419, 41);
            this.pnlTopPanel.TabIndex = 1;
            this.pnlTopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseDown_Event);
            this.pnlTopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseMove_Event);
            this.pnlTopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseUp_Event);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Create New Employee Account";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.SystemColors.Control;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(293, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(63, 41);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "---";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(356, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(63, 41);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "First Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Last Name:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(224, 83);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(155, 29);
            this.txtUsername.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(224, 123);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(155, 29);
            this.txtPassword.TabIndex = 7;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(224, 162);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(155, 29);
            this.txtConfirmPassword.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Confirm Password:";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(224, 246);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(155, 29);
            this.txtLastName.TabIndex = 11;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(224, 206);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(155, 29);
            this.txtFirstName.TabIndex = 10;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.SystemColors.Control;
            this.btnCreateAccount.FlatAppearance.BorderSize = 0;
            this.btnCreateAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCreateAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.Location = new System.Drawing.Point(224, 322);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(155, 31);
            this.btnCreateAccount.TabIndex = 12;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // frmEmployeeAccountCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 384);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlTopPanel);
            this.Font = new System.Drawing.Font("Leelawadee UI", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmEmployeeAccountCreation";
            this.Text = "New Client Account";
            this.Load += new System.EventHandler(this.frmAccountCreation_Load);
            this.pnlTopPanel.ResumeLayout(false);
            this.pnlTopPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnCreateAccount;
    }
}