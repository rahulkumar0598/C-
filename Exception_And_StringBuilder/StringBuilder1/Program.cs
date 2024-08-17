using System.Text;

class Program
{
    static void Main(string[] args)
    {
        //StringBuilder stringBuilder = new StringBuilder();
        StringBuilder stringBuilder = new StringBuilder("Hello World");
        stringBuilder.Insert(5, " C#");
        stringBuilder.Remove(8, 6);//Remove(start index,End Index)
        stringBuilder.Replace("C#", "World");//Replace(serach what you replace, search which youreplace)
       
        //stringBuilder.AppendLine(" Samer");
        //stringBuilder.Append("Samosa");
        //Console.WriteLine(stringBuilder.Capacity);
        //Console.WriteLine(stringBuilder);
        //stringBuilder.AppendFormat("{0:C}", 25);
        //stringBuilder.AppendFormat("{0:N}", 25);
        //stringBuilder.AppendFormat("{0:X}", 25);
        Console.WriteLine(stringBuilder);

    }
}