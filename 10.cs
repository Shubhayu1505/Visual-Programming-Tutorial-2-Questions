using System;
class Singleton
{
    private static Singleton instance;
    private static readonly object lockObject = new object();
    private Singleton() { }
    public static Singleton Instance
    {
        get
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new Singleton();
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
        Singleton s1 = Singleton.Instance;
        Singleton s2 = Singleton.Instance;
        Console.WriteLine(s1 == s2);
    }
}