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
        string[] members = (string[])Enum.GetNames(typeof(Days));
        int[] values = (int[])Enum.GetValues(typeof(Days));
        foreach (var member in members)
        {
            Console.WriteLine(member);
        }
        foreach (var value in values)
        {
            Console.WriteLine(value);
        }
    }
}