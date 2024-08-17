int num=int.Parse(Console.ReadLine());
for(int i=0; i < num; i++)
{
	Console.WriteLine();
	for (int j = 0; j < num-i; j++)
	{
		Console.Write(" ");
	}
	for (int k = 0; k < i+1; k++)
	{
		Console.Write("*");
	}
}