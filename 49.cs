using System;
class Program
{
    static void Main()
    {
        string input = "Experienced software developer with leadership skills";
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