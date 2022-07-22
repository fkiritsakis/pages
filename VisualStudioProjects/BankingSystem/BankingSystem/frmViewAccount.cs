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
    public partial class frmViewAccounts : Form
    {
        //Sql Variables
        SqlConnection sqlCon;

        //Variables
        string sUsername;
        decimal dBalance;
        int iCallerIsAdmin;

        string sSelFName;
        string sSelLName;
        string sSelBalance;
        string sSelUsername;
        string sSelPassword;
        decimal dSelBalance;

        public frmViewAccounts(string sUser, decimal dBal, int iCallerIsAdm)
        {
            InitializeComponent();

            sUsername = sUser;
            dBalance = dBal;
            iCallerIsAdmin = iCallerIsAdm;

        }

        private void frmCheckBalance_OnLoad(object sender, EventArgs e)
        {
            string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            sqlCon = new SqlConnection(CONNECTION_STRING);
            sqlCon.Open();

            UpdateDataGrid();
        }

        //This Updates the data displayed in the datagrid
        void UpdateDataGrid() 
        {
            if (iCallerIsAdmin == 1)
            {
                //Get Data
                SqlCommand sqlSelectEmpCmd = new SqlCommand("SELECT FirstName, LastName, Balance, Username FROM AccountData WHERE isEmployee = '1'", sqlCon);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlSelectEmpCmd);

                DataTable dtTransRecord = new DataTable();
                sqlDataAdapter.Fill(dtTransRecord);
                dgTransactions.DataSource = dtTransRecord;
            }
            else
            {
                //Get Data
                SqlCommand sqlSelectClientCmd = new SqlCommand("SELECT FirstName, LastName, Balance, Username FROM AccountData WHERE isEmployee = '0'", sqlCon);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlSelectClientCmd);

                DataTable dtTransRecord = new DataTable();
                sqlDataAdapter.Fill(dtTransRecord);
                dgTransactions.DataSource = dtTransRecord;
            }
        }


        //This is for btnRemove
        private void btnSaveTransactions_Click(object sender, EventArgs e)
        {
            //TBD Remove the selected row of the list after confirmation
            SqlCommand sqlDeleteFromAccData = new SqlCommand("DELETE FROM AccountData WHERE Username = '"+ sSelUsername +"'", sqlCon);
            SqlCommand sqlDeleteFromAccounts = new SqlCommand("DELETE FROM Accounts WHERE Username = '" + sSelUsername + "'", sqlCon);

            sqlDeleteFromAccData.ExecuteNonQuery();
            sqlDeleteFromAccounts.ExecuteNonQuery();

            //Updating the data grid
            UpdateDataGrid();

            //Empty the textfields and the saved stringswhen the button is pressed
            txtFirstName.Text = String.Empty;
            txtLastName.Text = String.Empty;
            txtBalance.Text = String.Empty;
            txtUsername.Text = String.Empty;
            txtPassword.Text = String.Empty;

            sSelFName = String.Empty;
            sSelLName = String.Empty;
            sSelBalance = String.Empty;
            sSelUsername = String.Empty;
            sSelPassword = String.Empty;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //TBD Show a form to update the data of the selected account from the list
            if(txtFirstName.Text != String.Empty && txtLastName.Text != String.Empty && txtUsername.Text != String.Empty) 
            {
                //Update AccountData table
                SqlCommand sqlUpdateAccData = new SqlCommand("UPDATE AccountData SET FirstName = '" + txtFirstName.Text + "', LastName = '" + txtLastName.Text + "', Username = '" + txtUsername.Text + "' WHERE Username = '" + sSelUsername + "'", sqlCon);
                sqlUpdateAccData.ExecuteNonQuery();

                //Also Update the Accounts Table with the current username
                SqlCommand SqlUpdateAcc = new SqlCommand("UPDATE Accounts SET Username = '" + txtUsername.Text + "'", sqlCon);

                //Updating the internal string for the selected username
                sSelUsername = txtUsername.Text;

                //Updating the data grid
                UpdateDataGrid();
            }
            else 
            {
                MessageBox.Show("Please fill all the field and the press Update.");

                //Resetting the text fields
                txtFirstName.Text = sSelFName;
                txtLastName.Text = sSelLName;
                txtUsername.Text = sSelUsername;
            }
            
        }

        

        //Getting the Selected row and displaying the data to the text fields
        private void dgTransactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgTransactions.SelectedRows.Count > 0) 
            {
                //Setting the strings using data from the coresponding cells
                sSelFName = dgTransactions.SelectedRows[0].Cells[0].Value + String.Empty;
                sSelLName = dgTransactions.SelectedRows[0].Cells[1].Value + String.Empty;
                sSelBalance = dgTransactions.SelectedRows[0].Cells[2].Value + String.Empty;;
                sSelUsername = dgTransactions.SelectedRows[0].Cells[3].Value + String.Empty;

                //Displaying the strings in the text boxes
                txtFirstName.Text = sSelFName;
                txtLastName.Text = sSelLName;
                txtBalance.Text = sSelBalance;
                txtUsername.Text = sSelUsername;
            }
        }

        private void btnGetPassword_Click(object sender, EventArgs e)
        {
            //Checking if the Selected Username is empty
            if(sSelUsername != String.Empty) 
            {
                //Getting the password from Accounts database using the given username
                SqlCommand sqlGetSelectedPassCmd = new SqlCommand("SELECT Password FROM Accounts WHERE Username = '" + sSelUsername + "'", sqlCon);
                SqlDataReader sqlDReader = sqlGetSelectedPassCmd.ExecuteReader();
                if (sqlDReader.Read()) 
                {
                    
                    //Setting the String
                    sSelPassword = sqlDReader.GetString(0);

                    //Closing the Reader
                    sqlDReader.Close();

                    //Display the Password in the text field
                    txtPassword.Text = sSelPassword;
                }
            }
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            //Checking if the text field is empty
            if(txtPassword.Text != String.Empty) 
            {
                //Updating the password of the username that is currently selected
                SqlCommand sqlUpdatePassCmd = new SqlCommand("UPDATE Accounts SET Password = '" + txtPassword.Text + "' WHERE Username = '" + sSelUsername + "'", sqlCon);
                sqlUpdatePassCmd.ExecuteNonQuery();


                //Updating the data grid after the update is done
                UpdateDataGrid();
            }
            else 
            {
                MessageBox.Show("The field is empty, Please insert the new password");

                //Resetting the text fields
                txtFirstName.Text = sSelFName;
                txtLastName.Text = sSelLName;
                txtUsername.Text = sSelUsername;
            }
            
        }

        #region Unused 
        private void dgTransactions_OnRowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
