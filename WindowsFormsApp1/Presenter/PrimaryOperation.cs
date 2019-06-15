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
        public static string[] ExpenseStr = { "식비", "교통비", "문화생활", "생필품", "의류", "미용", "의료/건강", "교육", "통신비", "회비", "경조사", "저축", "가전", "공과금", "카드대금" };
        public static string[] IncomeStr = { "월급", "용돈", "이월", "자산인출", "기타" };
        
        //Add - Money
        public static string AddMoney(string money, string sign, string kind, string year, string month, string day, string memo, int num)
        {
            Money m = new Money();
            return m.AddMoney(money, sign, kind, year, month, day, memo, num);
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
        
        public static DataSet Binding(string date, int flag, string expense, string income)
        {
            Money m = new Money();
            return m.GetDataSet(date, flag, expense, income);
        }

        public static string DeleteItem(int num)
        {
            //num에 해당하는 Money객체 생성하는 함수
            Money money = new Money();
            return money.DeleteMoney(num);
        }

        public static int UserMonthlyExpense(int i)
        {
            Money money = new Money();
            return money.UserMonthlyExpense(i);
        }

        public static int UserMonthlyIncome(int i)
        {
            Money money = new Money();
            return money.UserMonthlyIncome(i);
        }

        public static int TotalMonthlyExpense(int i)
        {
            Money money = new Money();
            return money.TotalMonthlyExpense(i);
        }

        public static int TotalMonthlyIncome(int i)
        {
            Money money = new Money();
            return money.TotalMonthlyIncome(i);
        }

        public static int UserCnt()
        {
            User user = new User();
            return user.UserCnt();
        }

        public static double UserExpensePercent(int i)
        {
            Money money = new Money();
            return money.UserExpensePercent(i);
        }

        public static double UserIncomePercent(int i)
        {
            Money money = new Money();
            return money.UserIncomePercent(i);
        }

        public static double TotalExpensePercent(int i)
        {
            Money money = new Money();
            return money.TotalExpensePercent(i);
        }

        public static double TotalIncomePercent(int i)
        {
            Money money = new Money();
            return money.TotalIncomePercent(i);
        }

        //connection 위치
        //model 에서 db로 데이터 저장
        //db primary key
    }
}
