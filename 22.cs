using System;
class Program
{
    static void Main()
    {
        int[] arr1 = { 1, 2, 3 };
        int[] arr2 = { 4, 5, 6 };
        int[] arr3 = { 7, 8, 9 };
        int[] result = new int[3];
        result[0] = arr1[1];
        result[1] = arr2[1];
        result[2] = arr3[1];
        foreach (int num in result)
        {
            Console.Write(num + " ");
        }
    }
}