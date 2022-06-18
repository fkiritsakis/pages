
namespace Windows_Forms_Simple_RPG
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.MessagesTitle = new System.Windows.Forms.Label();
            this.MessagesText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_PlayerHP = new System.Windows.Forms.Label();
            this.txt_PlayerStrength = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_PlayerDefense = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_EnemyDefense = new System.Windows.Forms.Label();
            this.txt_EnemyStrength = new System.Windows.Forms.Label();
            this.txt_EnemyHP = new System.Windows.Forms.Label();
            this.txt_EnemyName = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1002, 602);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MessagesTitle
            // 
            this.MessagesTitle.AutoSize = true;
            this.MessagesTitle.Location = new System.Drawing.Point(53, 393);
            this.MessagesTitle.Name = "MessagesTitle";
            this.MessagesTitle.Size = new System.Drawing.Size(61, 15);
            this.MessagesTitle.TabIndex = 1;
            this.MessagesTitle.Text = "Messages:";
            // 
            // MessagesText
            // 
            this.MessagesText.AutoSize = true;
            this.MessagesText.Location = new System.Drawing.Point(86, 441);
            this.MessagesText.Name = "MessagesText";
            this.MessagesText.Size = new System.Drawing.Size(16, 15);
            this.MessagesText.TabIndex = 0;
            this.MessagesText.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1002, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Health:";
            // 
            // txt_PlayerHP
            // 
            this.txt_PlayerHP.AutoSize = true;
            this.txt_PlayerHP.Location = new System.Drawing.Point(1084, 76);
            this.txt_PlayerHP.Name = "txt_PlayerHP";
            this.txt_PlayerHP.Size = new System.Drawing.Size(25, 15);
            this.txt_PlayerHP.TabIndex = 3;
            this.txt_PlayerHP.Text = "100";
            // 
            // txt_PlayerStrength
            // 
            this.txt_PlayerStrength.AutoSize = true;
            this.txt_PlayerStrength.Location = new System.Drawing.Point(1090, 110);
            this.txt_PlayerStrength.Name = "txt_PlayerStrength";
            this.txt_PlayerStrength.Size = new System.Drawing.Size(19, 15);
            this.txt_PlayerStrength.TabIndex = 5;
            this.txt_PlayerStrength.Text = "16";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1002, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Srength:";
            // 
            // txt_PlayerDefense
            // 
            this.txt_PlayerDefense.AutoSize = true;
            this.txt_PlayerDefense.Location = new System.Drawing.Point(1090, 146);
            this.txt_PlayerDefense.Name = "txt_PlayerDefense";
            this.txt_PlayerDefense.Size = new System.Drawing.Size(19, 15);
            this.txt_PlayerDefense.TabIndex = 7;
            this.txt_PlayerDefense.Text = "16";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1002, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Defense:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Enemy:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(138, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Health:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(138, 148);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Srength:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(138, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "Defense:";
            // 
            // txt_EnemyDefense
            // 
            this.txt_EnemyDefense.AutoSize = true;
            this.txt_EnemyDefense.Location = new System.Drawing.Point(225, 190);
            this.txt_EnemyDefense.Name = "txt_EnemyDefense";
            this.txt_EnemyDefense.Size = new System.Drawing.Size(19, 15);
            this.txt_EnemyDefense.TabIndex = 15;
            this.txt_EnemyDefense.Text = "16";
            // 
            // txt_EnemyStrength
            // 
            this.txt_EnemyStrength.AutoSize = true;
            this.txt_EnemyStrength.Location = new System.Drawing.Point(225, 148);
            this.txt_EnemyStrength.Name = "txt_EnemyStrength";
            this.txt_EnemyStrength.Size = new System.Drawing.Size(19, 15);
            this.txt_EnemyStrength.TabIndex = 14;
            this.txt_EnemyStrength.Text = "16";
            // 
            // txt_EnemyHP
            // 
            this.txt_EnemyHP.AutoSize = true;
            this.txt_EnemyHP.Location = new System.Drawing.Point(219, 110);
            this.txt_EnemyHP.Name = "txt_EnemyHP";
            this.txt_EnemyHP.Size = new System.Drawing.Size(25, 15);
            this.txt_EnemyHP.TabIndex = 13;
            this.txt_EnemyHP.Text = "100";
            // 
            // txt_EnemyName
            // 
            this.txt_EnemyName.AutoSize = true;
            this.txt_EnemyName.Location = new System.Drawing.Point(219, 74);
            this.txt_EnemyName.Name = "txt_EnemyName";
            this.txt_EnemyName.Size = new System.Drawing.Size(26, 15);
            this.txt_EnemyName.TabIndex = 9;
            this.txt_EnemyName.Text = "Orc";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(520, 602);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 31);
            this.button2.TabIndex = 16;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 645);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_EnemyDefense);
            this.Controls.Add(this.txt_EnemyStrength);
            this.Controls.Add(this.txt_EnemyHP);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_EnemyName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_PlayerDefense);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_PlayerStrength);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_PlayerHP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MessagesText);
            this.Controls.Add(this.MessagesTitle);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Simple Windows Forms RPG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label MessagesTitle;
        private System.Windows.Forms.Label MessagesText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_PlayerHP;
        private System.Windows.Forms.Label txt_PlayerStrength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txt_PlayerDefense;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label txt_EnemyDefense;
        private System.Windows.Forms.Label txt_EnemyStrength;
        private System.Windows.Forms.Label txt_EnemyHP;
        private System.Windows.Forms.Label txt_EnemyName;
        private System.Windows.Forms.Button button2;
    }
}

