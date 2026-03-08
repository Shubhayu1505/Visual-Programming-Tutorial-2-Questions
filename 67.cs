using System;
class Program
{
    static void Main()
    {
        string sentence = "C# programming is fun";
        string[] words = sentence.Split(' ');
        Array.Reverse(words);
        string result = string.Join(" ", words);
        Console.WriteLine(result);
    }
}