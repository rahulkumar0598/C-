class Program
{
    //Pass By Value
    public static void PassByValue(int a)
    {
        a = a + 10;
        Console.WriteLine($"value of {a}");//15
    }
    public static void PassByRef(ref int a)
    {
        a=a + 10;
        Console.WriteLine($"value of {a}");//15

    }
    public static void PassByOut(out int a)
    {
        a = 20;
        Console.WriteLine($"value is {a}");
    }
    static void Main(string[] args)
    {
        //Pass By Value
        int val = 5;
        PassByValue(val);//15
        Console.WriteLine(val);//5
        Console.WriteLine();
        //Pass By Reference
        PassByRef(ref val);//15
        Console.WriteLine(val);//15
        Console.WriteLine();
        //PassByOut
        int value;
        PassByOut(out value);//20
        Console.WriteLine(value);//20
    }
}