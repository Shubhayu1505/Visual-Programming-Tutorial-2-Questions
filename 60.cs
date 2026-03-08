using System;
class Circle
{
    public double Radius { get; set; }
}
class Program
{
    static void Main()
    {
        Circle c = new Circle { Radius = 7 };
        double circumference = 2 * Math.PI * c.Radius;
        Console.WriteLine(circumference);
    }
}