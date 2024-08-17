enum Days { 
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
        //Console.WriteLine(Days.Sunday);
        Days birthDay= Days.Sunday;
        Console.WriteLine(birthDay);
        Days myDay = (Days)1;//convert int to enum
        Console.WriteLine(myDay);
        int value = (int)Days.Saturday;// convert enum to int
        Console.WriteLine(value);

    }
}