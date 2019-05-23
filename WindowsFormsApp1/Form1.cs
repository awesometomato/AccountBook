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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 showForm2 = new Form2();
            showForm2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idtextBox.Text.Trim().Length == 0 || passwordtextBox.Text.Trim().Length == 0)
                MessageBox.Show("아이디 혹은 비밀번호를 입력해주세요.", "에러 메시지");
            else
            {
                User tmp_user = null;
                int cnt = 0;
                foreach (var item in PrimaryOperation.list)
                {
                    if (item.Id == idtextBox.Text)
                    {
                        tmp_user = item;
                        break;
                    }
                    cnt++;
                }

                if (tmp_user == null)
                    MessageBox.Show("해당 아이디가 존재하지 않습니다.", "에러 메시지");
                else
                {
                    if (tmp_user.Password == passwordtextBox.Text)
                    {
                        idtextBox.Text = "";
                        passwordtextBox.Text = "";
                        PrimaryOperation.currentUser = cnt;
                        Form4 showForm4 = new Form4();
                        showForm4.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("비밀번호가 올바르지 않습니다.", "에러 메시지");
                        passwordtextBox.Text = "";
                    }
                }
                
            }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
