class Program
{
    static void Main(string[] args)
    {
        string str=Console.ReadLine();
        int count = 0;
        int length=str.Length;
        for (int i = 0; i < length; i++)
        {
            count = 0;
            for(int j = 0; j < length-1;j++)
            {
                if (str[i] == str[0])
                {
                    count++;
                }
            }
            Console.WriteLine(str[i]+count);
            
            
        }        
        
    }
}