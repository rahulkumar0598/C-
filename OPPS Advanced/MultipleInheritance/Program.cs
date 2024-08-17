class Person
{
    public void show1()
    {
        Console.WriteLine("This is Person Class");
    }
}
interface IEmployee
{
    void show2();

}
class Teacher:Person,IEmployee
{
    public void show2()
    {
        Console.WriteLine("This is from Interface Employee");
    }
}
class Progam
{
    static void Main(string[] args)
    {
        Teacher teacher = new Teacher();
        teacher.show1();
        teacher.show2();

    }
}