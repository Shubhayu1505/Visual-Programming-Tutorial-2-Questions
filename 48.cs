using System;
class Program
{
    static void Main()
    {
        int mark1 = 15;
        int mark2 = 15;
        int total = mark1 + mark2;
        if (mark1 == mark2)
        {
            total = total * 3;
        }
        Console.WriteLine(total);
    }
}