using System;
class Program
{
    static double Average(int[] arr)
    {
        if (arr.Length == 0)
        {
            throw new ArgumentException("Array is empty");
        }
        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }
        return (double)sum / arr.Length;
    }
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };
        try
        {
            double avg = Average(numbers);
            Console.WriteLine(avg);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}