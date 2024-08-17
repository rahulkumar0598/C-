class Program
{
    static void Main(string[] args)
    {
        string a = Console.ReadLine();//jaj
        string reverse = "";
        for (int i = a.Length - 1; i > -1; i--)
        {
            reverse = reverse + a[i];
        }
        Console.WriteLine(reverse);
        if (a.ToUpper() == reverse.ToUpper())
        {
            Console.WriteLine("It is Palindrome");
        }
        else
        {
            Console.WriteLine("It is not Palindrome");
        }

        //Second Way
        Console.WriteLine("Enter a string");
        string str = Console.ReadLine();

        char[] arr = str.ToCharArray();//converting string into character
        Array.Reverse(arr);
        string str_reverse = new string(arr);//converting array to string

        if (str.ToLower().Equals(str_reverse.ToLower()))
        {
            Console.WriteLine(str+" --> It is Palindrome");
        }
        else
        {
            Console.WriteLine(str+" --> It is not Palindrome");

        }

    }
}