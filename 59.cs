using System;
class Program
{
    static int SumEven(int[] readings)
    {
        int sum = 0;
        foreach (int num in readings)
        {
            if (num % 2 == 0)
            {
                sum += num;
            }
        }
        return sum;
    }
    static void Main()
    {
        int[] meters = { 101, 202, 303, 404, 505 };
        int result = SumEven(meters);
        Console.WriteLine(result);
    }
}