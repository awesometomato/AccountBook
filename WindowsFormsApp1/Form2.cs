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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 showForm1 = new Form1();
            showForm1.Show();
        }

    

        private void button3_Click(object sender, EventArgs e)
        {
            //Application.ExitThread();
            this.Close();
        }

   

        private void button1_Click(object sender, EventArgs e)
        {
            int age;

            if (textBox1.Text.Trim().Length == 0 || textBox2.Text.Trim().Length == 0 || textBox3.Text.Trim().Length == 0 ||
                textBox4.Text.Trim().Length == 0 || textBox5.Text.Trim().Length == 0)
                MessageBox.Show("입력되지 않은 빈 칸이 있습니다.", "에러 메시지");
            else if (radioButton1.Checked == false && radioButton2.Checked == false)
                MessageBox.Show("성별을 선택해주세요.", "에러 메시지");
            else if (PrimaryOperation.redundancyCheck(textBox2.Text) == -1)
                MessageBox.Show("해당 아이디가 이미 존재합니다", "에러 메시지");
            else if (int.TryParse(textBox5.Text, out age) == false)
                MessageBox.Show("나이는 자연수만 입력해주세요.", "에러 메시지");
            else if (textBox3.Text != textBox4.Text)
                MessageBox.Show("비밀번호가 일치하지 않습니다.", "에러 메시지");
            else
            {
                User member = new User();
                member.Name = textBox1.Text;
                member.Id = textBox2.Text;
                member.Password = textBox3.Text;
                member.Age = age;
                if (radioButton1.Checked == true)
                    member.Gender = true;
                else
                    member.Gender = false;

                PrimaryOperation.list.Add(member);

                MessageBox.Show("회원가입이 완료되었습니다.", "회원가입 완료");
                this.Close();
            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
