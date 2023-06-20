using System;

class LinkedListNode<T>
{
    public T Value { get; set; }
    public LinkedListNode<T> Next { get; set; }

    public LinkedListNode(T value)
    {
        Value = value;
        Next = null;
    }
}

class LinkedList<T>
{
    private LinkedListNode<T> head;

    public void Add(T value)
    {
        LinkedListNode<T> newNode = new LinkedListNode<T>(value);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            LinkedListNode<T> currentNode = head;
            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }
            currentNode.Next = newNode;
        }
    }

    public void Display()
    {
        LinkedListNode<T> currentNode = head;
        while (currentNode != null)
        {
            Console.Write(currentNode.Value + " ");
            currentNode = currentNode.Next;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        LinkedList<int> linkedList = new LinkedList<int>();
        linkedList.Add(10);
        linkedList.Add(20);
        linkedList.Add(30);
        linkedList.Add(40);
        linkedList.Display();
    }
}
