using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data;

namespace WindowsFormsApp1
{
    class User
    {
        public static int total_People;

        private String id;
        private String password;
        private String name;
        private bool gender;
        private int age;
        public List<Money> moneylist;

        public String Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        static User()
        {
            total_People = 0;
        }

        public User()
        {
            id = "";
            password = "";
            name = "";
            gender = false;
            age = 0;
            moneylist = new List<Money>();
            total_People++;
        }

        public User(String id, String password, String name, bool gender, int generation)
        {
            this.id = id;
            this.password = password;
            this.name = name;
            this.gender = gender;
            this.age = generation;
            moneylist = new List<Money>();
            total_People++;
        }

        public string AddUser(string id, string password, string passwordCheck, string name, string gender, string age)
        {
            if (id == "" || password == "" || name == "" || gender == "2" || age == "") { return "모든 항목을 입력해주세요."; }

            int i = 0;
            if (int.TryParse(age, out i) == false) { return "나이는 숫자로 입력해주세요."; }

            if (password != passwordCheck) { return "비밀번호가 일치하지 않습니다."; }

            MySqlConnection connection = new MySqlConnection("Server=192.168.35.178;Database=accountbook;Uid=root;Pwd=s17011564!;");
            string insertQuery = "INSERT INTO user (id,password,gender,name,age) VALUES('" + id + "','" + password + "'," + gender + ",'" + name + "'," + age + ")";

            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    return "정상적으로 가입되었습니다.";
                }
                else { return "오류!!"; }
            } catch(Exception ex)
            {
                if (ex.Message == "Duplicate entry '" + id + "'for key 'PRIMARY'") { return "이미 존재하는 아이디 입니다."; }
                else { return ex.Message; }
            } finally
            {
                connection.Close();
            }
        }

        public string SelectUser(string id, string password)
        {
            if (id == "") return "아이디를 입력해주세요.";
            else if (password == "") return "비밀번호를 입력해주세요.";

            try
            {
                MySqlConnection connection = new MySqlConnection("Server=192.168.35.178;Database=accountbook;Uid=root;Pwd=s17011564!;");

                DataSet ds = new DataSet();

                string selectQuery = "SELECT * FROM user WHERE id = '"+id+"'";
                MySqlDataAdapter adpt = new MySqlDataAdapter(selectQuery, connection);
                adpt.Fill(ds, "user");
                if (ds.Tables.Count == 0) { return "아이디가 존재하지 않습니다."; }
                else if (ds.Tables.Count > 0)
                {
                    DataRow row;
                    row = ds.Tables[0].Rows[0];
                    if (row["password"].ToString() == password)
                    {
                        PrimaryOperation.currentID = row;
                        return "login";
                    }
                    else return "비밀번호가 일치하지 않습니다.";
                }
                else { return "음수 오류"; }
            } catch(Exception ex)
            {
                if (ex.Message == "위치 0에 행이 없습니다.")
                {
                    return "아이디가 존재하지 않습니다.";
                }
                else { return ex.Message; }
            }
            finally
            {

            }
        }

        ~User()
        {
            total_People--;
        }
        

    }
}
