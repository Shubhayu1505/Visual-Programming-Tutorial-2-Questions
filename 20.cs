using System;
class Program
{
    static void Main()
    {
        string sentence = "Hello world from C#";
        string[] words = sentence.Split(' ');
        Array.Reverse(words);
        string result = string.Join(" ", words);
        Console.WriteLine(result);
    }
}