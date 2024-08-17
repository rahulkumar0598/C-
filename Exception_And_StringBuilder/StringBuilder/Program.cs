using System.Diagnostics;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Stopwatch sw1= new Stopwatch();
        sw1.Start();
        string s1 = "ram";
        for (int i = 0; i < 100000; i++)
        {
            s1 = s1 + i;
        }
        sw1.Stop();
        Stopwatch sw2= new Stopwatch();
        sw2.Start();
        StringBuilder stringBuilder= new StringBuilder("Hello");
        for (int i = 0; i < 100000; i++)
        {
            s1 = s1 + i;
        }
        sw2.Stop();
        Console.WriteLine($"Time taken by string {sw1.ElapsedMilliseconds}");
        Console.WriteLine($"Time taken by stringDuilder {sw2.ElapsedMilliseconds}");
    }
}