using ListGeneric;

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee()
        {
            Name = "Ram",
            Age = 30,
            Desgination = "Manager"
        }; Employee employee1 = new Employee()
        {
            Name = "RamAs",
            Age = 300,
            Desgination = "Managing"
        };
        List<Employee> EmplIst = new List<Employee>();
        EmplIst.Add(employee1);
        EmplIst.Add(employee1);
        foreach (var item in EmplIst)
        {
            Console.WriteLine($"Employee Name is {item.Name} " +
                $"Age is {item.Age} Desig is {item.Desgination}");

        }
        Console.WriteLine();
        Employee emp = EmplIst.Find(e => e.Age > 30);
        Console.WriteLine($"Employee Name is {emp.Name} " +
                $"Age is {emp.Age} Desig is {emp.Desgination}");
        Console.WriteLine();
        Employee emp1 = EmplIst.FindLast(e => e.Age > 30);
        Console.WriteLine($"Employee Name is {emp.Name} " +
                $"Age is {emp.Age} Desig is {emp.Desgination}");
        Console.WriteLine();
        List<Employee> emp2 = EmplIst.FindAll(e => e.Age > 30);
        foreach (var item in emp2)
        {


            Console.WriteLine($"Employee Name is {item.Name} " +
                    $"Age is {item.Age} Desig is {item.Desgination}");
        }
        Console.WriteLine();
        Console.WriteLine(EmplIst.FindIndex(e=>e.Age>31));
        Console.WriteLine("\n---------------------------------------\n");
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine(list.Capacity);
        list.Add(4);
        list.Add(5);
        list.Add(6);
        Console.WriteLine();
        Console.WriteLine(list.Capacity);
        Console.WriteLine(list.Count);
        list.Sort();
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        List<int> ints = new List<int>()
        {
            523,27,127
        };
        Console.WriteLine();
        list.AddRange(ints);
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        list.Insert(5, 87);
        list.InsertRange(0, ints);
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        list.Remove(5);
        list.RemoveAt(2);
        list.RemoveRange(0, 1);
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        list.RemoveAll(li => li > 126);
        Console.WriteLine("RemoveList" +
            "");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine(EmplIst.Exists(emp => emp.Name.StartsWith("p")));
        Console.WriteLine();
        Console.WriteLine(list.IndexOf(6));
        Console.WriteLine(list.IndexOf(22, 2));
        Console.WriteLine();
        Console.WriteLine(list.LastIndexOf(1));
        Console.WriteLine(list.LastIndexOf(27, 1));
        Console.WriteLine();

    }
}