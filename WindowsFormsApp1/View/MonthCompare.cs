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
            userLabel.Text = PrimaryOperation.currentUser.Name;

            userChart.Series["수입"].Points.Clear();
            for (int i = 0; i < 12; i++)
            {
                int income = PrimaryOperation.UserMonthlyIncome(i + 1);
                userChart.Series["수입"].Points.AddXY(i+1, income);
            }

            userChart.Series["지출"].Points.Clear();
            for (int i = 0; i < 12; i++)
            {
                int expense = PrimaryOperation.UserMonthlyExpense(i + 1);
                userChart.Series["지출"].Points.AddXY(i + 1, expense);
            }

            totalChart.Series["수입"].Points.Clear();
            for (int i = 0; i < 12; i++)
            {
                int income = PrimaryOperation.TotalMonthlyIncome(i + 1);
                totalChart.Series["수입"].Points.AddXY(i + 1, income);
            }

            totalChart.Series["지출"].Points.Clear();
            for (int i = 0; i < 12; i++)
            {
                int expense = PrimaryOperation.TotalMonthlyExpense(i + 1);
                totalChart.Series["지출"].Points.AddXY(i + 1, expense);
            }
            

            //MessageBox.Show(PrimaryOperation.MonthCompare_Money(4).ToString());
        }

        private void userChart_Click(object sender, EventArgs e)
        {

        }
    }
}
