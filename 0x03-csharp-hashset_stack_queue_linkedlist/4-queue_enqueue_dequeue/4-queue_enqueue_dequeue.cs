using System;
using System.Collections.Generic;
class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        int size = aQueue.Count;
        Console.WriteLine($"Number of items: {size}");
        if (size == 0)
            Console.WriteLine("Queue is empty");
        else
            Console.WriteLine($"First item: {aQueue.Peek()}");
        aQueue.Enqueue(newItem);
        if (aQueue.Contains(search))
        {
            Console.WriteLine($"Queue contains \"{search}\": True");
            while (size != 0 && (aQueue.Peek() != search || aQueue.Peek() == search) && aQueue.Contains(search))
                aQueue.Dequeue();
        }    
        else
            Console.WriteLine($"Queue contains \"{search}\": False");
        return aQueue;   
    }
}
