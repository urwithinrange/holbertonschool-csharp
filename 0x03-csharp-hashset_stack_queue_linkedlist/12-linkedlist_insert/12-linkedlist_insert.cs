using System;
using System.Collections.Generic;
class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> ll = myLList.First;
        while (ll != null)
        {
            if (ll.Value < n)
            {
                ll = ll.Next;
            }
            else
            {
                return(myLList.AddBefore(ll, n));
            }
        }
        return (myLList.AddLast(n));
    }
}
