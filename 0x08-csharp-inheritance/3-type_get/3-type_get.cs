using System;
using System.Reflection;
using System.Collections.Generic;

/// <summary>Obj class</summary>
class Obj
{
    /// <summary>Method that prints the names of the available properties of an object.</summary>
    /// <param name="myObj">The being reffered to</param>
    public static void Print(object myObj)
    {
        TypeInfo t = myObj.GetType().GetTypeInfo();
        Console.WriteLine($"{t.Name} Properties:");
        foreach (PropertyInfo i in t.GetProperties())
        {
            Console.WriteLine(i.Name);
        }
        Console.WriteLine($"{t.Name} Methods:");
        foreach (MethodInfo x in t.GetMethods())
        {
            Console.WriteLine(x.Name);
        }
    }
}