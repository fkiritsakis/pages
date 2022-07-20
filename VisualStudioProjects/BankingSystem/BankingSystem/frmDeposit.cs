using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace BankingSystem
{
    public partial class frmDeposit : Form
    {

        //Top Bar Variable
        bool bMouseDown;
        Point pOffset;

        //Sql Variables
        SqlConnection sqlCon;
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;
        SqlDataAdapter sqlDataAdapter;

        //Local Variable
        string sUsername;
        float fBalance;

        public frmDeposit(string sUser, float fBal)
        {
            InitializeComponent();

            sUsername = sUser;
            fBalance = fBal;
        }

        private void frmDeposit_OnLoad(object sender, EventArgs e)
        {
            string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            sqlCon = new SqlConnection(CONNECTION_STRING);
            sqlCon.Open();
        }

        #region Top Bar

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Check if the mouse is down and get the point 
        private void pnlTopBar_MouseDown_Event(object sender, MouseEventArgs e)
        {
            pOffset.X = e.X;
            pOffset.Y = e.Y;
            bMouseDown = true;
        }

        //Update the location with the current possition and the offset
        private void pnlTopBar_MouseMove_Event(object sender, MouseEventArgs e)
        {
            if (bMouseDown == true)
            {
                Point pCurrentScreenPos = PointToScreen(e.Location);
                Location = new Point(pCurrentScreenPos.X - pOffset.X, pCurrentScreenPos.Y - pOffset.Y);
            }
        }

        //Fire when the mouse button is up
        private void pnlTopBar_MouseUp_Event(object sender, MouseEventArgs e)
        {
            bMouseDown = false;
        }



        #endregion

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            //If Text box is not empty
            if(txtDepositAmount.Text != String.Empty) 
            {
                //Try to see if the entered text can be converted to a float
                try 
                {
                    if (float.Parse(txtDepositAmount.Text) > 0) 
                    {
                        float fAmount = float.Parse(txtDepositAmount.Text);
                    
                        //Updating the amount in the account data table of the database
                        Deposit(fAmount);
                    }
                } //Conversion failed
                catch 
                {
                    //Informing the user with a message box and clearing the text box
                    MessageBox.Show("Invalid input. Please input numbers only inside the text field.");
                    txtDepositAmount.Text = "";
                }
            }
            else 
            {
                //The text field was empty, the user is informed
                MessageBox.Show("Please type the amount you desire to deposit in the text field.");
            }
        }

        private void Deposit(float fValue) 
        {
            //Add the amount the user wants to deposit, to the current Balance of their account
            fBalance += fValue;

            //Updating the column inside the database
            sqlCommand = new SqlCommand("UPDATE AccountData SET Balance='" + fBalance + "' WHERE Username='" + sUsername + "'", sqlCon);
        }
    }
}
