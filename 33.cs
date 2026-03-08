using System;
class Program
{
    static void Main()
    {
        string input = "9999999999";
        try
        {
            int num = int.Parse(input);
            Console.WriteLine(num);
        }
        catch (OverflowException)
        {
            Console.WriteLine("Value outside the range of Int32");
        }
    }
}