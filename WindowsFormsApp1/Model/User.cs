using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        ~User()
        {
            total_People--;
        }
        

    }
}
