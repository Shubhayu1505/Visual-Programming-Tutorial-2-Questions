using System;
class Program
{
    static int Divide(int a, int b, out int remainder)
    {
        remainder = a % b;
        return a / b;
    }
    static void Main()
    {
        int x = 17;
        int y = 5;
        int quotient = Divide(x, y, out int remainder);
        Console.WriteLine($"Quotient: {quotient}, Remainder: {remainder}");
    }
}