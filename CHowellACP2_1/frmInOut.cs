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
    public partial class frmInOut : Form
    {
        public frmInOut()
        {
            InitializeComponent();
        }

        StreamReader numbers = new StreamReader("numbers.txt");
        StreamWriter grades = new StreamWriter("grades.txt");
        double[] nums = new double[6];

        private void frmInOut_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = double.Parse(numbers.ReadLine());
                lbxDisplay.Items.Add(nums[i].ToString());
            }
        }

        double total = 0;
        double average = 0;

        private void btnGrades_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                grades.WriteLine("NG" + i + ": " + nums[i]);
                total += nums[i];
            }
            average = total / nums.Length;
            lbxDisplay.Items.Add(total);
            lbxDisplay.Items.Add(average);
            grades.WriteLine("Total: " + total);
            grades.WriteLine("Average: " + average);
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= 90)
                {
                    lbxDisplay.Items.Add("A");
                    grades.WriteLine("LG" + i + ": A");
                }
                else if (nums[i] >= 80 && nums[i] < 90)
                {
                    lbxDisplay.Items.Add("B");
                    grades.WriteLine("LG" + i + ": B");
                }
                else if (nums[i] >= 70 && nums[i] < 80)
                {
                    lbxDisplay.Items.Add("C");
                    grades.WriteLine("LG" + i + ": C");
                }
                else if (nums[i] >= 60 && nums[i] < 70)
                {
                    lbxDisplay.Items.Add("D");
                    grades.WriteLine("LG" + i + ": D");
                }
                else if (nums[i] < 60)
                {
                    lbxDisplay.Items.Add("F");
                    grades.WriteLine("LG" + i + ": F");
                }
            }
            grades.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
