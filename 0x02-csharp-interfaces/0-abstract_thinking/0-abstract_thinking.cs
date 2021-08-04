using System;
/// <summary>Abstract class for Base</summary>
public abstract class Base
{
    /// <summary>Public property declaration</summary>
    public string name { get; set; }
    /// <summary>Method to override ToString</summary>
    public override string ToString()
    {
        return name + " is a " + GetType();
    }
}