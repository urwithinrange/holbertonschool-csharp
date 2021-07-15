using System;
using System.Collections.Generic;
using System.Linq;
class List
    {
        public static int Sum(List<int> myList)
        {
            int sum = 0;
            IEnumerable<int> distinctnum = myList.Distinct();
            foreach (int num in distinctnum)
            {
                sum += num;
            }
            return sum;
        }
    }