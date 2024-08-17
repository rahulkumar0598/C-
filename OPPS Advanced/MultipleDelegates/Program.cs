public delegate void Calculation(int a, int b);
public delegate void Show();
public delegate void Calculation2(int num);
class Program
{
    public static void Show()
    {
        Console.WriteLine("Example for multiple delegates");
    }
    public static void Square(int num)
    {
        int square=num*num;
        Console.WriteLine($"Square of {square}");
    } public static void Cube(int num)
    {
        int Cube=num*num*num;
        Console.WriteLine($"Cube of {Cube}");
    }
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
        calculation.Invoke(20, 10);//30
        Calculation calculation1 = new Calculation(Program.Subtraction);
        calculation1.Invoke(20, 10);//10
        Calculation calculation2 = new Calculation(Program.Division);
        calculation2.Invoke(20, 10);//2
        Calculation calculation3 = new Calculation(Program.Multiplication);
        calculation3.Invoke(20, 10);//10
        Console.WriteLine();
        Show show = new Show(Program.Show);
        show.Invoke();
        Calculation2 calculation21 = new Calculation2(Program.Square);
        calculation21.Invoke(2);
        Calculation2 calculation22= new Calculation2(Program.Cube);
        calculation22.Invoke(2);

        //calculation = Subtraction;
        //calculation.Invoke(20, 10);//10
        //calculation = Division;
        //calculation.Invoke(20, 10);//2
        //calculation = Multiplication;
        //calculation.Invoke(20, 10);//200

    }
}