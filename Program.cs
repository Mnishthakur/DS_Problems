using System;

class Stack<T>
{
    private T[] elements;
    private int top;

    public int Count { get { return top + 1; } }

    public Stack(int capacity)
    {
        elements = new T[capacity];
        top = -1;
    }

    public void Push(T item)
    {
        if (top == elements.Length - 1)
        {
            throw new StackOverflowException("Stack is full");
        }

        elements[++top] = item;
    }

    public T Pop()
    {
        if (top == -1)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        T item = elements[top--];
        return item;
    }

    public T Peek()
    {
        if (top == -1)
        {
            throw new InvalidOperationException("Stack is empty");
        }

        return elements[top];
    }

    public void Clear()
    {
        top = -1;
    }
}

class Program
{
    static void Main()
    {
        Stack<int> stack = new Stack<int>(5);
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);

        Console.WriteLine("Count: " + stack.Count);
        Console.WriteLine("Peek: " + stack.Peek());

        Console.WriteLine("Pop: " + stack.Pop());
        Console.WriteLine("Pop: " + stack.Pop());

        Console.WriteLine("Count: " + stack.Count);
    }
}
