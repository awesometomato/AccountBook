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
        public static User currentUser; 
        public static MySqlConnection connection = new MySqlConnection("Server=localhost;Database=project;Uid=root;Pwd=s17011564!;");

        
        //Add - Money
        public static string AddMoney(string money, string sign, string year, string month, string day, string memo, int num)
        {
            Money m = new Money();
            return m.AddMoney(money, sign, year, month, day, memo, num);
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
        
        public static string DeleteItem(int num)
        {
            //num에 해당하는 Money객체 생성하는 함수
            Money money = new Money();
            return money.DeleteMoney(num);
        }

        //connection 위치
        //model 에서 db로 데이터 저장
        //db primary key
    }
}
