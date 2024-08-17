
using System.Text;

class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Enter First number");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Second number");
        int num2 = int.Parse(Console.ReadLine());
        try
        {
            int result = num1 / num2;
            Console.WriteLine($"Result is {result}");
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine("You cannot divide by zero");
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine("Statement 1");
        Console.WriteLine("Statement 2");

    }
}