class Program
{
    public static int findMax(int[] arr)
    {
        var res = 0;
        for(int i=1;i<arr.Length;i++)
        {
            if (arr[i] > res)
            {
                res = arr[i];
            }
        }
        return res;
    }
    static void Main(string[] args)
    {
        int[] arr = { 12, 224, 24, 25, 88 };
        Console.WriteLine(findMax(arr));
    }
}