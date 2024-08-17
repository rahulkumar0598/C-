public delegate void Calculation(int a, int b);
class Program
{
    public static void Addition(int a, int b)
    {
        int result = a + b;
        Console.WriteLine(result);
    }
    public static void Division(int a, int b)
    {
        int result = a / b;
        Console.WriteLine(result);
    }
    public static void Subtraction(int a, int b)
    {
        int result = a - b;
        Console.WriteLine(result);
    }
    public static void Multiplication(int a, int b)
    {
        int result = a * b;
        Console.WriteLine(result);
    }

    static void Main(string[] args)
    {
        Calculation calculation = new Calculation(Program.Addition);
        calculation += Subtraction;
        calculation += Multiplication;
        calculation += Division;
        calculation.Invoke(100, 20);
        Console.WriteLine("Removing Division from delegate");
        calculation -= Division;
        calculation.Invoke(8, 2);


    }
}