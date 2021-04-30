using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CHowellACP2_1
{
    public partial class frmMouser : Form
    {
        public frmMouser()
        {
            InitializeComponent();
        }

        int x = 0;
        int y = 0;

        private void Mouse_Click(object sender, MouseEventArgs e)
        {
            if (e.X == 250 && e.Y == 250)
            {
                MessageBox.Show("Awesome Job!");
            }
            x = e.X;
            y = e.Y;
        }

        private void btnMouse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coordinates: " + x + ", " + y);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
