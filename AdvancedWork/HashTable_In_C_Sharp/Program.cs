using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        //Defining hashTable In First Way
        Hashtable ht= new Hashtable();
        ht.Add("Id", 2113);
        ht.Add("Name", "Ram");
        ht.Add("Salary", 25000.0);
        ht.Add("Designation", "Manager");
        Console.WriteLine(ht["Id"]);

        //Defining hashTable In First Way
        Hashtable ht1 = new Hashtable()
        {
            {"Id",213 },
            {"Name","Ram" },
            {"Salary", "Manager"}
        };
        ht1.Remove("Id");
        Console.WriteLine("Accesing Keys");
        foreach (var item in ht.Keys)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine(  "Accessing Values");
        foreach (var item in ht.Keys)
        {
            Console.WriteLine(ht[item]);
        }
        Console.WriteLine("Accessing Values with values property");

        foreach (var item in ht.Values)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("-------Clear Property---");
        ht.Clear();
        foreach (var item in ht.Values)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine( ht1.ContainsValue(223));

        Console.WriteLine("213".GetHashCode());
        Console.WriteLine(ht1.Count);
    }
}