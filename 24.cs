using System;
class Program
{
    static void Main()
    {
        string str = "Hello World";
        if (str.Length % 2 == 0)
        {
            Console.WriteLine("Even length");
        }
        else
        {
            Console.WriteLine("Odd length");
        }
    }
}