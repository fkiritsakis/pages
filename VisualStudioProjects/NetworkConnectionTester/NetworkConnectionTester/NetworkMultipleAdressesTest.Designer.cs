namespace NetworkConnectionTester
{
    partial class NetworkMultipleAdressesTest
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStartInvalidInput = new System.Windows.Forms.Label();
            this.txtStartAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEndInvalidInput = new System.Windows.Forms.Label();
            this.txtEndAdress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblStartInvalidInput
            // 
            this.lblStartInvalidInput.AutoSize = true;
            this.lblStartInvalidInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblStartInvalidInput.Location = new System.Drawing.Point(247, 15);
            this.lblStartInvalidInput.Name = "lblStartInvalidInput";
            this.lblStartInvalidInput.Size = new System.Drawing.Size(68, 13);
            this.lblStartInvalidInput.TabIndex = 5;
            this.lblStartInvalidInput.Text = "Invalid Input!";
            // 
            // txtStartAddress
            // 
            this.txtStartAddress.Location = new System.Drawing.Point(110, 12);
            this.txtStartAddress.Name = "txtStartAddress";
            this.txtStartAddress.Size = new System.Drawing.Size(131, 20);
            this.txtStartAddress.TabIndex = 4;
            this.txtStartAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Start Address:";
            // 
            // lblEndInvalidInput
            // 
            this.lblEndInvalidInput.AutoSize = true;
            this.lblEndInvalidInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEndInvalidInput.Location = new System.Drawing.Point(244, 49);
            this.lblEndInvalidInput.Name = "lblEndInvalidInput";
            this.lblEndInvalidInput.Size = new System.Drawing.Size(68, 13);
            this.lblEndInvalidInput.TabIndex = 8;
            this.lblEndInvalidInput.Text = "Invalid Input!";
            // 
            // txtEndAdress
            // 
            this.txtEndAdress.Location = new System.Drawing.Point(107, 46);
            this.txtEndAdress.Name = "txtEndAdress";
            this.txtEndAdress.Size = new System.Drawing.Size(131, 20);
            this.txtEndAdress.TabIndex = 7;
            this.txtEndAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Enter End Address:";
            // 
            // txtTextBox
            // 
            this.txtTextBox.Location = new System.Drawing.Point(110, 93);
            this.txtTextBox.Multiline = true;
            this.txtTextBox.Name = "txtTextBox";
            this.txtTextBox.ReadOnly = true;
            this.txtTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTextBox.Size = new System.Drawing.Size(271, 132);
            this.txtTextBox.TabIndex = 9;
            // 
            // NetworkMultipleAdressesTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTextBox);
            this.Controls.Add(this.lblEndInvalidInput);
            this.Controls.Add(this.txtEndAdress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblStartInvalidInput);
            this.Controls.Add(this.txtStartAddress);
            this.Controls.Add(this.label1);
            this.Name = "NetworkMultipleAdressesTest";
            this.Size = new System.Drawing.Size(475, 250);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartInvalidInput;
        private System.Windows.Forms.TextBox txtStartAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEndInvalidInput;
        private System.Windows.Forms.TextBox txtEndAdress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTextBox;
    }
}
