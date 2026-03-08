using System;
using System.IO;
class Program
{
    static int ReadFileAndSumNumbers(string path)
    {
        string[] lines = File.ReadAllLines(path);
        int sum = 0;
        foreach (string line in lines)
        {
            sum += int.Parse(line);
        }
        return sum;
    }
    static void Main()
    {
        int result = ReadFileAndSumNumbers("numbers.txt");
        Console.WriteLine(result);
    }
}