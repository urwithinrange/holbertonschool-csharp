using System;
/// <summary>Abstract class for Base</summary>
public abstract class Base
{
    /// <summary>public property</summary>
    public string name;
    
    public override string ToString()
    {
        return name + " is a " + GetType();
    }        
}