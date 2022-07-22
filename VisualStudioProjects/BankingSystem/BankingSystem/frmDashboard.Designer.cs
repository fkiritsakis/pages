namespace BankingSystem
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.pnlTopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnViewEmployeeAccount = new System.Windows.Forms.Button();
            this.btnCreateEmployeeAccount = new System.Windows.Forms.Button();
            this.btnViewClientAccount = new System.Windows.Forms.Button();
            this.btnAccountDetails = new System.Windows.Forms.Button();
            this.btnCreateClientAccount = new System.Windows.Forms.Button();
            this.btnCheckBalance = new System.Windows.Forms.Button();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
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
            this.pnlTopPanel.Name = "pnlTopPanel";
            this.pnlTopPanel.Size = new System.Drawing.Size(570, 31);
            this.pnlTopPanel.TabIndex = 1;
            this.pnlTopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseDown_Event);
            this.pnlTopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseMove_Event);
            this.pnlTopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseUp_Event);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Banking System";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.SystemColors.Control;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(458, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(56, 31);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "---";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(514, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 31);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Logged in as:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(121, 60);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(108, 19);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Placeholder Text";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(433, 54);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(97, 31);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnViewEmployeeAccount
            // 
            this.btnViewEmployeeAccount.FlatAppearance.BorderSize = 0;
            this.btnViewEmployeeAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnViewEmployeeAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnViewEmployeeAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewEmployeeAccount.Image = global::BankingSystem.Properties.Resources.bankAppImage72px;
            this.btnViewEmployeeAccount.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewEmployeeAccount.Location = new System.Drawing.Point(406, 261);
            this.btnViewEmployeeAccount.Name = "btnViewEmployeeAccount";
            this.btnViewEmployeeAccount.Size = new System.Drawing.Size(124, 127);
            this.btnViewEmployeeAccount.TabIndex = 10;
            this.btnViewEmployeeAccount.Text = "View Employee Account";
            this.btnViewEmployeeAccount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewEmployeeAccount.UseVisualStyleBackColor = true;
            this.btnViewEmployeeAccount.Click += new System.EventHandler(this.btnViewEmployeeAccount_Click);
            // 
            // btnCreateEmployeeAccount
            // 
            this.btnCreateEmployeeAccount.FlatAppearance.BorderSize = 0;
            this.btnCreateEmployeeAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnCreateEmployeeAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCreateEmployeeAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateEmployeeAccount.Image = global::BankingSystem.Properties.Resources.bankAppImage72px;
            this.btnCreateEmployeeAccount.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCreateEmployeeAccount.Location = new System.Drawing.Point(276, 261);
            this.btnCreateEmployeeAccount.Name = "btnCreateEmployeeAccount";
            this.btnCreateEmployeeAccount.Size = new System.Drawing.Size(124, 127);
            this.btnCreateEmployeeAccount.TabIndex = 9;
            this.btnCreateEmployeeAccount.Text = "Create Employee Account";
            this.btnCreateEmployeeAccount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCreateEmployeeAccount.UseVisualStyleBackColor = true;
            this.btnCreateEmployeeAccount.Click += new System.EventHandler(this.btnCreateEmployeeAccount_Click);
            // 
            // btnViewClientAccount
            // 
            this.btnViewClientAccount.FlatAppearance.BorderSize = 0;
            this.btnViewClientAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnViewClientAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnViewClientAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewClientAccount.Image = global::BankingSystem.Properties.Resources.bankAppImage72px;
            this.btnViewClientAccount.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewClientAccount.Location = new System.Drawing.Point(146, 261);
            this.btnViewClientAccount.Name = "btnViewClientAccount";
            this.btnViewClientAccount.Size = new System.Drawing.Size(124, 127);
            this.btnViewClientAccount.TabIndex = 8;
            this.btnViewClientAccount.Text = "View Client Accounts";
            this.btnViewClientAccount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnViewClientAccount.UseVisualStyleBackColor = true;
            this.btnViewClientAccount.Click += new System.EventHandler(this.btnViewClientAccount_Click);
            // 
            // btnAccountDetails
            // 
            this.btnAccountDetails.FlatAppearance.BorderSize = 0;
            this.btnAccountDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnAccountDetails.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAccountDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountDetails.Image = global::BankingSystem.Properties.Resources.bankAppImage72px;
            this.btnAccountDetails.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAccountDetails.Location = new System.Drawing.Point(406, 110);
            this.btnAccountDetails.Name = "btnAccountDetails";
            this.btnAccountDetails.Size = new System.Drawing.Size(124, 132);
            this.btnAccountDetails.TabIndex = 7;
            this.btnAccountDetails.Text = "Your Account Details";
            this.btnAccountDetails.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAccountDetails.UseVisualStyleBackColor = true;
            this.btnAccountDetails.Click += new System.EventHandler(this.btnAccountDetails_Click);
            // 
            // btnCreateClientAccount
            // 
            this.btnCreateClientAccount.FlatAppearance.BorderSize = 0;
            this.btnCreateClientAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnCreateClientAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCreateClientAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateClientAccount.Image = global::BankingSystem.Properties.Resources.bankAppImage72px;
            this.btnCreateClientAccount.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCreateClientAccount.Location = new System.Drawing.Point(16, 261);
            this.btnCreateClientAccount.Name = "btnCreateClientAccount";
            this.btnCreateClientAccount.Size = new System.Drawing.Size(124, 127);
            this.btnCreateClientAccount.TabIndex = 6;
            this.btnCreateClientAccount.Text = "Create Client Account";
            this.btnCreateClientAccount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCreateClientAccount.UseVisualStyleBackColor = true;
            this.btnCreateClientAccount.Click += new System.EventHandler(this.btnCreateClientAccount_Click);
            // 
            // btnCheckBalance
            // 
            this.btnCheckBalance.FlatAppearance.BorderSize = 0;
            this.btnCheckBalance.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnCheckBalance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCheckBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckBalance.Image = global::BankingSystem.Properties.Resources.bankAppImage72px;
            this.btnCheckBalance.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCheckBalance.Location = new System.Drawing.Point(276, 110);
            this.btnCheckBalance.Name = "btnCheckBalance";
            this.btnCheckBalance.Size = new System.Drawing.Size(124, 119);
            this.btnCheckBalance.TabIndex = 5;
            this.btnCheckBalance.Text = "Check Balance";
            this.btnCheckBalance.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCheckBalance.UseVisualStyleBackColor = true;
            this.btnCheckBalance.Click += new System.EventHandler(this.btnCheckBalance_Click);
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.FlatAppearance.BorderSize = 0;
            this.btnWithdraw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnWithdraw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Image = global::BankingSystem.Properties.Resources.bankAppImage72px;
            this.btnWithdraw.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnWithdraw.Location = new System.Drawing.Point(146, 110);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(124, 119);
            this.btnWithdraw.TabIndex = 4;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWithdraw.UseVisualStyleBackColor = true;
            this.btnWithdraw.Click += new System.EventHandler(this.btnWithdraw_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.FlatAppearance.BorderSize = 0;
            this.btnDeposit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btnDeposit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeposit.Image = global::BankingSystem.Properties.Resources.bankAppImage72px;
            this.btnDeposit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeposit.Location = new System.Drawing.Point(16, 110);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(124, 119);
            this.btnDeposit.TabIndex = 3;
            this.btnDeposit.Text = "Deposit";
            this.btnDeposit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 422);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnViewEmployeeAccount);
            this.Controls.Add(this.btnCreateEmployeeAccount);
            this.Controls.Add(this.btnViewClientAccount);
            this.Controls.Add(this.btnAccountDetails);
            this.Controls.Add(this.btnCreateClientAccount);
            this.Controls.Add(this.btnCheckBalance);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.pnlTopPanel);
            this.Font = new System.Drawing.Font("Leelawadee UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
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
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Button btnCheckBalance;
        private System.Windows.Forms.Button btnCreateClientAccount;
        private System.Windows.Forms.Button btnAccountDetails;
        private System.Windows.Forms.Button btnViewClientAccount;
        private System.Windows.Forms.Button btnCreateEmployeeAccount;
        private System.Windows.Forms.Button btnViewEmployeeAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnLogout;
    }
}