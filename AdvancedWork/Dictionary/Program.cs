using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int,int> map = new Dictionary<int,int>();
        map.Add(1, 21);
        map.Add(2, 31);  
        map.Add(3, 41);
        map.Add(4, 51);
        Console.WriteLine("_______________Accessing keys__________________\n"   );
        foreach (int item in map.Keys)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("_______________Accessing Values______________________\n");

        foreach (int item in map.Values)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("_______________Accessing Values from keys__________________\n");

        foreach (int item in map.Keys)
        {
            Console.WriteLine(map[item]);
        }
        Console.WriteLine("____________________________key Value pair property________\n");
        foreach (/*KeyValuePair<int,int>*/ var item in map)
        {
            Console.WriteLine($"Keys are {item.Key} and Values are {item.Value}");
        }
    }
}