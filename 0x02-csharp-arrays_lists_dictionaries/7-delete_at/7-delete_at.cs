using System;
using System.Collections.Generic;

namespace _7_delete_at
{
    class List
    {
        public static List<int> DeleteAt(List<int> myList, int index)
        {
            if (myList.Count <= index || index <= 0)
            {
                Console.WriteLine("Index is out of range");
                return myList;
            }
            else
                myList.Remove(myList[index]);
            return myList;
        }
    }
}
