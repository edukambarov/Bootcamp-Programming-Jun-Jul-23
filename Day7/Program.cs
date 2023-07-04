int[] arrayInitial = { 6, 7, 8, 4, 2, 5, 3, 9, 1 };
int[] arraySorted = QuickSort(arrayInitial);
foreach (var item in arrayInitial)
{
    Console.Write($"{item} ");
}
Console.WriteLine();
foreach (var item in arraySorted)
{
    Console.Write($"{item} ");
}

int[] QuickSort(int[] arr)
{
    if (arr.Length <= 1) return arr;
    // else
    // {
    //     int pivot = arr[0];
    //     int countLeft = 0;
    //     int countRight = 0;
    //     for (int i = 1; i < arr.Length; i++)
    //     {
    //         if (arr[i] < pivot)
    //         {
    //             countLeft++;
    //         }
    //         else
    //         {
    //             countRight++;
    //         }
    //     }
    //     int[] left = new int[countLeft];
    //     int[] right = new int[countRight];
    //     int indexLeft = 0;
    //     int indexRight = 0;
    //     for (int j = 1; j < arr.Length; j++)
    //     {
    //         if (arr[j] < pivot)
    //         {
    //             left[indexLeft] = arr[j];
    //             indexLeft++;
    //         }
    //         else
    //         {
    //             right[indexRight] = arr[j];
    //             indexRight++;
    //         }
    //     }
    //     return QuickSort(left).Concat(new int[] {pivot}).Concat(QuickSort(right)).ToArray();
    // }
    else
    {
        int pivot = arr[0];
        int[] left  = arr.Skip(1).Where(x => x < pivot).ToArray();
        int[] right = arr.Skip(1).Where(x => x >= pivot).ToArray();
        return QuickSort(left).Concat(new int[] {pivot}).Concat(QuickSort(right)).ToArray();
    }
}

