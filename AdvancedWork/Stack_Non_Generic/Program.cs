using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("___________________PUSH()_______________");
        Stack stack = new Stack();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);
        stack.Push(6);
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("______________POP()_________________");
        stack.Pop();
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("______________Contains()___________________");
        Console.WriteLine(stack.Contains(1));
        Console.WriteLine(stack.Count);
        Console.WriteLine("--------------Peek()_________________");
        Console.WriteLine(stack.Peek());
        stack.Clear();
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    }
}