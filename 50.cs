using System;
class Program
{
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50 };
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