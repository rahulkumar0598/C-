int num = 5;
for (int i = 0; i < num; i++)
{
	for (int j = 0; j < i; j++)
	{
		if ((i + j) % 2 == 0) Console.Write("1 ");
		else Console.Write("0 ");

	}
	Console.WriteLine();
}