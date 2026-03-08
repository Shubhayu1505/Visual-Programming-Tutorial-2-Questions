using System;
using System.IO;
class Program
{
    static void Main()
    {
        string[] lines = { "Hello world", "This is a test", "C# programming" };
        string exclude = "test";
        using (StreamWriter sw = new StreamWriter("output.txt"))
        {
            foreach (string line in lines)
            {
                if (!line.Contains(exclude))
                {
                    sw.WriteLine(line);
                }
            }
        }
    }
}