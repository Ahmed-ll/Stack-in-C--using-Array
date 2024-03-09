using System;
class Stack
{
    const int MaxSize = 10;
    int top;
    int[] items;

    public Stack()
    {
        top = -1;
        items = new int[MaxSize];
    }

    public bool IsEmpty()
    {
        return top < 0;
    }

    public void Push(int element)
    {
        if (top > MaxSize - 1)
        {
            Console.WriteLine("Stack is full");
        }
        else
        {
            top++;
            items[top] = element;
        }
    }

    public void Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            top--;
        }
    }

    public void GetTop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty");
        }
        else
        {
            Console.WriteLine(items[top]);
        }
    }

    public void Print()
    {
        Console.Write("[");
        for (int i = top; i >= 0; i--)
        {
            Console.Write(" " + items[i] + " ");
        }
        Console.WriteLine("]");
    }
}
