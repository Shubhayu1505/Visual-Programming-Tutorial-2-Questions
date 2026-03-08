using System;
class Configuration
{
    private static Configuration instance;
    private static readonly object lockObject = new object();
    private Configuration() { }
    public static Configuration Instance
    {
        get
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new Configuration();
                }
                return instance;
            }
        }
    }
}
class Program
{
    static void Main()
    {
        Configuration config1 = Configuration.Instance;
        Configuration config2 = Configuration.Instance;
        Console.WriteLine(config1 == config2);
    }
}