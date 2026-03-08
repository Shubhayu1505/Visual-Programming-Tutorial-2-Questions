using System;
class Program
{
    static void Main()
    {
        int[] arr = { 12, 13, 1, 10, 34, 16 };
        int first = int.MinValue;
        int second = int.MinValue;
        int third = int.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > first)
            {
                third = second;
                second = first;
                first = arr[i];
            }
            else if (arr[i] > second)
            {
                third = second;
                second = arr[i];
            }
            else if (arr[i] > third)
            {
                third = arr[i];
            }
        }
        Console.WriteLine(third);
    }
}