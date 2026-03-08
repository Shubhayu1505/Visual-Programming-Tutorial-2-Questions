using System;
class ClassA
{
    public ClassA(int x)
    {
        Console.WriteLine(x);
    }
}
class Program
{
    static void Main()
    {
        ClassA a = new ClassA(10);
    }
}