public delegate void Calculation(int a);
class Program
{
    public static void Addition(int a,int b)
    {
        int c = a + b;
        Console.WriteLine(c);
    }
   
    static void Main(string[] args)

    {
        Calculation calculation = delegate (int a)
        {
            a = a + 10;
            Console.WriteLine(a);

        };
        calculation(10);

    }
}