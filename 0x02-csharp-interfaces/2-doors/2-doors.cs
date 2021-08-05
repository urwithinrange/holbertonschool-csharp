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
/// <summary>Interface</summary>
interface IInteractive
{
    /// <summary>Interface method</summary>
    void Interact();
}
/// <summary>Interface</summary>
interface IBreakable
{
    /// <summary>Public property declaration</summary>
    int durability { get; set; }
    /// <summary>Interface method</summary>
    void Break();
}
/// <summary>Interface</summary>
interface ICollectable
{
    /// <summary>Public property declaration</summary>
    bool isCollected { get; set; }
    /// <summary>Interface method</summary>
    void Collect();
}
/// <summary>public class that interacts from base class</summary>
public class Door : Base, IInteractive
{
    /// <summary>Public Constructor</summary>
    public Door(string door = "Door")
    {
        name = door;
    }
    /// <summary>Inherited Method</summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}