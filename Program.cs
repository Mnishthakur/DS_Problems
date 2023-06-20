using System;

class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

class LinkedList
{
    private Node head;

    public void InsertSorted(int data)
    {
        Node newNode = new Node(data);

        if (head == null || data > head.Data)
        {
            newNode.Next = head;
            head = newNode;
        }
        else
        {
            Node current = head;

            while (current.Next != null && current.Next.Data > data)
            {
                current = current.Next;
            }

            newNode.Next = current.Next;
            current.Next = newNode;
        }
    }

    public void Display()
    {
        Node current = head;

        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }

        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        LinkedList linkedList = new LinkedList();

        linkedList.InsertSorted(40);
        linkedList.InsertSorted(20);
        linkedList.InsertSorted(30);
        linkedList.InsertSorted(10);
        linkedList.InsertSorted(50);

        linkedList.Display();
    }
}
