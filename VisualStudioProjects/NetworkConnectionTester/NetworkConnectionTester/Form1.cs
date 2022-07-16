using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;

namespace NetworkConnectionTester
{
    public partial class Form1 : Form
    {
        //Top Bar Variables
        bool bMouseDown = false;
        Point pOffset;

        //Pinging variables
        Ping pPing;
        PingReply prPingReply;


        public Form1()
        {
            InitializeComponent();

            //Hiding User Controls on program startup
            ntwSingleAddressTest.Visible = false;
            ntwMutlipleAdressTest.Visible = false;

            //Disabling the buttons on startup
            btnTest.Enabled = false;
            btnClose.Enabled = false;

        }

        #region Top Bar

        //Close the Application when button clicked
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Minimize the Application when button clicked
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Move top Bar
        private void topBarMouseDown_Event(object sender, MouseEventArgs e)
        {
            bMouseDown = true;
            pOffset.X = e.X;
            pOffset.Y = e.Y;
        }

        private void topBarMouseMove_Event(object sender, MouseEventArgs e)
        {
            if (bMouseDown) 
            {
                Point pCurrent = PointToScreen(e.Location);
                Location = new Point(pCurrent.X - pOffset.X, pCurrent.Y - pOffset.Y);
            }
        }

        private void topBarMouseUp_Event(object sender, MouseEventArgs e)
        {
            bMouseDown = false;
        }

        //Maximize Window on double click
        private void topBarDoubleClick_Event(object sender, MouseEventArgs e)
        {
            Point pLocationWhenNormal = new Point( 0, 0);
            if (this.WindowState != FormWindowState.Maximized) 
            {
                this.WindowState = FormWindowState.Maximized;
                pLocationWhenNormal = new Point(Location.X, Location.Y);
            }
            else 
            {
                this.WindowState = FormWindowState.Normal;
                Location = new Point(pLocationWhenNormal.X, pLocationWhenNormal.Y);
            }
        }

        #endregion

        private void btnDebug_Click(object sender, EventArgs e)
        {
            
        }

        #region Tab Buttons
        private void btnSingleAddressTab_Click(object sender, EventArgs e)
        {
            //Making the control visible
            ntwSingleAddressTest.Visible = true;
            
            //Hiding all other controls
            ntwMutlipleAdressTest.Visible = false;
            
            //Enabling the buttons
            btnTest.Enabled = true;
            btnClose.Enabled = true;

            //Making sure the text box is clear
            ntwSingleAddressTest.clearText();
        }

        private void btnRangeAdressTab_Click(object sender, EventArgs e)
        {
            //Making the Control Visible
            ntwMutlipleAdressTest.Visible = true;

            //Hiding all other controls
            ntwSingleAddressTest.Visible = false;

            //Enabling the buttons
            btnTest.Enabled = true;
            btnClose.Enabled = true;
        }


        #endregion

        #region Bottom Buttons
        private void btnClose_Click(object sender, EventArgs e)
        {
            if(ntwSingleAddressTest.Visible == true) 
            {
                //Hiding the control
                ntwSingleAddressTest.Visible = false;

                //Disabling the buttons
                btnClose.Enabled = false;
                btnTest.Enabled = false;
            }

            if(ntwMutlipleAdressTest.Visible == true) 
            {
                //Hiding the control
                ntwMutlipleAdressTest.Visible = false;

                //Disabling the buttons
                btnClose.Enabled = false;
                btnTest.Enabled = false;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if(ntwSingleAddressTest.Visible == true) 
            {
                TestSingleAddress();
            }else if(ntwMutlipleAdressTest.Visible == true) 
            {
                TestMultipleAddress();
            }
        }
        #endregion


        #region Methods

        public void TestSingleAddress() 
        {
            string sSingleIp = ntwSingleAddressTest.getIPText();

            //Hide the error message every time the button is pressed as it checks a different address
            ntwSingleAddressTest.hideError();

            //If the entered text is an ip
            if (ntwSingleAddressTest.isIp())
            {
                IPAddress ipSingleIpAddress = ntwSingleAddressTest.getSingleIpAddress();

                //Showing the user that the proccess has started
                string sStringToAppend = "Pinging...";
                ntwSingleAddressTest.AppendText(Environment.NewLine + sStringToAppend);

                //Starting the ping
                pPing = new Ping();
                try 
                {
                    prPingReply = pPing.Send(ipSingleIpAddress);

                    if (prPingReply.Status == IPStatus.Success)
                    {
                        //The ip was reached and has replied to the ping
                        sStringToAppend = "\nPing to " + ipSingleIpAddress.ToString() + " was succesful. " +
                            "\nResponse delay = " + prPingReply.RoundtripTime.ToString();
                        ntwSingleAddressTest.AppendText(Environment.NewLine + sStringToAppend);
                    }
                    else
                    {
                        //The Ip has not replied to the ping
                        sStringToAppend = "\n" + ipSingleIpAddress.ToString() + " is currently Unreachable.";
                        ntwSingleAddressTest.AppendText(Environment.NewLine + sStringToAppend);
                    }

                }
                catch (PingException e) 
                {
                    ntwSingleAddressTest.showError();
                    sStringToAppend = "Something went wrong";
                    ntwSingleAddressTest.AppendText(Environment.NewLine + sStringToAppend);
                }
            }
            else
            {
                //Show the error message when the program detects that the entered text
                //is not a valid IP address
                ntwSingleAddressTest.showError();
            }
        }

        public void TestMultipleAddress() 
        {
            //Hide the error mesages every timet he button is pressed
            ntwMutlipleAdressTest.hideStartError();
            ntwMutlipleAdressTest.hideStartError();

            //If both entered addresses are valid ip addresses
            if(ntwMutlipleAdressTest.StartIsIp() && ntwMutlipleAdressTest.EndIsIp()) 
            {
                IPAddress ipStartIpAddress = ntwMutlipleAdressTest.getStartIpAddress();
                IPAddress ipEndIpAddress = ntwMutlipleAdressTest.getEndIpAddress();

                //Showing the user that the proccess has started
                string sStringToAppend = "Pinging...";
                ntwMutlipleAdressTest.AppendText(Environment.NewLine + sStringToAppend);

                //Start the pinging
                //TBD Create a for loop that will ping each address between the start and
                //the end ip addresses
                //The ping shold be =new Ping() for each single address we are testing
            }
            else if (!ntwMutlipleAdressTest.StartIsIp()) 
            {
                //Shows error if it detects the start ip is not a valid ip address
                ntwMutlipleAdressTest.showStartError();
            }
            else if (!ntwMutlipleAdressTest.EndIsIp()) 
            {
                //Shows error if it detects the end ip is not a valid ip address
                ntwMutlipleAdressTest.showEndError();
            }
            else 
            {
                //Shows both error messages for both text fields
                ntwMutlipleAdressTest.showStartError();
                ntwMutlipleAdressTest.showEndError();
            }
        }

        #endregion

        private void ntwSingleAddressTest_Load(object sender, EventArgs e)
        {

        }

        
    }
}
