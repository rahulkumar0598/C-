public class class1
{
    public void show1()
    {
        Console.WriteLine("Public Class");
    }
    public void show2() {
        class1 Class1= new class1();
        Class1.show1();
            }
}


class Program:class1
{
    static void Main(string[] args)
    {
        class1 @class=new class1();
        @class.show2();
        Program p1= new Program();  
        p1.show1();
    }
}