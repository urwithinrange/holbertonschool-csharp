using System;
using System.Collections.Generic;
class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        int size = aStack.Count;
        Console.WriteLine($"Number of items: {size}");
        if (size == 0)
            Console.WriteLine("Stack is empty");
        else
            Console.WriteLine($"Top item: {aStack.Peek()}");
        if (aStack.Contains(search))
            Console.WriteLine($"Stack contains \"{search}\": True");
        else
            Console.WriteLine($"Stack contains \"{search}\": False");
        while (size != 0 && (aStack.Peek() != search || aStack.Peek() == search) && aStack.Contains(search))
        {
            aStack.Pop();            
        }
        aStack.Push(newItem);
        return aStack;
    }
}
