namespace NetworkConnectionTester
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnExit = new System.Windows.Forms.Button();
            this.pntTopPanel = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblTittle = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnRangeAdressTab = new System.Windows.Forms.Button();
            this.btnSingleAddressTab = new System.Windows.Forms.Button();
            this.btnDebug = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ntwSingleAddressTest = new NetworkConnectionTester.NetworkSingleAddressTest();
            this.ntwMutlipleAdressTest = new NetworkConnectionTester.NetworkMultipleAdressesTest();
            this.pntTopPanel.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(536, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(62, 28);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pntTopPanel
            // 
            this.pntTopPanel.Controls.Add(this.btnMinimize);
            this.pntTopPanel.Controls.Add(this.lblTittle);
            this.pntTopPanel.Controls.Add(this.btnExit);
            this.pntTopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pntTopPanel.Location = new System.Drawing.Point(0, 0);
            this.pntTopPanel.Name = "pntTopPanel";
            this.pntTopPanel.Size = new System.Drawing.Size(598, 28);
            this.pntTopPanel.TabIndex = 1;
            this.pntTopPanel.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.topBarDoubleClick_Event);
            this.pntTopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topBarMouseDown_Event);
            this.pntTopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topBarMouseMove_Event);
            this.pntTopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topBarMouseUp_Event);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(474, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(62, 28);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "---";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Location = new System.Drawing.Point(12, 8);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(137, 13);
            this.lblTittle.TabIndex = 2;
            this.lblTittle.Text = "Network Connection Tester";
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.button3);
            this.pnlMenu.Controls.Add(this.btnRangeAdressTab);
            this.pnlMenu.Controls.Add(this.btnSingleAddressTab);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 28);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(598, 42);
            this.pnlMenu.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(285, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "Find Occupied Addresses";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnRangeAdressTab
            // 
            this.btnRangeAdressTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRangeAdressTab.FlatAppearance.BorderSize = 0;
            this.btnRangeAdressTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRangeAdressTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRangeAdressTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRangeAdressTab.Location = new System.Drawing.Point(137, 0);
            this.btnRangeAdressTab.Name = "btnRangeAdressTab";
            this.btnRangeAdressTab.Size = new System.Drawing.Size(148, 42);
            this.btnRangeAdressTab.TabIndex = 1;
            this.btnRangeAdressTab.Text = "Test Range of Addresses";
            this.btnRangeAdressTab.UseVisualStyleBackColor = true;
            this.btnRangeAdressTab.Click += new System.EventHandler(this.btnRangeAdressTab_Click);
            // 
            // btnSingleAddressTab
            // 
            this.btnSingleAddressTab.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSingleAddressTab.FlatAppearance.BorderSize = 0;
            this.btnSingleAddressTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSingleAddressTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSingleAddressTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSingleAddressTab.Location = new System.Drawing.Point(0, 0);
            this.btnSingleAddressTab.Name = "btnSingleAddressTab";
            this.btnSingleAddressTab.Size = new System.Drawing.Size(137, 42);
            this.btnSingleAddressTab.TabIndex = 0;
            this.btnSingleAddressTab.Text = "Test Single Address";
            this.btnSingleAddressTab.UseVisualStyleBackColor = true;
            this.btnSingleAddressTab.Click += new System.EventHandler(this.btnSingleAddressTab_Click);
            // 
            // btnDebug
            // 
            this.btnDebug.Location = new System.Drawing.Point(227, 355);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(113, 23);
            this.btnDebug.TabIndex = 4;
            this.btnDebug.Text = "debug Button";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // btnTest
            // 
            this.btnTest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Location = new System.Drawing.Point(46, 411);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(91, 27);
            this.btnTest.TabIndex = 7;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(445, 411);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(91, 27);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ntwSingleAddressTest
            // 
            this.ntwSingleAddressTest.Location = new System.Drawing.Point(12, 123);
            this.ntwSingleAddressTest.Name = "ntwSingleAddressTest";
            this.ntwSingleAddressTest.Size = new System.Drawing.Size(454, 204);
            this.ntwSingleAddressTest.TabIndex = 6;
            this.ntwSingleAddressTest.Visible = false;
            this.ntwSingleAddressTest.Load += new System.EventHandler(this.ntwSingleAddressTest_Load);
            // 
            // ntwMutlipleAdressTest
            // 
            this.ntwMutlipleAdressTest.Location = new System.Drawing.Point(15, 99);
            this.ntwMutlipleAdressTest.Name = "ntwMutlipleAdressTest";
            this.ntwMutlipleAdressTest.Size = new System.Drawing.Size(475, 250);
            this.ntwMutlipleAdressTest.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 450);
            this.Controls.Add(this.ntwMutlipleAdressTest);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.ntwSingleAddressTest);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pntTopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Network Connection Tester";
            this.pntTopPanel.ResumeLayout(false);
            this.pntTopPanel.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pntTopPanel;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnSingleAddressTab;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnRangeAdressTab;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnDebug;
        private NetworkSingleAddressTest ntwSingleAddressTest;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnClose;
        private NetworkMultipleAdressesTest ntwMutlipleAdressTest;
    }
}

