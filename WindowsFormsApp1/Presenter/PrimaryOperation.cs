using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    class PrimaryOperation
    {
        public static int currentUser = -1;
        public static DataRow currentID = null;
        public static MySqlConnection connection = new MySqlConnection("Server=localhost;Database=project;Uid=root;Pwd=asdrkd123;");

        //회원가입할때 중복된 아이디가 체크하는 함수
        //db에서 중복 검사할 수 있으면 삭제해도 됨
        //public static int redundancyCheck(String id)
        //{
        //    foreach (var item in Member.list)
        //    {
        //        if (item.Id == id)
        //            return -1;
        //    }
        //    return 0;
        //}

        //public static void moneystore(String kind, String year, String month, String day, String won)
        //{
        //    Money money = new Money(kind, int.Parse(won), int.Parse(year), int.Parse(month), int.Parse(day));
        //    Member.list[PrimaryOperation.currentUser].moneylist.Add(money);
        //}

        //money 항목 추가 함수

        //public static bool addItem(String kind, String year, String month, String day, String won, bool r1, bool r2)
        //{
        //    int w;

        //    if (year == "" || month == "" || day == "" ||
        //        kind == "" || won == "")
        //        MessageBox.Show("입력되지 않은 빈 칸이 있습니다.", "에러 메시지");
        //    else if (r1 == false && r2 == false)
        //        MessageBox.Show("지출인지 수입인지를 선택해주세요.", "에러 메시지");
        //    else if (int.TryParse(won, out w) == false || w <= 0)
        //        MessageBox.Show("액수는 자연수만 입력해주세요.", "에러 메시지");
        //    else
        //    {
        //        PrimaryOperation.moneystore(kind, year, month, day, won);
        //        if (r1 == true)
        //            MessageBox.Show("지출 항목이 추가되었습니다.", "항목 추가 완료");
        //        else
        //            MessageBox.Show("수입 항목이 추가되었습니다.", "항목 추가 완료");
        //        return true;
        //    }
        //    return false;
        //}

        public static string AddMoney(string money, string sign, string year, string month, string day, string memo, bool mode)
        {
            Money m = new Money();
            return m.AddMoney(money, sign, year, month, day, memo, mode);
        }

        //Join - User
        public static string Join_User(string id, string password, string passwordCheck, string name, string gender, string age)
        {
            User user = new User();
            return user.AddUser(id, password, passwordCheck, name, gender, age);
        }

        //Loin - User
        public static string Loin_User(string id, string password)
        {
            User user = new User();
            return user.SelectUser(id, password);
        }

        public static DataSet Binding()
        {
            Money m = new Money();
            return m.GetDataSet();
        }

        //connection 위치
        //model 에서 db로 데이터 저장
        //db primary key
    }
}
