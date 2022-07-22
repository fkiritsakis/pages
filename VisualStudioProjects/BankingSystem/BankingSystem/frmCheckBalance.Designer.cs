namespace BankingSystem
{
    partial class frmCheckBalance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckBalance));
            this.label1 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnSaveTransactions = new System.Windows.Forms.Button();
            this.dgTransactions = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Balance:";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(128, 28);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(150, 19);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "Placeholder for Balance";
            // 
            // btnSaveTransactions
            // 
            this.btnSaveTransactions.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveTransactions.FlatAppearance.BorderSize = 0;
            this.btnSaveTransactions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSaveTransactions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSaveTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveTransactions.Location = new System.Drawing.Point(178, 300);
            this.btnSaveTransactions.Name = "btnSaveTransactions";
            this.btnSaveTransactions.Size = new System.Drawing.Size(201, 31);
            this.btnSaveTransactions.TabIndex = 3;
            this.btnSaveTransactions.Text = "Save Transactions to File";
            this.btnSaveTransactions.UseVisualStyleBackColor = false;
            this.btnSaveTransactions.Click += new System.EventHandler(this.btnSaveTransactions_Click);
            // 
            // dgTransactions
            // 
            this.dgTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTransactions.Location = new System.Drawing.Point(12, 89);
            this.dgTransactions.Name = "dgTransactions";
            this.dgTransactions.RowHeadersWidth = 51;
            this.dgTransactions.RowTemplate.Height = 24;
            this.dgTransactions.Size = new System.Drawing.Size(367, 150);
            this.dgTransactions.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Your Transaction History:";
            // 
            // frmCheckBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 343);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgTransactions);
            this.Controls.Add(this.btnSaveTransactions);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Leelawadee UI", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmCheckBalance";
            this.Text = "Your Balance";
            this.Load += new System.EventHandler(this.frmCheckBalance_OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.dgTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnSaveTransactions;
        private System.Windows.Forms.DataGridView dgTransactions;
        private System.Windows.Forms.Label label2;
    }
}