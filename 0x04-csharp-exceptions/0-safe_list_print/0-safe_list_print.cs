using System;
using System.Collections.Generic;
class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int count = 0;
        while (count <= n)
        {
             try
             {
                 if (count == n || myList.Count == count)
                 {
                      throw new Exception();
                 }
                 Console.WriteLine($"{myList[count]}");
                 count++;
             }
             catch
             {
                 return count;
             }
        }
        return count;
    }
}
