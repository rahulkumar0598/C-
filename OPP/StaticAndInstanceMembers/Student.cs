using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndInstanceMembers
{
    internal class Student
    {
        public int rollNo;
        public string fname;
        public string lname;
        public int standard;
        public static int Fee=4000;
        public static int Fees()
        {
            return Fee;
        }

        public static int GetFeeIncrement(int fee)
        {
            return fee / 10;
        }

    }
}
