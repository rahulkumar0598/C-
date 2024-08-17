enum Days
{
    Sunday,//0
    Monday,//1
    Tuesday,//2
    Wednesday,//3
    Thursday,//4
    Firday,//5
    Saturday//6
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter your name");
        string name=Console.ReadLine();
        Console.WriteLine("Enter your day Sunday=0,Monday=1,Tuesday=2");
        int value=int.Parse(Console.ReadLine());
        Days days= (Days)value;
        Console.WriteLine($"My name is {name} and my birthday is {days}");
    }
}