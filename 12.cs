using System;
class Program
{
    static int SumEven(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
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
        int[] numbers = { 1, 2, 3, 4, 5, 6 };
        int result = SumEven(numbers);
        Console.WriteLine(result);
    }
}