﻿using System;
using System.Collections.Generic;
class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return -1;
        }
        int temp = myList[0];
        for (int i = 0; i < myList.Count; i++)
        {
            if (temp < myList[i])
                temp = myList[i];
        }
        return temp;
    }
}