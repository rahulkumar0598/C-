interface i1
{
    void show();
}
interface i2
{
    void show();
}
//Implict Interface
//class MyClass : i1
//{
//    public void show()
//    {
//        Console.WriteLine("Implict Interface");
//    }
//}

//Explict Implementation
class MyClass : i1, i2
{
    void i1.show()
    {
        Console.WriteLine(" Interface 1");
    }
    void i2.show()
    {
        Console.WriteLine(" Interface 2");
    }
}
class Program
{
    static void Main()
    {
        ////First Way
        //MyClass obj = new MyClass();
        ////Converting Class reference variable to interafce reference variable
        //((i1)obj).show();
        //((i2)obj).show();
        //SecondWay
        i1 obj1 = new MyClass();
        obj1.show(); 
        i2 obj2 = new MyClass();
        obj2.show();
    }
}