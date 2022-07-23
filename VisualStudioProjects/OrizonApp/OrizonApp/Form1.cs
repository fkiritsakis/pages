using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrizonApp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Creating a new dashboard form
            FrmDashboard frmDashboard = new FrmDashboard();
            //Setting the reference to the login form in the newly created dashboard form
            frmDashboard.refToFrmLogin = this;
            //Hiding this form
            this.Visible = false;
            //Showing the dashboard
            frmDashboard.Show();
        }
    }
}
