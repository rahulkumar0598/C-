int[] num = { 3, 4, 5, 6, 7 };
int[] rev = new int[num.Length];
int a=num.Length-1;
for (int i = 0; i < num.Length; i++)
{
    rev[i] = num[a-i];
}
foreach (int i in rev)
{
    Console.WriteLine(i);
}
Int32 co =System.Convert.ToInt32("er");
Console.WriteLine(co);
