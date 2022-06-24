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
    public partial class NetworkSingleAddressTest : UserControl
    {
        public NetworkSingleAddressTest()
        {
            InitializeComponent();
            lblInvalidInput.Visible = false;
        }

        //Returns the text entered in the txtBox
        public string getIPText() 
        {
            string sIp = txtAddress.Text;

            return sIp;
        }

        public IPAddress getSingleIpAddress() 
        {
            return IPAddress.Parse(txtAddress.Text);
        }

        //Checks if the entered text is a valid ip address
        public bool isIp() 
        {
            try 
            {
                IPAddress ip  = IPAddress.Parse(txtAddress.Text);
                return true;
            }
            catch (Exception ex) 
            {
                return false;
            }
        }

        //Shows the lblInvalidInput
        public void showError() 
        {
            lblInvalidInput.Visible =true;
        }

        //Hides the lblInvalidInput
        public void hideError() 
        {
            lblInvalidInput.Visible = false;
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
