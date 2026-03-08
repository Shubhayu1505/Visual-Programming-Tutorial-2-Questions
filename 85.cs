using System;
using System.IO;
class Program
{
    static void Main()
    {
        string[] entries = { "Start", "Processing", "End" };
        File.WriteAllLines("log.txt", entries);
        string[] lines = File.ReadAllLines("log.txt");
        if (lines.Length > 0)
        {
            Console.WriteLine(lines[lines.Length - 1]);
        }
    }
}