using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        int[] rollNumbers = { 101, 102, 103, 101, 104, 102, 105 };
        HashSet<int> set = new HashSet<int>();
        foreach (int num in rollNumbers)
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