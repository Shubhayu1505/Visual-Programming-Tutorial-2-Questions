using System;
class Program
{
    static void Main()
    {
        string input = "abc$def$ghi$jkl";
        int index = input.IndexOf('$');
        if (index != -1)
        {
            string result = input.Substring(0, index + 1) + input.Substring(index + 1).Replace("$", "");
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine(input);
        }
    }
}