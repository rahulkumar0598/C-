using Construstors;

class Program
{
    static void Main(string[] args)
    {
        //object is an instance of a class

        Console.WriteLine("Enter Roll No");
        int roll = int.Parse(Console.ReadLine());
        Student Ram = new Student(roll, "Ram", 24, 10);
        Ram.GetStudent();
        Student Ram1 = new Student(roll, "Ram1", 241, 110);
        Ram.GetStudent();
        Student student = new();
    }
}