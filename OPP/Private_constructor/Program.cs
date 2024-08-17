class Example
{
    public static int a;

    public string name;
    //private Constructor
    private Example()
    {
    }
    ////Public constructor
    //public Example(string name)
    //{
    //    this.name = name;
    //}
    //public void GetData()
    //{
    //    Console.WriteLine(name);
    //}
    public static void getTime()
    {
        Console.WriteLine(DateTime.Now);
    }
    public static int getIncrement()
    {
        return a + 1;
    }
}

class Program
{

    static void Main(string[] args)
    {
        Example.getTime();
        Example.a = 10;
        Console.WriteLine(Example.getIncrement());
        //Example example = new("Ram");
        //Console.WriteLine(  );
        //example.GetData();
    }
}