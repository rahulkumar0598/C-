class NewClass
{
    public string str;
    public int num;
    public static NewClass operator +(NewClass obj1, NewClass obj2)
    {
        NewClass obj3 = new();
        obj3.str = obj1.str +" "+ obj2.str;
        obj3.num = obj1.num + obj2.num;
        return obj3;
    }

}
class Program
{

    static void Main(string[] args)
    {
        NewClass newClass = new();
        newClass.str = "Ram";
        newClass.num = 2;
        NewClass newClass1 = new();
        newClass1.str = "Sam";
        newClass1.num = 3;
        NewClass newClass2 = new();
        newClass2 = newClass1 + newClass;
        Console.WriteLine(newClass2.num);
        Console.WriteLine(newClass2.str);
    }
}