using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CHowellACP2_1
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            bkgWorker.WorkerReportsProgress = true;
            bkgWorker.RunWorkerAsync();
        }

        private void bkgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= 100; i++)
            {
                Thread.Sleep(50);
                bkgWorker.ReportProgress(i);
            }
        }

        private void bkgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            pgrBar.Value = e.ProgressPercentage;
            lblProgress.Text = "Progress: " + e.ProgressPercentage.ToString() + "%";
            if (pgrBar.Value >= 100)
            {
                new frmMain().Show();
                this.Hide();
            }
        }
    }
}
