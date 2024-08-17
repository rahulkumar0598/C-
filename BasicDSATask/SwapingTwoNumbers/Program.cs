class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"a= {a}");
        Console.WriteLine($"b= {b}");
        a = a + b;//20+30=50
        b = a - b;//50-30=20
        a = a - b;//50-20=30
        Console.WriteLine("After Swapping");
        Console.WriteLine($"a= {a}");
        Console.WriteLine($"b= {b}");
    }
}