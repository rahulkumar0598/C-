using System.Runtime.CompilerServices;

int num = int.Parse(Console.ReadLine());
int x = 1;
int y = 1;
for (int i = 0; i < num; i++)
{
    if ((num % 2) == 0)
    {
        Console.WriteLine(x);
        x = x * 2;
    }
    else
    {
        Console.WriteLine(y);
        y = y * 3;
    }
}
