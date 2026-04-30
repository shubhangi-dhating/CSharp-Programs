using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Stack demonstration (LIFO)
        Stack<int> stack = new Stack<int>();

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine("Stack Elements:");

        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }

        // Queue demonstration (FIFO)
        Queue<string> queue = new Queue<string>();

        queue.Enqueue("Rahul");
        queue.Enqueue("Amit");
        queue.Enqueue("Sneha");

        Console.WriteLine("\nQueue Elements:");

        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }

        Console.ReadLine();
    }
}

