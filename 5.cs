using System;
class Program
{
    static void Main()
    {
        int[,] arr2d = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
        int rows = arr2d.GetLength(0);
        int cols = arr2d.GetLength(1);
        int[] arr1d = new int[rows * cols];
        int index = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                arr1d[index] = arr2d[i, j];
                index++;
            }
        }
        foreach (int num in arr1d)
        {
            Console.Write(num + " ");
        }
    }
}