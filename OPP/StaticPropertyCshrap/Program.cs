class Student
{
    static string UniversityName;
    static string DepartmentName;
    public static string _UniversityName
    {
        set
        {
            if (string.IsNullOrEmpty(value) == true)
            {
                Console.WriteLine("Universtiy Name is Required");
            }
            else
            {
                UniversityName = value;
            }
        }
        get
        {
            return UniversityName;
        }
    }
    public static string _DepartmentName
    {
        set
        {
            if (string.IsNullOrEmpty(value) == true)
            {
                Console.WriteLine("Department Name is Required");
            }
            else
            {
                DepartmentName = value;
            }
        }
        get
        {
            return DepartmentName;
        }
    }

}
class Program
{
    static void Main(string[] args)
    {
        Student._DepartmentName = "MMUT";
        Student._UniversityName = "MMMUT";
        Console.WriteLine(Student._DepartmentName);
        Console.WriteLine(Student._UniversityName);
    }
}