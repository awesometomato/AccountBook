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
    public partial class Add : Form
    {
        private int num;

        public Add()
        {
            num = 0;
            InitializeComponent();
            prepare_comboBox();
        }

        public Add(int num)
        {
            this.num = 2;
            InitializeComponent();
            prepare_comboBox();

            //num에 해당하는 Money객체 생성하는 함수
            Money money = new Money(num);

            if (money.Income_expense == "지출")
            {
                expenseradiobutton.Checked = true;
                incomeradiobutton.Checked = false;
            }
            else
            {
                incomeradiobutton.Checked = true;
                expenseradiobutton.Checked = false;
            }
            yearcomboBox.Text = money.Year.ToString();
            monthcomboBox.Text = money.Month.ToString();
            daycomboBox.Text = money.Day.ToString();
            memotextBox.Text = money.Kind;
            moneytextBox.Text = money.Won.ToString();

        }

        public void prepare_comboBox()
        {
            yearcomboBox.Items.Add("2019"); 
            yearcomboBox.Items.Add("2020");
            yearcomboBox.Items.Add("2021");

            monthcomboBox.Items.Add("1");
            monthcomboBox.Items.Add("2");
            monthcomboBox.Items.Add("3");
            monthcomboBox.Items.Add("4");
            monthcomboBox.Items.Add("5");
            monthcomboBox.Items.Add("6");
            monthcomboBox.Items.Add("7");
            monthcomboBox.Items.Add("8");
            monthcomboBox.Items.Add("9");
            monthcomboBox.Items.Add("10");
            monthcomboBox.Items.Add("11");
            monthcomboBox.Items.Add("12");

            daycomboBox.Items.Add("1");
            daycomboBox.Items.Add("2");
            daycomboBox.Items.Add("3");
            daycomboBox.Items.Add("4");
            daycomboBox.Items.Add("5");
            daycomboBox.Items.Add("6");
            daycomboBox.Items.Add("7");
            daycomboBox.Items.Add("8");
            daycomboBox.Items.Add("9");
            daycomboBox.Items.Add("10");
            daycomboBox.Items.Add("11");
            daycomboBox.Items.Add("12");
            daycomboBox.Items.Add("13");
            daycomboBox.Items.Add("14");
            daycomboBox.Items.Add("15");
            daycomboBox.Items.Add("16");
            daycomboBox.Items.Add("17");
            daycomboBox.Items.Add("18");
            daycomboBox.Items.Add("19");
            daycomboBox.Items.Add("20");
            daycomboBox.Items.Add("21");
            daycomboBox.Items.Add("22");
            daycomboBox.Items.Add("23");
            daycomboBox.Items.Add("24");
            daycomboBox.Items.Add("25");
            daycomboBox.Items.Add("26");
            daycomboBox.Items.Add("27");
            daycomboBox.Items.Add("28");
            daycomboBox.Items.Add("29");
            daycomboBox.Items.Add("30");
            daycomboBox.Items.Add("31");
        }

        private void addbutton_Click(object sender, EventArgs e)
        {

            string str;

            string sign = "2";
            if (expenseradiobutton.Checked == true) { sign = "지출"; }
            else if (incomeradiobutton.Checked == true) { sign = "수입"; }

            str = PrimaryOperation.AddMoney(moneytextBox.Text, sign, yearcomboBox.Text, monthcomboBox.Text, daycomboBox.Text, memotextBox.Text, num);

            MessageBox.Show(str);

            // 초기화
            if (str == "정상적으로 입력되었습니다.")
            {
                yearcomboBox.Text = "";
                monthcomboBox.Text = "";
                daycomboBox.Text = "";
                memotextBox.Text = "";
                moneytextBox.Text = "";
                expenseradiobutton.Checked = false;
                incomeradiobutton.Checked = false;
                this.Close();
            }
            //if (PrimaryOperation.AddMoney(memotextBox.Text, yearcomboBox.Text, monthcomboBox.Text, daycomboBox.Text, moneytextBox.Text,
            //    expenseradiobutton.Checked, incomeradiobutton.Checked))
            //    this.Close();

        }

    }
}
