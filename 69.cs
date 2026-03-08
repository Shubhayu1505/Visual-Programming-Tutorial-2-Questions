using System;
class Program
{
    static void Main()
    {
        int[] dept1 = { 12, 34, 56 };
        int[] dept2 = { 23, 45, 67 };
        int[] dept3 = { 34, 56, 78 };
        int[] result = new int[3];
        result[0] = dept1[1];
        result[1] = dept2[1];
        result[2] = dept3[1];
        foreach (int num in result)
        {
            Console.Write(num + " ");
        }
    }
}