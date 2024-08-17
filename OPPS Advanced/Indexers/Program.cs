
class Employee
{
    private int[] age = new int[3];
    public int this[int index]
    {
        set
        {
            /* set the specified index to value here */
            if (index >= 0 && index < age.Length)
            {
                if (value > 0)
                {
                    age[index] = value;
                }
                else
                {
                    Console.WriteLine("value is invalid");
                }
            }
            else
            {
                Console.WriteLine("Invalid Index");
            }
        }
        get
        {
            /* return the specified index here */
            return age[index];

        }

    }
    public int this[int index, int i]
    {
        set
        {
            /* set the specified index to value here */
            age[index] = value + i;
        }
        get
        {
            /* return the specified index here */
            return age[index];
        }


    }

}
class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee();
        employee[0] = 5;
        employee[1] = 6;
        employee[2, 1] = 8;//first argument for index and second
                           //argument for increment by the value
        Console.WriteLine(employee[0]);
        Console.WriteLine(employee[1]);
        Console.WriteLine(employee[2]);



    }
}