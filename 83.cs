using System;
class Program
{
    static void Main()
    {
        DateTime now = DateTime.Now;
        int wholeDays = 3;
        double fractionalDays = 0.75;
        DateTime result = now.AddDays(wholeDays).AddHours(fractionalDays * 24);
        Console.WriteLine(result);
    }
}