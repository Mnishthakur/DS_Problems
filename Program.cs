using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> stack = new Stack<string>();

        // Create: Push elements to the Stack
        stack.Push("Apple");
        stack.Push("Banana");
        stack.Push("Orange");

        // Read: Display elements in the Stack
        Console.WriteLine("Elements in the Stack:");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }

        // Update: Modify the top element in the Stack
        if (stack.Count > 0)
        {
            string topElement = stack.Pop();
            stack.Push(topElement + " (Updated)");
        }

        // Read: Display elements after modification
        Console.WriteLine("\nElements in the Stack after modification:");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }

        // Delete: Remove an element from the Stack
        if (stack.Count > 0)
        {
            string removedElement = stack.Pop();
            Console.WriteLine("\nRemoved element: " + removedElement);
        }

        // Read: Display elements after deletion
        Console.WriteLine("\nElements in the Stack after deletion:");
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    }
}
