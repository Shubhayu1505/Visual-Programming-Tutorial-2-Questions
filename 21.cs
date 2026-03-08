using System;
class Program
{
    static void Main()
    {
        string input = "Hello World";
        string result;
        if (input.Length < 4)
        {
            result = input;
        }
        else
        {
            string lastFour = input.Substring(input.Length - 4);
            result = lastFour + lastFour + lastFour + lastFour;
        }
        Console.WriteLine(result);
    }
}