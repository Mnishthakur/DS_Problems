using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Queue<int> queue = new Queue<int>();

        // Create (Enqueue) operation
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        // Read operation
        Console.WriteLine("Queue elements: ");
        foreach (int item in queue)
        {
            Console.WriteLine(item);
        }

        // Update (Peek) operation
        int firstElement = queue.Peek();
        Console.WriteLine("First element in the queue: " + firstElement);

        // Delete (Dequeue) operation
        int removedElement = queue.Dequeue();
        Console.WriteLine("Removed element from the queue: " + removedElement);
        // Read updated queue
        Console.WriteLine("Updated queue elements: ");
        foreach (int item in queue)
        {
            Console.WriteLine(item);
        }
    }
}
