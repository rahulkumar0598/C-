class Program
{
    static void Main(string[] args)
    {
        try
        {
            string name = null;
            Console.WriteLine(name.Length);
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("String is nUll");
        }
        
        

    }
}