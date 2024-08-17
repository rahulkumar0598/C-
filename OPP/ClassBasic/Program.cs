struct Employee
{
    public int Salary { get; set; } 
    public int Age { get; set; }

}
class Employees
{
    public int Salary { get; set; } 
    public int Age { get; set; }

}

class Program
{
    public static void Main(string[] args)
    {
        //struct for value type
        Employee employee = new Employee();
        employee.Salary = 100;
        employee.Age = 18;
        Employee employee1 = employee;
        Employee employee2 = employee;
        employee.Age = 25;
        Console.WriteLine(employee.Age);
        Console.WriteLine(employee1.Age);
        Console.WriteLine(employee2.Age);
        //Class for reference type
        Console.WriteLine();
        Employees employees = new Employees();
        employees.Salary = 100;
        employees.Age = 18;
        Employees employees1 = employees;
        Employees employees2 = employees;
        employees.Age = 25;
        Console.WriteLine(employees.Age);
        Console.WriteLine(employees1.Age);
        Console.WriteLine(employees2.Age);
        

    }

}