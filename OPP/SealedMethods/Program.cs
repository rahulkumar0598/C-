class A
{
    public virtual void Print()
    {
        Console.WriteLine("Class A");
    }
}
class B : A
{
    public sealed override void Print()
    {
        Console.WriteLine("class B");
    }
}
class C : B
{
    public override void Print()
    {
        Console.WriteLine("class C");
    }
}
class Program
{
    static void Main(string[] args)
    {
        A a = new B();
        a.Print();
        C c = new C();
        c.Print();
    }
}