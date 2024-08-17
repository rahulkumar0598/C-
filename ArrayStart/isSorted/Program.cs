class Program
{
    public static bool isSorteds(int[] arr)
    {
        for(int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < arr[i - 1])
            {
                return false;
            }
        }
        return true;
    }
    static void Main(string[] args)
    {
        int[] arr = { 23, 43, 45, 65 };
        Console.WriteLine(isSorteds(arr));
    }
}