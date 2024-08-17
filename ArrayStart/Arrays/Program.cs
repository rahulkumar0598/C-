int[] my_array= new int[4];//declaration of array 1st type
my_array[0] = 11;
my_array[1] = 12;
my_array[2] = 13;
my_array[3] = 14;
Console.WriteLine(my_array.Length);
Console.WriteLine(my_array.FirstOrDefault());
Console.WriteLine(my_array.Last());

Console.WriteLine(my_array.First());
Console.WriteLine("\n for string");
string[] my_array_string=new string[] {"ram","sam","gam"};//declaration of array 2nd type
foreach (var item in my_array_string)
{
    Console.WriteLine(item);
}
Console.WriteLine(my_array_string.Length+ "\n");
//float array
float[] my_array_float = { 23.34f, 7234.32f, 346.23f };//declaration of array 3rd type
Console.WriteLine(my_array_float.Length);