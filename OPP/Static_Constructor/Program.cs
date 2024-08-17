class Person
{
    public static string PersonName;
    public static int PersonAge;
    static Person()
    {
        PersonName = "Ram";
        PersonAge = 22;
        Console.WriteLine("Static Const Invoke");
    }
    public Person()
    {
        Console.WriteLine("Defaut constructor invoke....");
    }
    public void GetDetails()
    {
        Console.WriteLine($"Person Name is {PersonName}");
        Console.WriteLine($"Person Age is {PersonAge}");
    }
}
class Program
{
    static void Main(string[] args)
    {

        Person person = new();
        person.GetDetails();
        Person person1 = new();

    }
}