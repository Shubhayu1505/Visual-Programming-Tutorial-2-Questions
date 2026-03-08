using System;
class Program
{
    static void Main()
    {
        string[] strs = { "flower", "flow", "flight" };
        if (strs.Length == 0)
        {
            Console.WriteLine("");
            return;
        }
        string prefix = strs[0];
        for (int i = 1; i < strs.Length; i++)
        {
            while (strs[i].IndexOf(prefix) != 0)
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