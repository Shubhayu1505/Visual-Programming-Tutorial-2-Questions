using System;
class Program
{
    static void Main()
    {
        string username = "john_doe";
        if (username.Length % 2 == 0)
        {
            Console.WriteLine("Even length");
        }
        else
        {
            Console.WriteLine("Odd length");
        }
    }
}