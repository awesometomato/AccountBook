using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class PrimaryOperation
    {
        public static int currentUser = -1;

        //회원가입할때 중복된 아이디가 체크하는 함수
        //db에서 중복 검사할 수 있으면 삭제해도 됨
        public static int redundancyCheck(String id)
        {
            foreach (var item in Member.list)
            {
                if (item.Id == id)
                    return -1;
            }
            return 0;
        }

        public static void moneystore(String kind, String year, String month, String day, String won)
        {
            Money money = new Money(kind, int.Parse(won), int.Parse(year), int.Parse(month), int.Parse(day));
            Member.list[PrimaryOperation.currentUser].moneylist.Add(money);
        }

        //money 항목 추가 함수
        public static bool addItem(String kind, String year, String month, String day, String won, bool r1, bool r2)
        {
            int w;

            if (year == "" || month == "" || day == "" ||
                kind == "" || won == "")
                MessageBox.Show("입력되지 않은 빈 칸이 있습니다.", "에러 메시지");
            else if (r1 == false && r2 == false)
                MessageBox.Show("지출인지 수입인지를 선택해주세요.", "에러 메시지");
            else if (int.TryParse(won, out w) == false || w <= 0)
                MessageBox.Show("액수는 자연수만 입력해주세요.", "에러 메시지");
            else
            {
                PrimaryOperation.moneystore(kind, year, month, day, won);
                if (r1 == true)
                    MessageBox.Show("지출 항목이 추가되었습니다.", "항목 추가 완료");
                else
                    MessageBox.Show("수입 항목이 추가되었습니다.", "항목 추가 완료");
                return true;
            }
            return false;
        }

        //회원가입 함수
        public static bool addUser(String name, String age, String id, String password, String passwordcheck, bool women, bool men)
        {
            int a;

            if (name.Trim().Length == 0 || id.Trim().Length == 0 || password.Trim().Length == 0 ||
                passwordcheck.Trim().Length == 0 || age.Trim().Length == 0)
                MessageBox.Show("입력되지 않은 빈 칸이 있습니다.", "에러 메시지");
            else if (women == false && men == false)
                MessageBox.Show("성별을 선택해주세요.", "에러 메시지");
            else if (PrimaryOperation.redundancyCheck(id) == -1)
                MessageBox.Show("해당 아이디가 이미 존재합니다", "에러 메시지");
            else if (int.TryParse(age, out a) == false)
                MessageBox.Show("나이는 자연수만 입력해주세요.", "에러 메시지");
            else if (password != passwordcheck)
                MessageBox.Show("비밀번호가 일치하지 않습니다.", "에러 메시지");
            else
            {
                User member = new User();
                member.Name = name;
                member.Id = id;
                member.Password = password;
                member.Age = a;
                if (women == true)
                    member.Gender = true;
                else
                    member.Gender = false;

                Member.list.Add(member);

                MessageBox.Show("회원가입이 완료되었습니다.", "회원가입 완료");
                return true;
            }
            return false;
        }

        //로그인 함수
        public static bool logincheck(String id, String password)
        {
            if (id.Trim().Length == 0 || password.Trim().Length == 0)
                MessageBox.Show("아이디 혹은 비밀번호를 입력해주세요.", "에러 메시지");
            else
            {
                User tmp_user = null;
                int cnt = 0;
                foreach (var item in Member.list)
                {
                    if (item.Id == id)
                    {
                        tmp_user = item;
                        break;
                    }
                    cnt++;
                }

                if (tmp_user == null)
                    MessageBox.Show("해당 아이디가 존재하지 않습니다.", "에러 메시지");
                else if (tmp_user.Password != password)
                    MessageBox.Show("비밀번호가 올바르지 않습니다.", "에러 메시지");
                else
                {
                    PrimaryOperation.currentUser = cnt;
                    return true;
                }
            }
            return false;
        }
    }
}
