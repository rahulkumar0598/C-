
public delegate int MyDelegate(int x);

class Program
{
    static void Main(string[] args)
    {
        //Statement Lambda
        MyDelegate obj = (a) =>
        {
            a += 5;
            return a;
        };
        Console.WriteLine(obj(5));
        //Expression Lambda
        MyDelegate obj1 = (a) => a * a;
        Console.WriteLine(obj1(5));

    }
}