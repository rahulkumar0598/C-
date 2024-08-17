
class Program
{
    //public static int add(int x,int y)
    //{
    //    return x + y;
    //}
    public static int add(params int[] nums)
    {
        int sum = 0;
        foreach (var item in nums)
        {
            sum = sum + item;
        }
        return sum;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(Program.add(23,36,342,432,45,2));
        
    }
}