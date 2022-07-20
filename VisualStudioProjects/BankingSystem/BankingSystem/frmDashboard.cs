﻿using System;
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
    public partial class frmDashboard : Form
    {
        //Top Bar Variable
        bool bMouseDown;
        Point pOffset;

        //Program Variables
        bool bIsEmployee = false;
        bool   bIsAdmin = false;
        string sUsername;
        string sFirstName;
        string sLastName;
        float fBalance;
        string sRole;


        //Sql Variables
        SqlConnection sqlCon;
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;
        SqlDataAdapter sqlDataAdapter;


        public frmDashboard(string sUser)
        {
            InitializeComponent();

            //Getting the username from the passed arguement
            //It is not safe passing the username like this
            sUsername = sUser;
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            sqlCon = new SqlConnection(CONNECTION_STRING);
            sqlCon.Open();

            //Getting the data from the database and setting them to local variables
            sqlCommand = new SqlCommand("SELECT FirstName, LastName, Balance FROM AccountData WHERE Username= '" + sUsername + "'", sqlCon);
            sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read()) 
            {
                sFirstName = sqlDataReader.GetString(0);
                sLastName = sqlDataReader.GetString(1);
                fBalance = sqlDataReader.GetFloat(2);
            }
            sqlDataReader.Close();

            SqlCommand sqlAccounts1Cmd = new SqlCommand("SELECT isEmploy, isAdmin FROM Accounts WHERE Username='" + sUsername + "'" ,sqlCon);
            sqlDataReader = sqlAccounts1Cmd.ExecuteReader();
            while (sqlDataReader.Read()) 
            {
                int iIsEmployee = sqlDataReader.GetInt32(0);
                int iIsAdmin = sqlDataReader.GetInt32(1);

                if (iIsEmployee == 1)
                {
                    bIsEmployee = true;
                }

                if (iIsAdmin == 1)
                {
                    bIsAdmin = true;
                }
            }

            sqlDataReader.Close();

            sqlCon.Close();

            

            //Hidding the controls (buttons) before the form is loaded
            //Client sees only the first row of buttons
            if(!bIsEmployee && !bIsAdmin) 
            {
                btnCreateClientAccount.Visible = false;
                btnViewClientAccount.Visible = false;
                btnCreateEmployeeAccount.Visible = false;
                btnViewEmployeeAccount.Visible = false;
                sRole = "Client";
            }else if(bIsEmployee && !bIsAdmin)  //Employee can see first and second row of buttons
            {
                btnCreateEmployeeAccount.Visible = false;
                btnViewEmployeeAccount.Visible = false;
                sRole = "Employee";
            }
            else                                //Admin can see all buttons so no hidding of controls
            {
                sRole = "Administrator";
            }


        }


        #region Top Bar
        //Close Button Pressed
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close the application
            Application.Exit();
        }

        //Minimizes the window
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        

        //Gets the possition of the mouse the second that the mouse button is clicked
        private void pnlTopBar_MouseDown_Event(object sender, MouseEventArgs e)
        {
            pOffset.X = e.X;
            pOffset.Y = e.Y;
            bMouseDown = true;
        }

        //Fires when it detects the mouse moves while inside the panel and if the mouse is clicked (MouseDown) updates the location of the window to the
        //Current position of the mouse
        private void pnlTopBar_MouseMove_Event(object sender, MouseEventArgs e)
        {
            if (bMouseDown == true)
            {
                Point pCurrentScreenPos = PointToScreen(e.Location);
                Location = new Point(pCurrentScreenPos.X - pOffset.X, pCurrentScreenPos.Y - pOffset.Y);
            }
        }

        //Fires when the mouse button is lifted
        private void pnlTopBar_MouseUp_Event(object sender, MouseEventArgs e)
        {
            bMouseDown = false;
        }

        #endregion

        #region General Controls

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            //Create and show frmDeposit
            frmDeposit frmDeposit = new frmDeposit(sUsername, fBalance);
            frmDeposit.Show();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            //Create And Show frmWithdraw
            frmWithdraw frmWithdraw = new frmWithdraw(sUsername, fBalance);
            frmWithdraw.Show();
        }

        private void btnCheckBalance_Click(object sender, EventArgs e)
        {
            //Show a message box displaying the ballance of the current user
            MessageBox.Show("Your balance is: £" + fBalance);

            //Create a form that displayes the ballance and add a button that shows
            //the transactions made by this account

        }

        private void btnAccountDetails_Click(object sender, EventArgs e)
        {
            //Show A messagebox with the details of the account that is currently logged in
            MessageBox.Show("Your Account Details. \n First Name: " + sFirstName + "\n Last Name: " + sLastName + " \n Role: " + sRole + " \n Ballance: £" + fBalance);
        }

        private void btnCreateClientAccount_Click(object sender, EventArgs e)
        {
            //Opens a new Client account creation form
            //This might seem wrong but the "Create Account" in the starting form should be removed
            //in later versions, so that only employees and the administrator can create accounts for clients and employees (Admin-only)
            frmAccountCreation frmAccountCreation = new frmAccountCreation();
        }

        private void btnViewClientAccount_Click(object sender, EventArgs e)
        {
            //TBD Create a form so that the user can input a first name and/or the last name
            //And view a list of clients with these credentials and their account information
            //Two buttons should be visible, one to "Save"/"Update" and one to delete an account
            //Confirmation with Yes/No should also be present for the Delete option
        }

        

        #endregion

        private void pnlDeposit_Paint(object sender, PaintEventArgs e)
        {

        }

        #region Mouse Hover
        private void pnlDeposit_MouseHover(object sender, EventArgs e)
        {
            //TBD Add Tooltips for all options when mouse hover
        }






        #endregion

        
    }
}
