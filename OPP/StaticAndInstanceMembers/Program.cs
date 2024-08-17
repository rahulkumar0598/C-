
using StaticAndInstanceMembers;

class Program
{
    static void Main(string[] args)
    {
        Student Ram = new();
        Ram.rollNo= 1;
        Student Sam= new();
        Sam.rollNo= 13;
        Console.WriteLine(Ram.rollNo+"   "+Sam.rollNo);
        Console.WriteLine(Student.Fees());
        Console.WriteLine(Student.GetFeeIncrement(400));
    }
}