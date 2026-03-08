using System;
class Program
{
    static void Main()
    {
        int[,] grid = { { 23, 25 }, { 21, 24 }, { 22, 26 } };
        int rows = grid.GetLength(0);
        int cols = grid.GetLength(1);
        int[] flat = new int[rows * cols];
        int index = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                flat[index] = grid[i, j];
                index++;
            }
        }
        foreach (int num in flat)
        {
            Console.Write(num + " ");
        }
    }
}