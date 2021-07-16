using System;
using System.Collections.Generic;
class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int pos = 0;
        foreach(int item in myLList)
        {
            if (pos == n)
                return item;
            pos++;
        }
        return 0;
    }
}