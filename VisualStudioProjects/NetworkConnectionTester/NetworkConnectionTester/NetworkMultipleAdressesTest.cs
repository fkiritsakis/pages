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

namespace NetworkConnectionTester
{
    public partial class NetworkMultipleAdressesTest : UserControl
    {
        public NetworkMultipleAdressesTest()
        {
            InitializeComponent();

            //Hiding the two invalid input messages
            lblStartInvalidInput.Visible = false;
            lblEndInvalidInput.Visible = false;
        }

        //Returns the text entered in the start ip text box as a string
        public string getStartIPText()
        {
            string sStartIp = txtStartAddress.Text;

            return sStartIp;
        }

        //Returns the text entered in the end ip text box as a string
        public string getEndIPText()
        {
            string sEndIp = txtEndAdress.Text;

            return sEndIp;
        }

        //Returns the start ip address text in the form of an ip address
        public IPAddress getStartIpAddress()
        {
            return IPAddress.Parse(txtStartAddress.Text);
        }

        //Returns the end ip address text in the form of an ip address
        public IPAddress getEndIpAddress()
        {
            return IPAddress.Parse(txtEndAdress.Text);
        }

        //Checks if the start ip text is a valid ip address
        public bool StartIsIp()
        {
            try
            {
                IPAddress ip = IPAddress.Parse(txtStartAddress.Text);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Checks if the end ip text is a valid ip address
        public bool EndIsIp()
        {
            try
            {
                IPAddress ip = IPAddress.Parse(txtEndAdress.Text);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Shows the lblStartInvalidInput
        public void showStartError()
        {
            lblStartInvalidInput.Visible = true;
        }

        //Hides the lblInvalidInput
        public void hideStartError()
        {
            lblStartInvalidInput.Visible = false;
        }

        //Shows the lblEndInvalidInput
        public void showEndError()
        {
            lblEndInvalidInput.Visible = true;
        }

        //Hides the lblInvalidInput
        public void hideEndError()
        {
            lblEndInvalidInput.Visible = false;
        }

        //Adds text to the big text box
        public void AppendText(String Text)
        {
            txtTextBox.AppendText(Text);
        }

        //Clear the contents of the textbox
        public void clearText()
        {
            txtTextBox.Clear();
        }
    }
}
