public delegate T Cal<T>(T a);
class Example<T>
{
    T box;
    T ID;
    public T _ID
    {
        set => this.ID = value;
        get => this.ID;
    }

    public Example(T b)
    {
        this.box = b;
    }
    public T getBox()
    {
        return this.box;
    }
}
class Program
{
    public static T Add<T>(T a)
    {
        Console.WriteLine(a);
        return a;
    }
    static void Main(string[] args)
    {
        Example<int> example = new Example<int>(20);
        Console.WriteLine(example.getBox());
        Example<string> example1 = new Example<string>("Ram");
        Console.WriteLine(example1.getBox());
        example1._ID = ("99");
        Console.WriteLine(example1._ID);
        Cal<int> cal = new Cal<int>(Program.Add);
        cal.Invoke(53445);

    }
}