int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int [n,n];
for (int i = 0; i < n; i++)
{
    for (int j = i; j < n; j++)
    {
        matrix[i,j] = (i + 1) * (1 + j);
        matrix[j,i] = (i + 1) * (1 + j);
    }
}
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(matrix[i,j]);
        Console.Write(" ");
    }
    Console.WriteLine();
}
//Сложность O(n^2/2)