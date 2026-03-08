using System;
using System.Collections.Generic;
class Student
{
    public string Name { get; set; }
    public double Gpa { get; set; }
}
class Program
{
    static List<string> FilterAndSort(List<Student> students)
    {
        List<string> result = new List<string>();
        foreach (Student s in students)
        {
            if (s.Gpa > 3.5)
            {
                result.Add(s.Name);
            }
        }
        result.Sort();
        result.Reverse();
        return result;
    }
    static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student { Name = "Alice", Gpa = 3.8 },
            new Student { Name = "Bob", Gpa = 3.2 },
            new Student { Name = "Charlie", Gpa = 3.9 }
        };
        List<string> filtered = FilterAndSort(students);
        foreach (string name in filtered)
        {
            Console.WriteLine(name);
        }
    }
}