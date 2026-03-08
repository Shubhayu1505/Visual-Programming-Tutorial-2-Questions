using System;
using System.IO;
class Program
{
    static void Main()
    {
        string[] lines = { "Line 1", "Line 2", "Line 3", "Line 4" };
        File.WriteAllLines("test.txt", lines);
        string[] readLines = File.ReadAllLines("test.txt");
        int count = readLines.Length;
        Console.WriteLine(count);
    }
}