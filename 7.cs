using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 2, 3, 4, 4, 5 };
        HashSet<int> set = new HashSet<int>();
        foreach (int num in arr)
        {
            set.Add(num);
        }
        int[] result = new int[set.Count];
        set.CopyTo(result);
        foreach (int num in result)
        {
            Console.Write(num + " ");
        }
    }
}