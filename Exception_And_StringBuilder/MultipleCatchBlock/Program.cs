class Program
{
    static void Main(string[] args)
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
        catch(NullReferenceException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(OverflowException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}