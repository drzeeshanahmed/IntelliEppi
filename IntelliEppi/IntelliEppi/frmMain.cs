using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntelliEppi
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void trackerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                IntelliEppi.frmTracker objTracker = new IntelliEppi.frmTracker();
                objTracker.MdiParent = this;
                objTracker.Show();
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                //Splash code            
                frmSplash objSplash = new frmSplash();
                objSplash.MdiParent = this;
                objSplash.Show();

            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Splash code            
                frmSplash objSplash = new frmSplash();
                objSplash.MdiParent = this;
                objSplash.Show();
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void ecoderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                IntelliEppi.frmGenerator objGenerator = new IntelliEppi.frmGenerator();
                objGenerator.MdiParent = this;
                objGenerator.Show();
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }

        private void dataCenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                IntelliEppi.frmDataCenter objDataCenter = new IntelliEppi.frmDataCenter();
                objDataCenter.MdiParent = this;
                objDataCenter.Show();
            }
            catch (Exception objException)
            {
                MessageBox.Show(objException.Message);
            }
        }
    }
}
