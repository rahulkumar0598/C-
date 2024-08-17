class Student
{
    private string name;
    private int stdId;
    private int totalMaks = 100;
    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value) == true)
            {
                Console.WriteLine("Name is Required");
            }
            {
                this.name = value;
            }

        }
        get { return this.name; }   
    }
    public int StdId 
    {
        set
        {
            if (value>0)
            {
                this.stdId = value;
            }
            else
            {
                Console.WriteLine("please enter value");
            }
        }
        get { return this.stdId; }
        
    }
    public int TotalMaks
    {
        get
        {
            return this.totalMaks;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student student=new Student();
        student.Name = "Ram";
        Console.WriteLine(student.Name);
        student.StdId= 99;
        Console.WriteLine(student.StdId);
        Console.WriteLine(student.TotalMaks);
    }
}