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
    public partial class MonthCompare : Form
    {
        public MonthCompare()
        {
            InitializeComponent();


        }

        private void MonthCompare_Load(object sender, EventArgs e)
        {
            
            userChart.Series["Series1"].Points.Clear();
            for (int i = 0; i < 12; i++)
            {
                int money = PrimaryOperation.UserMonthlySum(i + 1);
                userChart.Series["Series1"].Points.AddXY(i+1, money);
            }

            totalChart.Series["Series1"].Points.Clear();
            for (int i = 0; i < 12; i++)
            {
                int money = PrimaryOperation.TotalMonthlySum(i + 1);
            }
            

            //MessageBox.Show(PrimaryOperation.MonthCompare_Money(4).ToString());
        }
    }
}
