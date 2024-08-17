using System.Collections.Generic;

class parent
{
    public void show()
    {
        Console.WriteLine("Parent Method");
    }
}
class Child : parent
{
    public new void show()
    {
        //base.show();//First Way to call parent Method
        Console.WriteLine("Child Method");
    } 
    //public new void show1()
    //{
    //    //base.show();//First Way to call parent Method
    //    Console.WriteLine("Child Method");
    //}

}
class Program
{
    static void Main(string[] args)
    {
        //Child child= new Child();
        //((parent)child).show();//Second Way to call parent Method
        //Third Way to call parent Method
        parent p = new Child();
        p.show();

    }
}