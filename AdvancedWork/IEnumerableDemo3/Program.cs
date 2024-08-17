class Program
{
    static void show1(IEnumerator<int> i)
    {
        while (i.MoveNext())
        {
            Console.WriteLine(i.Current);
            if (i.Current > 44)
            {
                show2(i);
            }
        }
    }
    static void show2(IEnumerator<int> i) 
    {
        while (i.MoveNext())
        {
            Console.WriteLine("show2");
            Console.WriteLine(i.Current);
        }
    }
    static void show3(IEnumerable<int> i)
    {
        foreach (var item in i)
        {
            Console.WriteLine(item);
            if (item > 44)
            {
                show4(i);
            }

        }
    } static void show4(IEnumerable<int> i)
    {
        foreach (var item in i)
        {
            Console.WriteLine(item);

        }
    }

    static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { 21, 32, 54, 67, 78, 98 };
        //IEnumerable with linq query
        IEnumerator<int> nums = numbers.GetEnumerator();
        show1(nums);
        Console.WriteLine("<========================>");
        IEnumerable<int> number=(IEnumerable<int>)numbers;
        show3(number);
    }
}