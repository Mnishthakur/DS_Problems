using System;

class Queue<T>
{
    private T[] elements;
    private int front;
    private int rear;
    private int count;

    public int Count { get { return count; } }

    public Queue(int capacity)
    {
        elements = new T[capacity];
        front = 0;
        rear = -1;
        count = 0;
    }

    public void Enqueue(T item)
    {
        if (count == elements.Length)
        {
            Console.WriteLine("Queue is full");
            return;
        }

        rear = (rear + 1) % elements.Length;
        elements[rear] = item;
        count++;
    }

    public T Dequeue()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        T item = elements[front];
        front = (front + 1) % elements.Length;
        count--;
        return item;
    }

    public T Peek()
    {
        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        return elements[front];
    }

    public void Clear()
    {
        front = 0;
        rear = -1;
        count = 0;
    }
}

class Program
{
    static void Main()
    {
        Queue<int> queue = new Queue<int>(5);
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        queue.Enqueue(40);

        Console.WriteLine("Count: " + queue.Count);

        if (queue.Count > 0)
        {
            Console.WriteLine("Peek: " + queue.Peek());

            Console.WriteLine("Dequeue: " + queue.Dequeue());
            Console.WriteLine("Dequeue: " + queue.Dequeue());
        }

        Console.WriteLine("Count: " + queue.Count);
    }
}

