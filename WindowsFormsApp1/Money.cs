using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
