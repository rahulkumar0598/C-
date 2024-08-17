class Example
{
    public static void ShowArray<T>(T[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
    public static bool Check<T>(T a, T b)
    {
        bool c = a.Equals(b);
        return c;
    }
}
class Program
{
    static void Main(string[] args)
    {
        int[] Numbers = { 1, 2, 3, 4 };
        Example.ShowArray(Numbers);
        string[] names = { "Ram", "Sam", "Kam" };
        Example.ShowArray(names);
        double[] Points = { 2.3, 4.5, 2.2 };
        Example.ShowArray(Points);
        Console.WriteLine(Example.Check(100, 100));
        Console.WriteLine(Example.Check("Rams", "Ram"));
    }
}
//class Eample
//{
//    public static void showArray(int[] arr)
//    {
//        for (int i = 0; i < arr.Length; i++)
//        {
//            Console.WriteLine(arr[i]);
//        }
//    }public static void showArray(string[] arr)
//    {
//        for (int i = 0; i < arr.Length; i++)
//        {
//            Console.WriteLine(arr[i]);
//        }
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] num = new int[3];
//        num[0] = 1;
//        num[1] = 2;
//        num[2] = 3;
//        Eample.showArray(num);
//        string[] Names = { "Ram", "Sam", "Kam" };
//        Eample.showArray(Names);
//    }
//}

