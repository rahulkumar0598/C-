using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        ArrayList arrayList= new ArrayList(3);
        arrayList.Add(1);
        arrayList.Add("Ram");
        arrayList.Add("Ram");
        arrayList.Add("Ram");
        Console.WriteLine(arrayList.Capacity);
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        arrayList.Insert(2, 25);
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }
        arrayList.Remove("Ram");
        Console.WriteLine();
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        arrayList.RemoveAt(3);
        
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }
        arrayList.RemoveAt(2);
        foreach (var item in arrayList)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine( arrayList.Capacity);


    }
}