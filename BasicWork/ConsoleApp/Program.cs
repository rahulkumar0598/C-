int i;
for (i = 0; i < 10; i++)
{
    if (i == 5)
    {
        goto stop;
    }
    Console.WriteLine(i + "in for loop");
}

stop:
while (i < 10)
{
    if (i == 8)
    {
        break;
    }
    Console.WriteLine(i + "in while loop");
    i++;
}

if (5 > 2)
{
    Console.WriteLine("Ram");
}
int num = 050;
switch (num)
{
    case 0:
        Console.WriteLine(0);
        break;
    case 1:
        Console.WriteLine(1);
        break;
    case 5:
        Console.WriteLine(5);
        break;
    default:
        Console.WriteLine(100);
        break;
}

string a = 5 < 2 ? "Ram" : "sam";
Console.WriteLine(a);
