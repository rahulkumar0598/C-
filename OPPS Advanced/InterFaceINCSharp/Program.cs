interface IEmployee
{
    void show();
}
class PTE : IEmployee
{
    public void show()
    {
        Console.WriteLine("This is method of IEMPLoyee Interface");
    }
}
class Program
{
    static void Main(string[] args)
    {
        PTE pTE = new PTE();
        pTE.show();
    }
}