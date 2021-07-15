using System;
using System.Collections.Generic;
class List
    {
        public static List<int> DifferentElements(List<int> list1, List<int> list2)
        {
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();

            for (int i = 0; i < list1.Count; i++)
                set1.Add(list1[i]);
            for (int k = 0; k < list2.Count; k++)
                set2.Add(list2[k]);
            set1.SymmetricExceptWith(set2);
            List<int> newList = new List<int>();
            foreach (int a in set1)
            {
                newList.Add(a);
            }
            newList.Sort();
            return newList;
        }
    }