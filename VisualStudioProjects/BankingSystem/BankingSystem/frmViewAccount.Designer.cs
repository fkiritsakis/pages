namespace BankingSystem
{
    partial class frmViewAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewAccounts));
            this.btnRemove = new System.Windows.Forms.Button();
            this.dgTransactions = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnGetPassword = new System.Windows.Forms.Button();
            this.btnUpdatePassword = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(501, 295);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(110, 31);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnSaveTransactions_Click);
            // 
            // dgTransactions
            // 
            this.dgTransactions.AllowUserToAddRows = false;
            this.dgTransactions.AllowUserToDeleteRows = false;
            this.dgTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTransactions.Location = new System.Drawing.Point(12, 49);
            this.dgTransactions.MultiSelect = false;
            this.dgTransactions.Name = "dgTransactions";
            this.dgTransactions.ReadOnly = true;
            this.dgTransactions.RowHeadersWidth = 51;
            this.dgTransactions.RowTemplate.Height = 24;
            this.dgTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTransactions.Size = new System.Drawing.Size(483, 277);
            this.dgTransactions.TabIndex = 4;
            this.dgTransactions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTransactions_CellClick);
            this.dgTransactions.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTransactions_OnRowEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Accounts";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(703, 295);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 31);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Details of selected row";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(501, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(501, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(501, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Balance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(501, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Username:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(501, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Password:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(605, 49);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(208, 26);
            this.txtFirstName.TabIndex = 13;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(605, 78);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(208, 26);
            this.txtLastName.TabIndex = 14;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(605, 110);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(208, 26);
            this.txtBalance.TabIndex = 15;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(605, 142);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(208, 26);
            this.txtUsername.TabIndex = 16;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(605, 174);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(208, 26);
            this.txtPassword.TabIndex = 17;
            // 
            // btnGetPassword
            // 
            this.btnGetPassword.BackColor = System.Drawing.SystemColors.Control;
            this.btnGetPassword.FlatAppearance.BorderSize = 0;
            this.btnGetPassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGetPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetPassword.Location = new System.Drawing.Point(703, 206);
            this.btnGetPassword.Name = "btnGetPassword";
            this.btnGetPassword.Size = new System.Drawing.Size(110, 31);
            this.btnGetPassword.TabIndex = 18;
            this.btnGetPassword.Text = "Get Password";
            this.btnGetPassword.UseVisualStyleBackColor = false;
            this.btnGetPassword.Click += new System.EventHandler(this.btnGetPassword_Click);
            // 
            // btnUpdatePassword
            // 
            this.btnUpdatePassword.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdatePassword.FlatAppearance.BorderSize = 0;
            this.btnUpdatePassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdatePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnUpdatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePassword.Location = new System.Drawing.Point(669, 243);
            this.btnUpdatePassword.Name = "btnUpdatePassword";
            this.btnUpdatePassword.Size = new System.Drawing.Size(144, 31);
            this.btnUpdatePassword.TabIndex = 19;
            this.btnUpdatePassword.Text = "Update Password";
            this.btnUpdatePassword.UseVisualStyleBackColor = false;
            this.btnUpdatePassword.Click += new System.EventHandler(this.btnUpdatePassword_Click);
            // 
            // frmViewAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 338);
            this.Controls.Add(this.btnUpdatePassword);
            this.Controls.Add(this.btnGetPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgTransactions);
            this.Controls.Add(this.btnRemove);
            this.Font = new System.Drawing.Font("Leelawadee UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmViewAccounts";
            this.Text = "Accounts";
            this.Load += new System.EventHandler(this.frmCheckBalance_OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dgTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView dgTransactions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnGetPassword;
        private System.Windows.Forms.Button btnUpdatePassword;
    }
}