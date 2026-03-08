using System;
class Program
{
    static int CountDigits(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        return 1 + CountDigits(n / 10);
    }
    static void Main()
    {
        int num = 98765;
        int count = CountDigits(num);
        Console.WriteLine(count);
    }
}