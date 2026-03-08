using System;
class Program
{
    static void Main()
    {
        uint n1 = 50000;
        uint n2 = 60000;
        ulong product = (ulong)n1 * n2;
        string result = product.ToString();
        Console.WriteLine(result);
    }
}