class Person
{
    private int Age;
    private string Name;
    public void setName(string name)
    {
        if (string.IsNullOrEmpty(name) == true)
        {
            Console.WriteLine("Name is Required");
        }
        else
        {
            this.Name = name;
        }
    }
    public void setAge(int age)
    {
        if (age > 0)
        {
            this.Age = age;
        }
        else
        {
            Console.WriteLine("age should be greater than 0");
        }
    }

    public void getAge()
    {
        if (this.Age > 0)
        {
            Console.WriteLine(this.Age);
        }
        else { }

    }
    public void getName()
    {
        if (string.IsNullOrEmpty(this.Name) == true)
        {
        }
        else
        {
            Console.WriteLine(this.Name);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.setName("Ram");
        person.setAge(23);
        person.getAge();
        person.getName();

    }
}