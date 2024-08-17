class Employee
{
    int EmpID;
    string EmpName;
    double GrossPay;
    double TaxDeduction = .1;
    double netSalary;
    public Employee(int Eid, string Ename, double EGrossPay)
    {
        this.EmpID = Eid;
        this.EmpName = Ename;
        this.GrossPay = EGrossPay;
    }
    void CalaculateSalary()
    {
        if (GrossPay > 30000)
        {
            netSalary = GrossPay - (TaxDeduction * GrossPay);
            Console.WriteLine(netSalary);
        }
        else
        {
            Console.WriteLine(GrossPay);
        }
    }
    public void shoEmpDetails()
    {
        Console.WriteLine(EmpID);
        Console.WriteLine(EmpName);
        Console.WriteLine(GrossPay);
        this.CalaculateSalary();
        Console.WriteLine("____Next One _______________");
    }


}
class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee(1, "Ram", 21000);
        employee.shoEmpDetails();
        Employee employee1 = new Employee(2, "Ram", 31000);
        employee1.shoEmpDetails();

    }
}