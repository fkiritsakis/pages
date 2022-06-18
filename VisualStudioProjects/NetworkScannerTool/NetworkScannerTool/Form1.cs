using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkScannerTool
{
    public partial class frmMain : Form
    {

        //Window Dragging variables
        bool BMouseDown;
        Point pOffset;

        public frmMain()
        {
            InitializeComponent();
        }


        #region Top Bar
        private void topBarMouseDown_Event(object sender, MouseEventArgs e)
        {
            pOffset.X = e.X;
            pOffset.Y = e.Y;
            BMouseDown = true;
        }

        private void topBarMouseMove_Event(object sender, MouseEventArgs e)
        {
            if (BMouseDown == true)
            {
                Point pCurrentScreenPos = PointToScreen(e.Location);
                Location = new Point(pCurrentScreenPos.X - pOffset.X, pCurrentScreenPos.Y - pOffset.Y);
            }
        }

        private void topBarMouseUp_Event(object sender, MouseEventArgs e)
        {
            BMouseDown = false;
        }
        #endregion


        #region Exit Button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
