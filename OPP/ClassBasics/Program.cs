using ClassBasics;

class Program
{
    static void Main(string[] args)
    {
        //object is an instance of a class

        Console.WriteLine("Enter Roll No");
        int roll=int.Parse(Console.ReadLine());
        Student Ram= new Student();
        Ram.SetStudent(roll,"Ram",24,10);
        Ram.GetStudent();
    }
}