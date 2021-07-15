using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count == 0)
            return ("None");
        foreach (KeyValuePair<string, int> element  in myList.OrderByDescending(key => key.Value))
        {
            return element.Key;
        }
        return "";
    }
}