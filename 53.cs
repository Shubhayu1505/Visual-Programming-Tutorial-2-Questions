using System;
class Program
{
    static void Main()
    {
        int h = 9;
        int m = 30;
        double ha = (h % 12) * 30 + m * 0.5;
        double ma = m * 6;
        double angle = Math.Abs(ha - ma);
        if (angle > 180)
        {
            angle = 360 - angle;
        }
        Console.WriteLine(angle);
    }
}