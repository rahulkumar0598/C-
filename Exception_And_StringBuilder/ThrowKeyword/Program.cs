class Program
{
    static void Main(string[] args)
    {
        //try
        //{
        //    int age = int.Parse(Console.ReadLine());
        //    if (age > 18)
        //    {
        //        Console.WriteLine("You are Eligible to vote");
        //    }
        //    else
        //    {
        //        throw new Exception("You are not Eligible");
        //    }
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        int accountBalance = 5000;
        int withDrawl = 6000;
        try
        {
            if (accountBalance < withDrawl)
            {
                throw new Exception("Insufficent Balence");
            }
            else
            {
                accountBalance -= withDrawl;
                Console.WriteLine($"Remainig balance is {accountBalance}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}