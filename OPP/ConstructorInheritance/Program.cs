class BaseClass
{
    public BaseClass(string message)
    {
        Console.WriteLine("This is the construcor of base class");
        Console.WriteLine(message);
    }
}
class DerivedClass : BaseClass
{
    //public DerivedClass():base
    public DerivedClass():base("hello C#")
    {
        Console.WriteLine("This is the construcor of Derved class");
    }
}
class Program
{
    static void Main(string[] args)
    {
        //BaseClass baseClass=new DerivedClass();
        DerivedClass derivedClass = new DerivedClass();

    }
}