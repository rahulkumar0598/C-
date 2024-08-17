class Program
{
    public static int[] reverse(int[] nums)
    {
        int[] temp = new int[nums.Length];
        var k = nums.Length-1;
        for (int i = nums.Length-1; i >=0; i--)
        {
            temp[k-i] = nums[i];
        }
        return temp;
    }
    public static int[] reverseEffecient(int[] nums)
    {
        var low = 0;
        var high = nums.Length-1;
        var temp =new int[high+1];

        while(low <= high)
        {
            temp[low] = nums[high-low];
            low++;
        }
        return temp;

    }
    public static int[] revMy(int[] nums)
    {
        int[] temp = new int[nums.Length];
        int a = nums.Length - 1;
        for(int i = 0; i < nums.Length; i++)
        {
            temp[i] = nums[a-1];
        }
        return temp;
    }

    static void Main(string[] args)
    {
        int[] nums1 = { 1, 12, 34, 56, 67 };
        foreach (var item in reverseEffecient(nums1))
        {
            Console.WriteLine(item);
        }
    }
}

