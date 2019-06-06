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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
            prepare_comboBox();
            expenseBtn.Checked = false;
            incomeBtn.Checked = false;
            createData();
        }

        public void prepare_comboBox()
        {
            yearBox.Items.Add("2019");
            yearBox.Items.Add("2020");
            yearBox.Items.Add("2021");

            monthBox.Items.Add("1");
            monthBox.Items.Add("2");
            monthBox.Items.Add("3");
            monthBox.Items.Add("4");
            monthBox.Items.Add("5");
            monthBox.Items.Add("6");
            monthBox.Items.Add("7");
            monthBox.Items.Add("8");
            monthBox.Items.Add("9");
            monthBox.Items.Add("10");
            monthBox.Items.Add("11");
            monthBox.Items.Add("12");

            dayBox.Items.Add("1");
            dayBox.Items.Add("2");
            dayBox.Items.Add("3");
            dayBox.Items.Add("4");
            dayBox.Items.Add("5");
            dayBox.Items.Add("6");
            dayBox.Items.Add("7");
            dayBox.Items.Add("8");
            dayBox.Items.Add("9");
            dayBox.Items.Add("10");
            dayBox.Items.Add("11");
            dayBox.Items.Add("12");
            dayBox.Items.Add("13");
            dayBox.Items.Add("14");
            dayBox.Items.Add("15");
            dayBox.Items.Add("16");
            dayBox.Items.Add("17");
            dayBox.Items.Add("18");
            dayBox.Items.Add("19");
            dayBox.Items.Add("20");
            dayBox.Items.Add("21");
            dayBox.Items.Add("22");
            dayBox.Items.Add("23");
            dayBox.Items.Add("24");
            dayBox.Items.Add("25");
            dayBox.Items.Add("26");
            dayBox.Items.Add("27");
            dayBox.Items.Add("28");
            dayBox.Items.Add("29");
            dayBox.Items.Add("30");
            dayBox.Items.Add("31");
        }

        public void createData()
        {
            DataSet ds = PrimaryOperation.Binding();
            dataGridView1.DataSource = ds.Tables[0];
            this.dataGridView1.Columns["num"].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Compare showForm5 = new Compare();
            showForm5.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) // logoutBtn
        {
            //PrimaryOperation.currentUser = -1;
            PrimaryOperation.currentID = null; // db
            this.Close();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Add showForm3 = new Add();
            showForm3.ShowDialog();
            createData();
            //string str;

            //string sign = "2";
            //if (expenseBtn.Checked == true) { sign = "0"; }
            //else if (incomeBtn.Checked == true) { sign = "1"; }

            //str = PrimaryOperation.AddMoney(moneyBox.Text, sign, yearBox.Text, monthBox.Text, dayBox.Text, memoBox.Text);

            //MessageBox.Show(str);

            //// 초기화
            //if (str == "정상적으로 입력되었습니다.")
            //{
            //    yearBox.Text = "";
            //    monthBox.Text = "";
            //    dayBox.Text = "";
            //    memoBox.Text = "";
            //    moneyBox.Text = "";
            //    expenseBtn.Checked = false; incomeBtn.Checked = false;
            //}
        }

        private void changebutton_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentRow.Index;
            int num = int.Parse(dataGridView1.Rows[rowindex].Cells[0].Value.ToString());
           
            Add form = new Add(num);
            form.ShowDialog();
            createData();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentRow.Index;
            int num = int.Parse(dataGridView1.Rows[rowindex].Cells[0].Value.ToString());

            PrimaryOperation.DeleteItem(num);
          
            createData();
        }
    }
}
