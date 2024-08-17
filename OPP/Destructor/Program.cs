class Person
{
    public string Name;
    public int Age;
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
    public string getName()
    {

        return this.Name;
    }
    public int getAge()
    {
        return this.Age;
    }
    ~Person()
    {
        Console.WriteLine("Destrucor has been invoked");
    }
}
class Program

{
    static void Main(string[] args)
    {
        Person person = new("ram", 32);
        Console.WriteLine(person.getName());
        Console.WriteLine(person.getAge());
        Console.WriteLine("-----------------------");
        Person person1 = new("sam", 44);
        Console.WriteLine(person1.getName());
        Console.WriteLine(person1.getAge());
    }
}