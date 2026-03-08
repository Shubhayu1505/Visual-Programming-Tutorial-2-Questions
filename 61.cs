using System;
class LegacyClass
{
    public LegacyClass(int id)
    {
        Console.WriteLine(id);
    }
}
class Program
{
    static LegacyClass instance = new LegacyClass(100);
    static void Main()
    {
        Console.WriteLine(instance);
    }
}