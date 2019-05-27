using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class PrimaryOperation
    {
        public static List<User> list = new List<User>();
        public static int currentUser = -1;
        public static string currenID = "";

        public static int redundancyCheck(String id)
        {
            foreach(var item in list)
            {
                if (item.Id == id)
                    return -1;
            }
            return 0;
        }

        public static string Join_Users(string id, string password, string passwordCheck, string gender, string name, string age)
        {
            User add_user = new User();
            return add_user.AddUser(id, password, passwordCheck, gender, name, age);
        }

        public static string Loin_Users(string id, string password)
        {
            User user = new User();
            return user.Login(id, password);
        }
       
    }
}
