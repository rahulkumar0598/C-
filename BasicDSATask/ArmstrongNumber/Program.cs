int sum = 0, rem = 0, temp;
int num = int.Parse(Console.ReadLine());
temp = num;
while (temp != 0)
{
    rem = temp % 10;
    sum = sum + (rem * rem * rem);
    temp = temp / 10;
}
if (temp == num) 
{
    Console.WriteLine("Armstrong Number"); 
}
else 
{
    Console.WriteLine("Not Armstrong Number"); 
}