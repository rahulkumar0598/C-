class Parent
{
    public virtual void print()
    {
        Console.WriteLine("Parent Class");
    }
}class Child:Parent
{
    public override void print()
    {
        //base.print();
        Console.WriteLine("Child Class");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Parent p= new Child();
        p.print();
    }
}