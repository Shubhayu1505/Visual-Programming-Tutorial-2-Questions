using System;
class Program
{
    static void Main()
    {
        DateTime dt = DateTime.Now;
        int wholeDays = 5;
        double fractionalDays = 0.5;
        DateTime result = dt.AddDays(wholeDays).AddHours(fractionalDays * 24);
        Console.WriteLine(result);
    }
}