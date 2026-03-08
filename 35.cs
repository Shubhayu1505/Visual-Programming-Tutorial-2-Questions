using System;
class Program
{
    static void Main()
    {
        uint n1 = 25;
        uint n2 = 4;
        ulong product = (ulong)n1 * n2;
        string result = product.ToString();
        Console.WriteLine(result);
    }
}