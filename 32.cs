using System;
using System.Globalization;
class Program
{
    static DateTime ReadDate(string input)
    {
        try
        {
            return DateTime.ParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }
        catch
        {
            throw new FormatException("Invalid date format");
        }
    }
    static void Main()
    {
        string dateInput = "25/12/2023";
        try
        {
            DateTime date = ReadDate(dateInput);
            Console.WriteLine(date.ToString("dd/MM/yyyy"));
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}