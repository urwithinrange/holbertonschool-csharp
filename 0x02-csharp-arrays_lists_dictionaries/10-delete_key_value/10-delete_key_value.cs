using System;
using System.Collections.Generic;
using System.Linq;
class Dictionary
{
    public static Dictionary<string, string> DeleteKeyValue(Dictionary<string, string> myDict, string key)
    {
        myDict.Remove(key);
        return myDict;
    }
}
