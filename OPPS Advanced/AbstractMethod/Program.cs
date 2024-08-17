abstract class Person
{
  
   
    public string FName;
    public string LName;
    public int Age;
    public long PhoneNumber;
    public abstract void PrintDetails();

}
class Student:Person
{
    public int RollNumber;
    public int Fees;
    public override void PrintDetails()
    {
        string name = this.FName + " " + this.LName;
        Console.WriteLine($"Student Name {name}" );
        Console.WriteLine($"Student age {this.Age}");
        Console.WriteLine($"Student PhoneNumber {this.PhoneNumber}" );
        Console.WriteLine($"Student RollNumber {this.RollNumber} ");
        Console.WriteLine($"Student Fees {this.Fees} ");
    }

}
class Teacher:Person
{
    public string Qualification;
    public float Salary;
    public override void PrintDetails()
    {
        string name = this.FName + " " + this.LName;
        Console.WriteLine($"Teacher Name {name}");
        Console.WriteLine($"Teacher age {this.Age}");
        Console.WriteLine($"Teacher PhoneNumber {this.PhoneNumber}");
        Console.WriteLine($"Teacher Qualification {this.Qualification} ");
        Console.WriteLine($"Teacher Salary {this.Salary}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        student.FName = "Ram";
        student.LName = "Sam";
        student.Age = 23;
        student.PhoneNumber = 6823162376;
        student.RollNumber = 23;
        student.Fees = 1550;
        student.PrintDetails();
        Console.WriteLine();
        Teacher teacher = new Teacher();
        teacher.FName = "Sam";
        teacher.LName = "Kam";
        teacher.Age = 56;
        teacher.PhoneNumber = 8366923732;
        teacher.Salary = 32187;
        teacher.Qualification = "PHD";
        teacher.PrintDetails();
    }
}