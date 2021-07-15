using System;
using System.Collections.Generic;
class List
    {
        public static List<int> DifferentElements(List<int> list1, List<int> list2)
        {
            List<int> list3 = new List<int>();
            for (int i = 0; i < list1.Count; i++)
                list3.Add(list1[i]);
            for (int k = 0; k < list2.Count; k++)
                list3.Add(list2[k]);
            for (int j = 0; j < list3.Count; j++)
            {
                for (int jj = j + 1; jj < list3.Count; jj++)
                {
                    if (list3[j] == list3[jj])
                    {
                        list3.Remove(list1[j]);
                        break;
                    }
                }
            }
            list3.Sort();
            return list3;
        }
    }