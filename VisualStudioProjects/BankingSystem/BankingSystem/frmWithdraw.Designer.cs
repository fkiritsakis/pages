namespace BankingSystem
{
    partial class frmWithdraw
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
            this.pnlTopPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnWithdraw = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numWithdrawAmount = new System.Windows.Forms.NumericUpDown();
            this.pnlTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWithdrawAmount)).BeginInit();
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
            this.pnlTopPanel.Size = new System.Drawing.Size(450, 31);
            this.pnlTopPanel.TabIndex = 2;
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
            this.btnMinimize.Location = new System.Drawing.Point(338, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(56, 31);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "---";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseDown_Event);
            this.btnMinimize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseMove_Event);
            this.btnMinimize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseUp_Event);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(394, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(56, 31);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "£";
            // 
            // btnWithdraw
            // 
            this.btnWithdraw.BackColor = System.Drawing.SystemColors.Control;
            this.btnWithdraw.FlatAppearance.BorderSize = 0;
            this.btnWithdraw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnWithdraw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnWithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdraw.Location = new System.Drawing.Point(212, 184);
            this.btnWithdraw.Name = "btnWithdraw";
            this.btnWithdraw.Size = new System.Drawing.Size(97, 31);
            this.btnWithdraw.TabIndex = 2;
            this.btnWithdraw.Text = "Withdraw";
            this.btnWithdraw.UseVisualStyleBackColor = false;
            this.btnWithdraw.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(208, 60);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(142, 19);
            this.lblBalance.TabIndex = 14;
            this.lblBalance.Text = "Your Current Balance:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "The Amount you want to Withdraw:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Your Current Balance:";
            // 
            // numWithdrawAmount
            // 
            this.numWithdrawAmount.DecimalPlaces = 2;
            this.numWithdrawAmount.Increment = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            this.numWithdrawAmount.Location = new System.Drawing.Point(271, 110);
            this.numWithdrawAmount.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numWithdrawAmount.Name = "numWithdrawAmount";
            this.numWithdrawAmount.Size = new System.Drawing.Size(99, 26);
            this.numWithdrawAmount.TabIndex = 16;
            this.numWithdrawAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 240);
            this.Controls.Add(this.numWithdrawAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnWithdraw);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlTopPanel);
            this.Font = new System.Drawing.Font("Leelawadee UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmWithdraw";
            this.Text = "frmDeposit";
            this.Load += new System.EventHandler(this.frmWithdraw_OnLoad);
            this.pnlTopPanel.ResumeLayout(false);
            this.pnlTopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWithdrawAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnWithdraw;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numWithdrawAmount;
    }
}