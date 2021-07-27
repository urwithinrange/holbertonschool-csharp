using System;
using System.Collections.Generic;

/// <summary>Obj class</summary>
class Obj
{
    /// <summary>Method that returns true if obj is an array</summary>
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj is Array)
            return true;
        return false;
    }
}