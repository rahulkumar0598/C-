
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBasics
{
    internal class Student
    {
        int rollNo;
        string name;
        int age;
        int standard;
        public void SetStudent(int rollNo, string name,int age,int standard)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.age = age; 
            this.standard = standard;
        }
        public void GetStudent()
        {
            Console.WriteLine($"Yor name is {name} age {age} rollno {rollNo} and {standard}");
        }
    }
}
