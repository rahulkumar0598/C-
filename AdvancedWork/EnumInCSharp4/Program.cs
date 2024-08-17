enum Days
{
    Sunday,//0
    Monday,//1
    Tuesday,//2
    Wednesday,//3
    Thursday,//4
    Firday,//5
    Saturday//6
}
class Program
{
    static void Main(string[] args)
    {
        Days myDay = Days.Firday;
        //int mydays = (int)Days.Sunday;
        //Console.WriteLine(mydays);
        switch (myDay)
        {
            case Days.Sunday:
                Console.WriteLine("Hello this sunday");
                break;
            case Days.Monday:
                Console.WriteLine("Hello this monday");

                break;
            case Days.Tuesday:
                Console.WriteLine("Hello this Tuesday");
                break;
            case Days.Wednesday:
                Console.WriteLine("Hello this Wednesday");
                break;
            case Days.Thursday:
                Console.WriteLine("Hello this Thursday");
                break;
            case Days.Firday:
                Console.WriteLine("Hello this Friday");
                break;
            case Days.Saturday:
                Console.WriteLine("Hello this Saturday");
                break;
            default:
                Console.WriteLine("Hello this unvalid days");
                break;
        }
    }
}