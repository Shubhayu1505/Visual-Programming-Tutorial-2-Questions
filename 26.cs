using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        int count = 0;
        foreach (int item in stack)
        {
            count++;
        }
        Console.WriteLine(count);
    }
}