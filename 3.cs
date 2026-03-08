using System;
class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int n = arr.Length;
        int temp = arr[0];
        for (int i = 0; i < n - 1; i++)
        {
            arr[i] = arr[i + 1];
        }
        arr[n - 1] = temp;
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}