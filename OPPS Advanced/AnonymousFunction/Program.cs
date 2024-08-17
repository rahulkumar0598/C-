public delegate void MyDelegate(int num);
class Program
{
    //public static void MyMethod(int a)
    //{
    //    a += 10;
    //    Console.WriteLine(a);
    //}  
    public static void MyMethod(MyDelegate del, int a)
    {
        a += 10;
        del.Invoke(a);
        Console.WriteLine(a);
    }

    static void Main(string[] args)
    {
        //MyDelegate obj=new MyDelegate(Program.MyMethod);
        //obj.Invoke(2);
        ////obj(3); you can used without invoke keyword
        ///Return type of anonymousFunction should be same as delegate
        //MyDelegate obj = delegate (int a)
        //{
        //    a += 10;
        //    Console.WriteLine(a);
        //};
        //obj(10);
        Program.MyMethod(delegate (int b)
        {
            b += 10;
            Console.WriteLine(b);
        }, 5);
        
    }
}