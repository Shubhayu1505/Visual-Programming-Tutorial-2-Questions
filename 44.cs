using System;
class Program
{
    static void Main()
    {
        string input1 = "10";
        string input2 = "0";
        try
        {
            double num1 = double.Parse(input1);
            double num2 = double.Parse(input2);
            double result = num1 / num2;
            Console.WriteLine(result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Non-numeric values entered");
        }
    }
}