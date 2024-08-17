using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Queue queue = new Queue();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);
        queue.Enqueue(6);
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("__________________Dequeue______________________________");
        queue.Dequeue();
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("_____________________Contains()___________________________");
        Console.WriteLine(queue.Contains(5));
        Console.WriteLine("______________________Count()__________________________");
        Console.WriteLine(queue.Count);
        Console.WriteLine("___________________Peek()_____________________________");
        Console.WriteLine(queue.Peek());
        Console.WriteLine("______________________Clear()__________________________");
        //queue.Clear();
        while(queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
       
    }
}