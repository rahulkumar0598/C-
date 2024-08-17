class Employee
{
    public int EmployeeId;  
    public string EmployeeName;
    public int EmployeeAge;
    public void show()
    {
        Console.WriteLine("Method of base class");
    }
 
}
class PermEmployee:Employee
{
    public int PermEmployeeHours;
    public int PermEmployeeSalary;
}
class TempEmployee:Employee
{
    public int TempEmployeeHours;   
    public int TempEmployeeSalary;
}
class Program
{
    static void Main(string[] args)
    {
        Employee employee=new Employee();
        PermEmployee permEmployee=new PermEmployee();
        permEmployee.EmployeeAge= 20;
        TempEmployee tempEmployee=new TempEmployee();
        tempEmployee.EmployeeAge= 30;
        Console.WriteLine(permEmployee.EmployeeAge);
        Console.WriteLine(tempEmployee.EmployeeAge);
        permEmployee.show();    
        tempEmployee.show();
        
    }
}