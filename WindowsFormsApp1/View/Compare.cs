using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Compare : Form
    {
        public Compare()
        {
            InitializeComponent();
        }

        private void daycomparebtn_Click(object sender, EventArgs e)
        {
            DayCompare showForm2 = new DayCompare();
            showForm2.ShowDialog();
        }

        private void monthcomparebtn_Click(object sender, EventArgs e)
        {
            MonthCompare showForm3 = new MonthCompare();
            showForm3.ShowDialog();
        }

        private void categorycomparebtn_Click(object sender, EventArgs e)
        {
            CategoryCompare showForm1 = new CategoryCompare();
            showForm1.ShowDialog();
        }
    }
}
