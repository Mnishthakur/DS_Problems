using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        LinkedList<string> linkedList = new LinkedList<string>();

        // Create: Add elements to the LinkedList
        linkedList.AddLast("Apple");
        linkedList.AddLast("Banana");
        linkedList.AddLast("Orange");

        // Read: Display elements in the LinkedList
        Console.WriteLine("Elements in the LinkedList:");
        foreach (var item in linkedList)
        {
            Console.WriteLine(item);
        }

        // Update: Modify an element in the LinkedList
        LinkedListNode<string> nodeToModify = linkedList.Find("Banana");
        if (nodeToModify != null)
        {
            linkedList.AddAfter(nodeToModify, "Mango");
            linkedList.Remove(nodeToModify);
        }

        // Read: Display elements after modification
        Console.WriteLine("\nElements in the LinkedList after modification:");
        foreach (var item in linkedList)
        {
            Console.WriteLine(item);
        }

        // Delete: Remove an element from the LinkedList
        LinkedListNode<string> nodeToDelete = linkedList.Find("Orange");
        if (nodeToDelete != null)
        {
            linkedList.Remove(nodeToDelete);
        }

        // Read: Display elements after deletion
        Console.WriteLine("\nElements in the LinkedList after deletion:");
        foreach (var item in linkedList)
        {
            Console.WriteLine(item);
        }
    }
}
