using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMet
{
    static class Maxs
    {
        static string name;
        static int age;

        static Maxs()
        {
            age = 0;
            name = "Ram";
        }

        //copy constructor
        

        public static void GetClass()
        {
            Console.WriteLine($" Name is {name} and age is {age}" );
        }
    }
}
