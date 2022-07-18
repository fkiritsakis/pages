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
    public partial class frmDashboard : Form
    {
        //Top Bar Variable
        bool bMouseDown;
        Point pOffset;

        //Sql Variables
        SqlConnection sqlCon;
        SqlCommand sqlCommand;
        SqlDataReader sqlDataReader;
        SqlDataAdapter sqlDataAdapter;


        public frmDashboard()
        {
            InitializeComponent();

            //TBD Add the panels for each action the user can take and make 
            //them visible according to their clearend
            //Admin should have everything visible Create employee+client Account, Deposit, Withdraw, View/Print, Change Employee+Client Data
            //Employee should have most visible Deposit, Withdraw, View/Print, Change Client Data
            //Client should only have Deposit, Withdraw and View/Print available
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(frmLogin.CONNECTION_STRING);
            sqlCon.Open();
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

        #endregion

    }
}
