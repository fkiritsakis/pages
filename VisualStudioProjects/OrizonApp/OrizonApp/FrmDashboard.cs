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
    public partial class FrmDashboard : Form
    {

        //Reference to FrmLogin
        public FrmLogin refToFrmLogin { get; set; }

        public FrmDashboard()
        {
            InitializeComponent();

            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //Showing the login form and closing the dashboard
            this.refToFrmLogin.Show();
            this.Close();
        }
    }
}
