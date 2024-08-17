class Program
{
    static void Main(string[] args)
    {
        List<int> numbers=new List<int>() { 21,32,54,67,78,98};
        //IEnumerable with linq query
        var nums = from i in numbers where i > 44 select i;
        
        foreach(var i in numbers)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine("----------------------------");
        IEnumerator<int> num = numbers.GetEnumerator();

        while(num.MoveNext())
        {
            Console.WriteLine(num.Current.ToString());
        }
    }
}