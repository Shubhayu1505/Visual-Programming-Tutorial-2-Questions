using System;
class Program
{
    static void Main()
    {
        int num = 1500;
        try
        {
            if (num < 0 || num > 1000)
            {
                throw new ArgumentOutOfRangeException();
            }
            Console.WriteLine(num);
        }
        catch
        {
            Console.WriteLine("Number is less than 0 or greater than 1000");
        }
    }
}