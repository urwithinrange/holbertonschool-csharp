using System;
using System.Collections.Generic;

/// <summary>Obj class</summary>
class Obj
{
    /// <summary>Method that returns true if obj is an int</summary> 
    public static bool IsOfTypeInt(object obj)
    {
        if (obj is int)
            return true;
        return false;
    }
}
