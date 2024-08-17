Console.WriteLine("How many items you stored in array");
int num = int.Parse(Console.ReadLine());
int[] number = new int[num];
for (int i = 0; i < number.Length; i++)
{
    Console.WriteLine($"Enter data {i+1 }");
    //int data = int.Parse(Console.ReadLine());
    //number[i] = data;
    number[i]=Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("\n----------Your data --------- \n");
for (int i = 0; i < number.Length; i++)
{
    Console.Write(number[i] + " ");
}