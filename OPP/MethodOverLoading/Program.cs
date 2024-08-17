class Program
{
    public void Add()
    {
        int a = 20;
        int b = 40;
        int c = a + b;
        Console.WriteLine(c);
    }
    public void Add(int a,int b)
    {
        
        int c = a + b;
        Console.WriteLine(c);
    }
    public void Add(string a, string b)
    {

        string c = a + b;
        Console.WriteLine(c);
    }

    static void Main(string[] args)
    {
        Program program=new Program();
        program.Add(20,30);
    }
}