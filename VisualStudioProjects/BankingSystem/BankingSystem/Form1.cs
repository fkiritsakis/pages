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

namespace BankingSystem
{
    public partial class frmLogin : Form
    {

        //Window Dragging variables
        bool bMouseDown;
        Point pOffset;

        //Database Variables
        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        SqlDataReader sqlDReader;

        //Creating a public constant for the connection string
        public const string CONNECTION_STRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fotis\OneDrive\Documents\GitHub\pages\VisualStudioProjects\BankingSystem\BankingSystem\BankDB.mdf;Integrated Security=True;Connect Timeout=30";
        public frmLogin()
        {
            InitializeComponent();
        }

        //Method to run Upon frmLogin loading
        private void frmLogin_Load(object sender, EventArgs e)
        {
            //Loading the Connection String
            sqlCon = new SqlConnection(CONNECTION_STRING);
            sqlCon.Open();
            MessageBox.Show("Connection to Bank Database Successful and Open!");
        }

        #region Top Bar Controls

        //Close Button Pressed
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close the application
            Application.Exit();
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
            if(bMouseDown == true) 
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

        //Minimizes the window
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion

        #region Bottom Buttons
        //Check if the username exists in the database
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login() 
        {
            //Check if the two textboxes are not empty
            if (txtUsername.Text != String.Empty && txtPassword.Text != String.Empty)
            {
                sqlCmd = new SqlCommand("SELECT * FROM Accounts WHERE Username='" + txtUsername.Text + "' AND Password='" + txtPassword.Text + "'", sqlCon);
                sqlDReader = sqlCmd.ExecuteReader();
                //If the reader reads somthing with these data the code will execute
                if (sqlDReader.Read())
                {
                    sqlDReader.Close();
                    MessageBox.Show("Successful Login");
                    frmDashboard dashboard = new frmDashboard(txtUsername.Text);
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    sqlDReader.Close();
                    lblWrongData.Visible = true;
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                }
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            frmAccountCreation frmAccountCreation = new frmAccountCreation();
            frmAccountCreation.Show();
        }


        #endregion

        //OnKeyDown to detect key events that might be usefull for later
        //Both not working as intended as of now
        //TBD Fix so that the close button is not focused on open so that pressing enter closes the program
        //TBD txtPassword_OnKeyDown troubleshoot so that it works as intended

        private void frmLogin_OnKeyDown(object sender, KeyEventArgs e)
        {
            //Run the Login method when the Enter key is pressed
            if (ModifierKeys == Keys.Enter) 
            {
                Login();
            }
        }

        private void txtPassword_OnKeyDown(object sender, KeyEventArgs e)
        {
            //Run the login method when the Enter key is pressed
            if(ModifierKeys == Keys.Enter)
            {
                Login();
            }
        }

        
    }
}
