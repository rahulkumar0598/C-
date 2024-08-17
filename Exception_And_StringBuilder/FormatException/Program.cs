class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter Number");
        string number = Console.ReadLine();
        try
        {
            int num = int.Parse(number);
            Console.WriteLine(number);

        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
    } 
}