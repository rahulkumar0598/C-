// See https://aka.ms/new-console-template for more information
int[,] multi = new int[3, 4]
{
    {1,2, 3, 4},
    {1,2, 3,5},
    {1,2, 3,6 } 
};
Console.WriteLine(multi[0,0]);
Console.WriteLine(multi.Length);
// accesing the all element in two dimnesion by  for loop
for (int i = 0; i < multi.GetLength(0); i++)
{
    for (int j = 0; j < multi.GetLength(1); j++)
    {
        Console.WriteLine(multi[i,j]);
    }

}
//checking dimension of an array
Console.WriteLine();
Console.WriteLine(multi.Rank);
Console.WriteLine(multi.GetLength(0));//lenght of row
Console.WriteLine(multi.GetLength(1));//lenght of column
