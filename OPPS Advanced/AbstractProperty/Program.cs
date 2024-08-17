abstract class Person
{
  
    public abstract uint Id { get; set; }
    public abstract string Name { get; set; }
}
class Student : Person
{
    uint StudnetId;
    string Studentname;
    public override uint Id
    {
        set
        {
            if (value == 0)
            {
                Console.WriteLine("Id Not be  Zero");
            }
            else
            {
                this.StudnetId = value;
            }
        }
        get => this.StudnetId;
    }
    public override string Name
    {
        set
        {
            if ((string.IsNullOrEmpty(value)) == true)
            {
                Console.WriteLine("Name not be empty");
            }
            else
            {

                this.Studentname = value;
            }
        }
        get => this.Studentname;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();
        student.Name = "Ram";
        student.Id = 1;
        Console.WriteLine($"Name is {student.Name} and Id is {student.Id}");
    }
}