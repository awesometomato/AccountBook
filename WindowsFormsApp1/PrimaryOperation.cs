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

        public static int redundancyCheck(String id)
        {
            foreach(var item in list)
            {
                if (item.Id == id)
                    return -1;
            }
            return 0;
        }
       
    }
}
