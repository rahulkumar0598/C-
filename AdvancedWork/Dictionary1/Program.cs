using Dictionary1;

class Program
{
    static void Main(string[] args)
    {
        Employee emp1 = new Employee() 
        {
            Name= "Aman",
            Designation="Manager",
            Salary=2000
        };
        Employee emp2 = new Employee() 
        {
            Name= "Aman2",
            Designation="Manager2",
            Salary=20000
        };
        Employee emp3 = new Employee() 
        {
            Name= "Aman3",
            Designation="Manager3",
            Salary=200000
        };
        Dictionary<int,Employee> empDict= new Dictionary<int,Employee>();
        empDict.Add(1, emp1);
        empDict.Add(2, emp2);
        empDict.Add(3, emp3);
        Console.WriteLine("_-----Count() overloaded_________");
        Console.WriteLine(empDict.Count(e=>e.Value.Salary>20000));
        Console.WriteLine(empDict.Count(e=>e.Value.Name.StartsWith("A")));
        
        Console.WriteLine("_______________________________ENd_____________________\n\n");
        Dictionary<int, int> map = new Dictionary<int, int>();
        map.Add(1, 21);
        map.Add(2, 22);
        map.Add(3, 23);
        map.Add(4, 24);
        map.Add(5, 25);
        map.Add(6, 26); 
        Console.WriteLine("Count method");
        Console.WriteLine(map.Count);
        map.Remove(5);
        foreach (var item in map)
        {
            Console.WriteLine($"Key is {item.Key} and pair is {item.Value}");
        }
        //Console.WriteLine(map.ContainsKey(6));
        Console.WriteLine(map.ContainsValue(26));
        Console.WriteLine();
        if (map.ContainsKey(6))
        {
            Console.WriteLine("Key Found");
        }
        else
        {
            Console.WriteLine("Not Found");
        }
        Console.WriteLine("\n\n__________TryGetValue___________");
        //int value;
        //map.TryGetValue(6, out value);
        //Console.WriteLine(value);
        int value;
        if(map.TryGetValue(6, out value))
        {
            Console.WriteLine(value);
        }
        else
        {
            Console.WriteLine("Key not found");
        }

        Console.WriteLine("\n------Clear________");
        map.Clear();
        foreach (var item in map)
        {
            Console.WriteLine($"Key is {item.Key} and pair is {item.Value}");
        }
    }
}