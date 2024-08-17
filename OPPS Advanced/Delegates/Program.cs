public delegate void Calculation(int a, int b);
class Program
{
    public static void Addition(int a,int b)
    {
        int result = a + b;
        Console.WriteLine(result);
    }public static void Division(int a,int b)
    {
        int result = a / b;
        Console.WriteLine(result);
    }
    public static void Subtraction(int a,int b)
    {
        int result = a - b;
        Console.WriteLine(result);
    }
    public static void Multiplication(int a,int b)
    {
        int result = a * b;
        Console.WriteLine(result);
    }

    static void Main(string[] args)
    {
        Calculation calculation = new Calculation(Program.Addition);
        calculation.Invoke(20, 10);//30
        Calculation calculation1 = new Calculation(Program.Subtraction);
        calculation1.Invoke(20, 10);//10
        Calculation calculation2 = new Calculation(Program.Division);
        calculation2.Invoke(20, 10);//2
        Calculation calculation3 = new Calculation(Program.Multiplication);
        calculation3.Invoke(20, 10);//10

        //calculation = Subtraction;
        //calculation.Invoke(20, 10);//10
        //calculation = Division;
        //calculation.Invoke(20, 10);//2
        //calculation = Multiplication;
        //calculation.Invoke(20, 10);//200

    }
}