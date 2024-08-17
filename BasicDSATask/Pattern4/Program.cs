class Program
{
    static void Main(string[] args)
    {
        int num = 5;
        for (int i = 0; i <num; i++)
        {
            Console.WriteLine();
            for (int j = num-1; j > i; j--)
            {
                Console.Write(" ");
            }
            for (int k = 2*i-1; k >0; k--)
            {
                Console.Write("*");
            }
        }
    }
}