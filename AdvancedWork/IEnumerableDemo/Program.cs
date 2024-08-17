using System.Collections;

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Standard { get; set; }
}
class School:IEnumerable
{
    List<Student> students=new List<Student>();
    public void Add(Student student)
    {
        students.Add(student);
    }

    public IEnumerator GetEnumerator()
    {
        return students.GetEnumerator();
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student std1= new Student();
        std1.Id = 1;
        std1.Name= "Test";
        std1.Standard = 12;

        Student std2 = new Student();
        std2.Id = 2;
        std2.Name= "Test1";
        std2.Standard = 11;

        Student std3 = new Student();
        std3.Id = 3;
        std3.Name = "Test3";
        std3.Standard = 10;
        School school= new School();
        school.Add(std1);
        school.Add(std2);
        school.Add(std3);
        foreach (Student item in school) 
        {
            Console.WriteLine(item.Id+" "+item.Name+" "+item.Standard);
        }

    }
}