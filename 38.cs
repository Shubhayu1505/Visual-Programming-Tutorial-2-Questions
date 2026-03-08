using System;
using System.IO;
class Program
{
    static void Main()
    {
        string[] lines = { "Line 1", "Line 2", "Line 3" };
        File.WriteAllLines("test.txt", lines);
        string[] allLines = File.ReadAllLines("test.txt");
        if (allLines.Length > 0)
        {
            Console.WriteLine(allLines[allLines.Length - 1]);
        }
    }
}