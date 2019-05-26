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
            //int age;

            //if (idtextBox.Text.Trim().Length == 0 || joinidtextbox.Text.Trim().Length == 0 || joinpasswordtextBox.Text.Trim().Length == 0 ||
            //    joinpasswordchecktextBox.Text.Trim().Length == 0 || agetextBox.Text.Trim().Length == 0)
            //    MessageBox.Show("입력되지 않은 빈 칸이 있습니다.", "에러 메시지");
            //else if (womenradio.Checked == false && menradio.Checked == false)
            //    MessageBox.Show("성별을 선택해주세요.", "에러 메시지");
            //else if (PrimaryOperation.redundancyCheck(joinidtextbox.Text) == -1)
            //    MessageBox.Show("해당 아이디가 이미 존재합니다", "에러 메시지");
            //else if (int.TryParse(agetextBox.Text, out age) == false)
            //    MessageBox.Show("나이는 자연수만 입력해주세요.", "에러 메시지");
            //else if (joinpasswordtextBox.Text != joinpasswordchecktextBox.Text)
            //    MessageBox.Show("비밀번호가 일치하지 않습니다.", "에러 메시지");
            //else
            //{
            //    User member = new User();
            //    member.Name = idtextBox.Text;
            //    member.Id = joinidtextbox.Text;
            //    member.Password = joinpasswordtextBox.Text;
            //    member.Age = age;
            //    if (womenradio.Checked == true)
            //        member.Gender = true;
            //    else
            //        member.Gender = false;

            //    Member.list.Add(member);

            //    MessageBox.Show("회원가입이 완료되었습니다.", "회원가입 완료");
            //    this.Close();
            //}

            if (PrimaryOperation.addUser(idtextBox.Text, agetextBox.Text, joinidtextbox.Text, joinpasswordtextBox.Text, joinpasswordchecktextBox.Text,
                womenradio.Checked, menradio.Checked))
                this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
