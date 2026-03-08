using System;
using System.IO;
class Program
{
    static void Main()
    {
        string[] data = { "Line one", "Line two", "Line three" };
        File.WriteAllLines("data.txt", data);
        string[] lines = File.ReadAllLines("data.txt");
        int count = lines.Length;
        Console.WriteLine(count);
    }
}