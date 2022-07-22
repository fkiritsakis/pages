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
using System.IO;

namespace BankingSystem
{
    public partial class frmCheckBalance : Form
    {
        //Sql Variables
        SqlConnection sqlCon;

        //Variables
        string sUsername;
        decimal dBalance;

        string sFirstName;
        string sLastName;

        public frmCheckBalance(string sUser, decimal dBal)
        {
            InitializeComponent();

            sUsername = sUser;
            dBalance = dBal;

            lblBalance.Text = "£" + dBalance;

        }

        private void frmCheckBalance_OnLoad(object sender, EventArgs e)
        {
            string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            sqlCon = new SqlConnection(CONNECTION_STRING);
            sqlCon.Open();


            //Get the transactions from the transaction table
            SqlCommand sqlSelectTransCmd = new SqlCommand("SELECT id, Action, Amount FROM Transactions WHERE Username ='" + sUsername + "'", sqlCon);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlSelectTransCmd);

            DataTable dtTransRecord = new DataTable();
            sqlDataAdapter.Fill(dtTransRecord);
            dgTransactions.DataSource = dtTransRecord;

            SqlCommand sqlSelectAccCmd = new SqlCommand("SELECT FirstName, LastName FROM AccountData WHERE Username = '" + sUsername + "'", sqlCon);
            SqlDataReader sqlDataReader = sqlSelectAccCmd.ExecuteReader();
            if (sqlDataReader.Read()) 
            {
                sFirstName = sqlDataReader.GetString(0);
                sLastName = sqlDataReader.GetString(1);
            }
            sqlDataReader.Close();

        }

        private void btnSaveTransactions_Click(object sender, EventArgs e)
        {
            string sTransID;
            string sTransAction;
            string sTransAmount;
            

            //Write the data to a file
            string sPathToEXE = Path.GetDirectoryName(Application.ExecutablePath);
            string sFileName = String.Format("Transaction History of {0} {1} up to {2:yyyy-MM-dd}", sFirstName, sLastName, DateTime.Now);

            string sFilePath = Path.Combine(sPathToEXE, sFileName);

            //Checking if the file exists
            if (!File.Exists(sFilePath))
            {

                //Get the transactions from the transaction table
                SqlCommand sqlSelectTransCmd = new SqlCommand("SELECT id, Action, Amount FROM Transactions WHERE Username ='" + sUsername + "'", sqlCon);
                //Put the following code in a while sqlDataReader.Read 
                SqlDataReader sqlDReader = sqlSelectTransCmd.ExecuteReader();
                while (sqlDReader.Read())
                {
                    //Setting the variable data from the data reader
                    sTransID = sqlDReader.GetInt32(0).ToString();
                    sTransAction = sqlDReader.GetString(1);
                    sTransAmount = sqlDReader.GetDecimal(2).ToString();

                    if (!File.Exists(sFilePath)) 
                    {
                        //Writing the the file
                        using (StreamWriter swStreamWriter = File.CreateText(sFilePath))
                        {
                            swStreamWriter.WriteLine("Transaction ID: " + sTransID + " | Action: " + sTransAction + " | Amount: £" + sTransAmount);
                            swStreamWriter.WriteLine("\n");
                            swStreamWriter.Flush();
                        }
                    }
                    else if (File.Exists(sFilePath)) 
                    {
                        using (StreamWriter swStreamWriter = File.AppendText(sFilePath)) 
                        {
                            swStreamWriter.WriteLine("Transaction ID: " + sTransID + " | Action: " + sTransAction + " | Amount: £" + sTransAmount);
                            swStreamWriter.WriteLine("\n");
                            swStreamWriter.Flush();
                        }
                    }
                    
                }

                sqlDReader.Close();
            }
            else if (File.Exists(sFilePath))
            {
                //Get the transactions from the transaction table
                SqlCommand sqlSelectTransCmd = new SqlCommand("SELECT id, Action, Amount FROM Transactions WHERE Username ='" + sUsername + "'", sqlCon);
                //Put the following code in a while sqlDataReader.Read 
                SqlDataReader sqlDReader = sqlSelectTransCmd.ExecuteReader();
                while (sqlDReader.Read())
                {
                    //Setting the variable data from the data reader
                    sTransID = sqlDReader.GetInt32(0).ToString();
                    sTransAction = sqlDReader.GetString(1);
                    sTransAmount = sqlDReader.GetDecimal(2).ToString();

                    //Writing the the file
                    using (StreamWriter swStreamWriter = File.AppendText(sFilePath))
                    {
                        swStreamWriter.WriteLine("Transaction ID: " + sTransID + " | Action: " + sTransAction + " | Amount: £" + sTransAmount);
                        swStreamWriter.WriteLine("\n");
                        swStreamWriter.Flush();
                    }
                }

                sqlDReader.Close();
            }

            
            
        }

        
    }
}
