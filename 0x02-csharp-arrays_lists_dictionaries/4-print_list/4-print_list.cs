using System;
using System.Collections.Generic;
class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {   
            Console.WriteLine("Size cannot be negative");
            return null;
        }
         
        List<int> myList = new List<int>();
        for (int i = 0; i < size; i++)
        {
            myList.Add(i);
            Console.Write(i);
            if (i + 1 != size)
                Console.Write(" ");
        }
        Console.Write("\n");
        return myList;
    }

}