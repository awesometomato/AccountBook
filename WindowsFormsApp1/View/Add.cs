﻿using System;
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
        private bool mode;

        public Add()
        {
            mode = false;
            InitializeComponent();
            prepare_comboBox();
        }
        public Add(bool mode)
        {
            this.mode = mode;
            InitializeComponent();
            prepare_comboBox();

           
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
            //int won;

            //if (yearcomboBox.Text == "" || monthcomboBox.Text == "" || daycomboBox.Text == "" ||
            //    memotextBox.Text == "" || moneytextBox.Text == "")
            //    MessageBox.Show("입력되지 않은 빈 칸이 있습니다.", "에러 메시지");
            //else if (expenseradiobutton.Checked == false && incomeradiobutton.Checked == false)
            //    MessageBox.Show("지출인지 수입인지를 선택해주세요.", "에러 메시지");
            //else if (int.TryParse(moneytextBox.Text, out won) == false || won <= 0)
            //    MessageBox.Show("액수는 자연수만 입력해주세요.", "에러 메시지");
            //else
            //{
            //    PrimaryOperation.moneystore(memotextBox.Text, yearcomboBox.Text, monthcomboBox.Text, daycomboBox.Text, moneytextBox.Text);
            //    if (expenseradiobutton.Checked == true)
            //        MessageBox.Show("지출 항목이 추가되었습니다.", "항목 추가 완료");
            //    else
            //        MessageBox.Show("수입 항목이 추가되었습니다.", "항목 추가 완료");
            //    this.Close();
            //}

            string str;

            string sign = "2";
            if (expenseradiobutton.Checked == true) { sign = "지출"; }
            else if (incomeradiobutton.Checked == true) { sign = "수입"; }

            str = PrimaryOperation.AddMoney(moneytextBox.Text, sign, yearcomboBox.Text, monthcomboBox.Text, daycomboBox.Text, memotextBox.Text, mode);

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
            }
            //if (PrimaryOperation.AddMoney(memotextBox.Text, yearcomboBox.Text, monthcomboBox.Text, daycomboBox.Text, moneytextBox.Text,
            //    expenseradiobutton.Checked, incomeradiobutton.Checked))
            //    this.Close();

        }

    }
}
