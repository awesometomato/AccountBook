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
    public partial class Join : Form
    {
        public Join()
        {
            InitializeComponent();
            passwordBox.PasswordChar = '*';
            passwordCheckBox.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Login showForm1 = new Login();
            showForm1.Show();
        }

    

        private void button3_Click(object sender, EventArgs e)
        {
            //Application.ExitThread();
            this.Close();
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string str = "";
            string gender = "2";
            if (womenRadio.Checked == true) gender = "0";
            else if (menRadio.Checked == true) gender = "1";
            str = PrimaryOperation.Join_User(idBox.Text, passwordBox.Text, passwordCheckBox.Text, nameBox.Text, gender, ageBox.Text);

            MessageBox.Show(str);

            if (str == "정상적으로 가입되었습니다.")
            {
                this.Close();
            }
            
        }
    }
}
