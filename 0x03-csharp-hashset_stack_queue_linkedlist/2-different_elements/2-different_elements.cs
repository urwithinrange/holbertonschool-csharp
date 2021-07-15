using System;
using System.Collections.Generic;
class List
    {
        public static List<int> DifferentElements(List<int> list1, List<int> list2)
        {
//             Write a method that returns a sorted list of all elements present in one or the other list but not both.
//             Class Name: List
//             Prototype: public static List<int> DifferentElements(List<int> list1, List<int> list2)
//             Returns a new sorted list of all elements present in one or the other list but not both of the given lists
//             You cannot use LINQ
//             You cannot use SortedList
            List<int> list3 = new List<int>();
            for (int i = 0; i < list1.Count; i++)
                list3.Add(list1[i]);
            for (int k = 0; k < list2.Count; k++)
            {
                for (int j = 0; j < list1.Count; j++)
                {
                    if (list1[j] == list2[k])
                    {
                        list3.Remove(list1[j]);
                        break;
                    }
                    else if (j + 1 == list1.Count)
                        list3.Add(list2[k]);
                }
            }
            int temp = 0;  
  
            for (int i = 0; i <= list3.Count; i++)  
            {  
                for (int j = i; j < list3.Count; j++)  
                {  
                    if (list3[i] > list3[j])  
                    {  
                        temp = list3[i];  
                        list3[i] = list3[j];  
                        list3[j] = temp;  
                    }  
                }  
            }
            return list3;
        }
    }