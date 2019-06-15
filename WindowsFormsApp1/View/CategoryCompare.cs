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
    public partial class CategoryCompare : Form
    {
        public CategoryCompare()
        {
            InitializeComponent();
        }

        private void CategoryCompare_Load(object sender, EventArgs e)
        {
            userBtn.Enabled = false;
            totalBtn.Enabled = true;

            for (int i = 0; i < 15; i++)
            {
                chart1.Series["지출"].Points[i].Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
                double percent = 0;
                percent = PrimaryOperation.UserExpensePercent(i);
                chart1.Series["지출"].Points[i].SetValueY(percent);
                if (percent == 0) chart1.Series["지출"].Points[i].Font = new Font("Gothic", 1, FontStyle.Regular);
            }


            for (int i = 0; i < 5; i++)
            {
                chart2.Series["수입"].Points[i].Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
                double percent = 0;
                percent = PrimaryOperation.UserIncomePercent(i);
                chart2.Series["수입"].Points[i].SetValueY(percent);
                if (percent == 0) chart2.Series["수입"].Points[i].Font = new Font("Gothic", 1, FontStyle.Regular);
            }
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            userBtn.Enabled = false;
            totalBtn.Enabled = true;

            for (int i = 0; i < 15; i++)
            {
                chart1.Series["지출"].Points[i].Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
                double percent = 0;
                percent = PrimaryOperation.UserExpensePercent(i);
                chart1.Series["지출"].Points[i].SetValueY(percent);
                if (percent == 0) chart1.Series["지출"].Points[i].Font = new Font("Gothic", 1, FontStyle.Regular);
            }


            for (int i = 0; i < 5; i++)
            {
                chart2.Series["수입"].Points[i].Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
                double percent = 0;
                percent = PrimaryOperation.UserIncomePercent(i);
                chart2.Series["수입"].Points[i].SetValueY(percent);
                if (percent == 0) chart2.Series["수입"].Points[i].Font = new Font("Gothic", 1, FontStyle.Regular);
            }
        }

        private void totalBtn_Click(object sender, EventArgs e)
        {
            userBtn.Enabled = true;
            totalBtn.Enabled = false;

            for (int i = 0; i < 15; i++)
            {
                chart1.Series["지출"].Points[i].Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
                double percent = 0;
                percent = PrimaryOperation.TotalExpensePercent(i);
                chart1.Series["지출"].Points[i].SetValueY(percent);
                if (percent == 0) chart1.Series["지출"].Points[i].Font = new Font("Gothic", 1, FontStyle.Regular);
            }


            for (int i = 0; i < 5; i++)
            {
                chart2.Series["수입"].Points[i].Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
                double percent = 0;
                percent = PrimaryOperation.TotalIncomePercent(i);
                chart2.Series["수입"].Points[i].SetValueY(percent);
                if (percent == 0) chart2.Series["수입"].Points[i].Font = new Font("Gothic", 1, FontStyle.Regular);
            }
        }
    }
}
