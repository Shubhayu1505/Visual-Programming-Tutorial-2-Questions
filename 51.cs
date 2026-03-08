using System;
class Program
{
    static void Main()
    {
        int[] marks = { 78, 95, 82, 91, 88, 76 };
        int first = int.MinValue;
        int second = int.MinValue;
        int third = int.MinValue;
        for (int i = 0; i < marks.Length; i++)
        {
            if (marks[i] > first)
            {
                third = second;
                second = first;
                first = marks[i];
            }
            else if (marks[i] > second)
            {
                third = second;
                second = marks[i];
            }
            else if (marks[i] > third)
            {
                third = marks[i];
            }
        }
        Console.WriteLine(third);
    }
}