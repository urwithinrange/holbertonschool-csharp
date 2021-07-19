using System;
using System.Collections.Generic;
class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> div = new List<int>();
        int pos = 0, count = 1;
        while (count <= listLength)
        {
            try
            {
                if (list2[pos] == 0)
                    throw new DivideByZeroException();
                if (list1.Count  == pos || list2.Count == pos && pos < listLength)
                    throw new ArgumentOutOfRangeException();
                div.Add(list1[pos] / list2[pos]);
            }
            catch(DivideByZeroException)
            {
                div.Add(0);
                Console.WriteLine("Cannot divide by zero");
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
            pos++;
            count++;
        }
        return div;
    }
}