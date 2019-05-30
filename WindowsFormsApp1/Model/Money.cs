using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    class Money
    {
        private String kind;
        private int won;
        private int year;
        private int month;
        private int day;

        public String Kind
        {
            get { return kind; }
            set { kind = value; }
        }
        public int Won
        {
            get { return won; }
            set { won = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public int Month
        {
            get { return month; }
            set { month = year; }
        }
        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public Money()
        {
            kind = "";
            won = 0;
            year = 0;
            month = 0;
            day = 0;
        }

        public Money(String kind, int won, int year, int month, int day)
        {
            this.kind = kind;
            this.won = won;
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public string AddMoney(string money, string sign, string year, string month, string day, string memo)
        {
            if (money == "" || sign == "2" || year =="" || month == "" || day == "")
            {
                return "모든 항목을 입력해주세요.";
            }

            int i;
            if (int.TryParse(money, out i) == false) { return "금액은 숫자로 입력해주세요."; }

            string date = "00000000";
            if (month.Length == 1) { month = "0" + month; }
            if (day.Length == 1) { day = "0" + day; }
            date = year + month + day;

            MySqlConnection connection = new MySqlConnection("Server=localhost;Database=project;Uid=root;Pwd=s17011564!;");
            string insertQuery = "INSERT INTO money_tb (id,money,sign,date,memo) VALUES('" + PrimaryOperation.currentID["id"].ToString() + "'," + money + "," + sign + "," + date + ",'" + memo + "')";

            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    return "정상적으로 입력되었습니다.";
                }
                else { return "오류!!"; }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
