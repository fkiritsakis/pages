namespace NetworkConnectionTester
{
    partial class NetworkSingleAddressTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblInvalidInput = new System.Windows.Forms.Label();
            this.txtTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(86, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(131, 20);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblInvalidInput
            // 
            this.lblInvalidInput.AutoSize = true;
            this.lblInvalidInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInvalidInput.Location = new System.Drawing.Point(247, 7);
            this.lblInvalidInput.Name = "lblInvalidInput";
            this.lblInvalidInput.Size = new System.Drawing.Size(68, 13);
            this.lblInvalidInput.TabIndex = 2;
            this.lblInvalidInput.Text = "Invalid Input!";
            // 
            // txtTextBox
            // 
            this.txtTextBox.Location = new System.Drawing.Point(109, 55);
            this.txtTextBox.Multiline = true;
            this.txtTextBox.Name = "txtTextBox";
            this.txtTextBox.ReadOnly = true;
            this.txtTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTextBox.Size = new System.Drawing.Size(271, 132);
            this.txtTextBox.TabIndex = 3;
            // 
            // NetworkSingleAddressTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTextBox);
            this.Controls.Add(this.lblInvalidInput);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label1);
            this.Name = "NetworkSingleAddressTest";
            this.Size = new System.Drawing.Size(454, 217);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblInvalidInput;
        private System.Windows.Forms.TextBox txtTextBox;
    }
}
