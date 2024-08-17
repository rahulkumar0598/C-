class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[3];
        try
        {
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine(  "Array Range is exceed");
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("Statemnet 1");
    }
}