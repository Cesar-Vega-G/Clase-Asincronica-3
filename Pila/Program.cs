// Pila con Arreglos
public class ArrayStack
{
    private int[] stack;
    private int top;
    private int size;

    public ArrayStack(int size)
    {
        this.size = size;
        stack = new int[size];
        top = -1;
    }

    public void Push(int element)
    {
        if (top == size - 1)
        {
            Console.WriteLine("Stack Overflow");
        }
        else
        {
            stack[++top] = element;
        }
    }

    public int Pop()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack Underflow");
            return -1;
        }
        else
        {
            return stack[top--];
        }
    }

    public int Top()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack Underflow");
            return -1;
        }
        else
        {
            return stack[top];
        }
    }
}

// Pila con Lista Enlazada
public class LinkedListStack
{
    private class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
        }
    }
    private Node top;

    public void Push(int element)
    {
        Node newNode = new Node(element);
        newNode.Next = top;
        top = newNode;
    }

    public int Pop()
    {
        if (top == null)
        {
            Console.WriteLine("Stack Underflow");
            return -1;
        }
        else
        {
            int element = top.Data;
            top = top.Next;
            return element;
        }
    }

    public int Top()
    {
        if (top == null)
        {
            Console.WriteLine("Stack Underflow");
            return -1;
        }
        else
        {
            return top.Data;
        }
    }

    
}


class Program
{
    static void Main()
    { }

}
