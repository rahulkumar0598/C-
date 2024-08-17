class Program
{
    //non static method
    public void Show()//Declaring  a method //non static method // non Paramiterized method
    {
        Console.WriteLine("Welcome to C# intance");
    }
    public static void Show1()//Declaring  a method //static method // non Paramiterized method
    {
        Console.WriteLine("Welcome to C# static");
    }
    public static void Show2(int a, int b)//Declaring  a method //static method //  Paramiterized method
    {
        int c = a + b;
        Console.WriteLine(c);
    }
    public static void show_NameAge(string name, int age)//calling method
    {
        Console.WriteLine($"Your name: {name}");
        Console.WriteLine($"Your age :{age}\n");
    }

    static void Main(string[] args)
    {
        Program p1 = new();
        //Program p1= new Program();
        p1.Show();
        Program.Show1();
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Program.Show2(a, b);
        Program.show_NameAge("Ram", 23);//call method
        Program.show_NameAge(age: 27, name: "Rahul");//named argument



    }

}


