class Student
{
    //Auto implemented property
    public int Id { get; private set; }
    public string Name { get; private set; }
    public Student(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student student = new(2,"Ram");
        Console.WriteLine(student.Id);
        Console.WriteLine(student.Name);

    }
}