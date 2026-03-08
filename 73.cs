using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Stack<string> undoStack = new Stack<string>();
        undoStack.Push("Type Hello");
        undoStack.Push("Type World");
        undoStack.Push("Delete World");
        int count = 0;
        foreach (string item in undoStack)
        {
            count++;
        }
        Console.WriteLine(count);
    }
}