using System;
class Program
{
    static void Main()
    {
        int[] scores = { 85, 90, 78, 92, 88 };
        int sum = 0;
        foreach (int num in scores)
        {
            sum += num;
        }
        double avg = (double)sum / scores.Length;
        if (avg == Math.Floor(avg))
        {
            Console.WriteLine("Whole number");
        }
        else
        {
            Console.WriteLine("Not a whole number");
        }
    }
}