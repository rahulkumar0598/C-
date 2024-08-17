class Program
{
    static void Main(String[] args)
    {
        int num = int.Parse(Console.ReadLine());
        for (int i = 0; i < num; i++)
        {
            Console.WriteLine();
            for (int j = num - i; j > 0; j--)
            {
                Console.Write("*");
            }
        }
    }
}