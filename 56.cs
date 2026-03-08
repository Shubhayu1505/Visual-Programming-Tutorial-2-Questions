using System;
using System.IO;
class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("transactions.txt");
        int sum = 0;
        foreach (string line in lines)
        {
            sum += int.Parse(line);
        }
        Console.WriteLine(sum);
    }
}