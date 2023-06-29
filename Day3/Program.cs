int[] arr = new int[7];
FillArray(arr);
PrintArray(arr);
Console.WriteLine();
SortWithChoice(arr);
PrintArray(arr);

int[] SortWithChoice(int[] array)
{
    int size = array.Length;
    for (int i = 0; i < size - 1; i++)
    {
        int pos = i;
        for (int j = i + 1; j < size; j++)
        {
            if (array[j] < array[pos]) pos = j;
        }
        int temp = array[i];
        array[i] = array[pos];
        array[pos] = temp;
    }
    return array;
}

void FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 99);
    }  
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}