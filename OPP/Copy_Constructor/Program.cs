class Example
{
    string name;
    int age;
    public Example(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    //Declaring an copy constructor
    public Example(Example e)
    {
        this.name = e.name;
        this.age = e.age;
    }

    public void GetData()
    {
        Console.WriteLine($"Name is {name}");
        Console.WriteLine($"Age is {age}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Example example = new("Ram",22);
        example.GetData();
        Console.WriteLine("Using of copy constructor");
        Example example1 = new(example);
        example1.GetData();
    }
}