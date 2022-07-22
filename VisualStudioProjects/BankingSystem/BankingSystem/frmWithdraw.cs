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
    public partial class frmWithdraw : Form
    {

        //Top Bar Variable
        bool bMouseDown;
        Point pOffset;

        //Sql Variables
        SqlConnection sqlCon;
        SqlCommand sqlCommand;
        SqlTransaction sqlTransaction;

        //Local Variables
        string sUsername;
        decimal dBalance;
        string sFirstName;
        string sLastName;

        public frmWithdraw(string sUser, decimal dBal, string sFName, string sLName)
        {
            InitializeComponent();

            sUsername = sUser;
            dBalance = dBal;
            sFirstName = sFName;
            sLastName = sLName;


            lblBalance.Text = "£ " + dBalance.ToString();
        }

        private void frmWithdraw_OnLoad(object sender, EventArgs e)
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
            if (numWithdrawAmount.Value != 0)
            {


                decimal dAmount = numWithdrawAmount.Value;
                //debug
                MessageBox.Show("Amount Entered: " + dAmount);

                if (dBalance - dAmount > 0)
                {
                    Withdraw(dAmount);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("The Amount of money that you want to withdraw is greater than the money available in your Account." +
                                    "\nPlease enter a valid amount.");
                    numWithdrawAmount.Value = 0;
                }
            }
            else
            {
                //The text field was empty, the user is informed
                MessageBox.Show("Please type the amount you desire to deposit in the text field.");
            }
        }


        private void Withdraw(decimal dValue)
        {
            //Add the amount the user wants to deposit, to the current Balance of their account
            dBalance -= dValue;

            //Updating the Balance
            SqlCommand sqlUpdateBalanceCommand = new SqlCommand("UPDATE AccountData SET Balance= @Value WHERE Username='" + sUsername + "'", sqlCon);
            sqlUpdateBalanceCommand.Parameters.Add(new SqlParameter("@Value", SqlDbType.Decimal)
            {
                Precision = 10,
                Scale = 2
            }).Value = dBalance;
            sqlUpdateBalanceCommand.ExecuteNonQuery();

            //Create a new command and insert data in the Transactions Table
            SqlCommand sqlInsertTransaction = new SqlCommand("INSERT INTO Transactions (FirstName, LastName, Action, Amount, Username) VALUES ('" + sFirstName + "','" + sLastName + "','Deposit', @Amount ,'" + sUsername + "')", sqlCon);
            sqlInsertTransaction.Parameters.Add(new SqlParameter("@Amount", SqlDbType.Decimal)
            {
                Precision = 10,
                Scale = 2
            }).Value = dValue;
            sqlInsertTransaction.ExecuteNonQuery();
        }
    }
}
