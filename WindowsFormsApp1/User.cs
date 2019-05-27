using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

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
            total_People++;
        }

        public User(String id, String password, String name, bool gender, int generation)
        {
            this.id = id;
            this.password = password;
            this.name = name;
            this.gender = gender;
            this.age = generation;
            total_People++;
        }

        public string AddUser(string id, string password, string passwordCheck, string gender, string name, string age)
        {
            if (id == "" || password == "" || gender == "3" || name== "" || age == "")
            {
                return "모든 항목을 입력해주세요.";
            }

            int i = 0;
            if (int.TryParse(age, out i) == false)
            {
                return "나이는 숫자를 입력해주세요";
            }

            if (password == passwordCheck)
                return "비밀번호가 일치하지 않습니다.";

            MySqlConnection connection = new MySqlConnection("Server=localhost;Database=project;Uid=root;Pwd=s17011564!;");
            string insertQuery = "INSERT INTO member_tb (id,password,gender,name,age) VALUES('" + id + "','" + password + "'," + gender + ",'" + name + "'," + age + ")";

            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    return "정상적으로 가입되었습니다";
                }
                else
                {
                    return "오류!!";
                }
            }
            catch(Exception ex)
            {
                if (ex.Message == "Duplicate entry '" + id + "' for key 'PRIMARY")
                {
                    return "이미존재하는 아이디 입니다";
                }
                return ex.Message;
            }finally
            {
                connection.Close();
            }
        }

        ~User()
        {
            total_People--;
        }
        

    }
}
