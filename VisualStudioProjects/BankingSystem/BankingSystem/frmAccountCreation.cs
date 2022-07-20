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
    public partial class frmAccountCreation : Form
    {

        //Window Dragging variables
        bool bMouseDown;
        Point pOffset;

        //Database Variables
        SqlConnection sqlCon;
        SqlDataReader sqlDReader;

        public frmAccountCreation()
        {
            InitializeComponent();
        }

        private void frmAccountCreation_Load(object sender, EventArgs e)
        {
            string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            sqlCon = new SqlConnection();
            sqlCon.Open();
            
        }

        #region Top Bar Controls

        //Close Button Pressed
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close Window When Clicked
            this.Close();
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

        //Minimizes the window
        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }





        #endregion

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            sqlCon = new SqlConnection(CONNECTION_STRING);
            sqlCon.Open();

            if (txtUsername.Text != String.Empty && txtPassword.Text != String.Empty && txtConfirmPassword.Text != String.Empty && txtFirstName.Text != String.Empty && txtLastName.Text != String.Empty)
            {
                if (txtPassword.Text.Equals(txtConfirmPassword.Text))
                {
                    //Making sure the username and password are unique
                    SqlCommand sqlSelectAccountsCmd = new SqlCommand("SELECT * FROM Accounts WHERE Username='" + txtUsername.Text + "' OR Password='" + txtPassword.Text + "'", sqlCon);
                    sqlDReader = sqlSelectAccountsCmd.ExecuteReader();
                    //If the reader reads something it means that there is already an entry in the table with those 
                    if (sqlDReader.Read())
                    {
                        sqlDReader.Close();
                        MessageBox.Show("Username and/or Password already exist, Please change them and try again");
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                        txtConfirmPassword.Text = "";
                    }
                    else
                    {
                        sqlDReader.Close();
                        //Inserting the data into the Accounts Table after making sure that they are unique
                        SqlCommand sqlAccountsCmd = new SqlCommand("INSERT INTO Accounts (Username, Password, isEmploy, isAdmin) VALUES ('" + txtUsername.Text + "','" + txtPassword.Text + "', '0', '0')", sqlCon);
                        SqlCommand sqlAccountDataCmd = new SqlCommand("INSERT INTO AccountData (Username, FirstName, LastName, Balance) VALUES ( '"+ txtUsername.Text +"' ,'" + txtFirstName.Text + "','" + txtLastName.Text + "','0')", sqlCon);
                        sqlAccountsCmd.ExecuteNonQuery();
                        sqlAccountDataCmd.ExecuteNonQuery();

                        //Informing the user that the account has been created
                        MessageBox.Show("Your account has been created, please login now.");
                    }

                }
            }
            else
            {
                MessageBox.Show("Please Fill all the fields");
            }

            sqlCon.Close();
        }
    }
}
