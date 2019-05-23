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

        private void button2_Click(object sender, EventArgs e)
        {
            Compare showForm5 = new Compare();
            showForm5.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrimaryOperation.currentUser = -1;
            this.Close();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            Add showForm3 = new Add();
            showForm3.ShowDialog();
        }
    }
}
