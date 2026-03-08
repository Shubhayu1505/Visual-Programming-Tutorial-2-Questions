using System;
using System.IO;
class Program
{
    static void Main()
    {
        string[] logs = { "User logged in", "Error: timeout", "Data saved" };
        string exclude = "Error";
        using (StreamWriter sw = new StreamWriter("log.txt"))
        {
            foreach (string line in logs)
            {
                if (!line.Contains(exclude))
                {
                    sw.WriteLine(line);
                }
            }
        }
    }
}