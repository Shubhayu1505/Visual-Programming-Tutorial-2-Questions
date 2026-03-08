using System;
class Program
{
    static void Main()
    {
        string input = "Write a C# program to find the longest word in a string";
        string[] words = input.Split(' ');
        string longest = "";
        foreach (string word in words)
        {
            if (word.Length > longest.Length)
            {
                longest = word;
            }
        }
        Console.WriteLine(longest);
    }
}