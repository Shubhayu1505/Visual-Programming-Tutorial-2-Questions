using System;
class Program
{
    static void Main()
    {
        string[] keywords = { "search", "seat", "sea" };
        if (keywords.Length == 0)
        {
            Console.WriteLine("");
            return;
        }
        string prefix = keywords[0];
        for (int i = 1; i < keywords.Length; i++)
        {
            while (keywords[i].IndexOf(prefix) != 0)
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (prefix.Length == 0)
                {
                    Console.WriteLine("");
                    return;
                }
            }
        }
        Console.WriteLine(prefix);
    }
}