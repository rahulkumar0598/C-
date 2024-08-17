interface i1
{
    void print1();
}interface i2
{
    void print2();
}interface i3:i1,i2
{
    void print3();
}
class Program:i3
{
    public void print3()
    {
        Console.WriteLine("print 3");
    }public void print1()
    {
        Console.WriteLine("print 1");
    }
    public void print2()
    {
        Console.WriteLine("print 2");
    }
    static void Main(string[] args)
    {
        //Program p = new();
        //p.print1();
        //p.print2();
        //p.print3();
        ////i3 myInterface = new Program();
        ////myInterface.print1();
        ////myInterface.print2();
        ////myInterface.print3();
        i3 myInterface = new Program();
        myInterface.print2();
        
        
    }
}