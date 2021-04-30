using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHowellACP2_1
{
    public partial class frmMain : Form
    {
        LinkedList<string> list = new LinkedList<string>();

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbxDisplay.Items.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            list.AddLast(tbxInput.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (string n in list)
            {
                if (n == tbxInput.Text)
                {
                    found = true;
                    list.Remove(n);
                    break;
                }
            }
            if (found == false)
            {
                MessageBox.Show("Item not found!");
            }
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            bool found = false;
            foreach (string n in list)
            {
                if (n == tbxInput.Text)
                {
                    found = true;
                }
            }
            if (found == true)
            {
                MessageBox.Show("Item found!");
            }
            else if (found == false)
            {
                MessageBox.Show("Item not found!");
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            foreach (string n in list)
            {
                lbxDisplay.Items.Add(n);
            }
        }

        private void mnuInOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmInOut().ShowDialog();
            this.Show();
        }

        private void mnuMouser_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmMouser().ShowDialog();
            this.Show();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmAbout().ShowDialog();
            this.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
