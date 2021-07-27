using System;
using System.Collections.Generic;

/// <summary>Obj class</summary>
class Obj
{
    /// <summary>Method that returns true or false.</summary>
    /// <param name="derivedType">The subclass being checked.</param>
    /// <param name="baseType">The baseclass being ccompared to.</param>
    /// <returns>True or false bool.</returns>

    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {

        if (derivedType.IsSubclassOf(baseType))
            return true;
        return false;
    }
}
