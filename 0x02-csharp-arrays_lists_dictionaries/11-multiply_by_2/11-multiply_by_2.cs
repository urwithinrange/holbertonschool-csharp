using System;
using System.Collections.Generic;
using System.Linq;
class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
       var newDict = new Dictionary<string, int>();
       foreach (KeyValuePair<string, int> element in myDict)
       {
           newDict.Add(element.Key, element.Value * 2);
       }
       return newDict;
    }
}