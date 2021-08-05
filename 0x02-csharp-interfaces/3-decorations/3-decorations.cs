﻿using System;
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
/// <summary>Decoration class</summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>Decoration bool property</summary>
    public bool isQuestItem;
    /// <summary>Decoration durability property</summary>
    public int durability { get; set; }
    /// <summary>Constructor</summary>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new Exception("Durability must be greater than 0");
        }
        this.name = name;
        this.isQuestItem = isQuestItem;
        this.durability = durability;
    }
    /// <summary>Inherited Method</summary>
    public void Interact()
    {
        if (durability == 0)
        {
            System.Console.WriteLine($"The {name} has been broken.");
        }
        else if (isQuestItem == true)
        {
            System.Console.WriteLine($"You look at the {name}. There's a key inside.");
        }
        else if (isQuestItem == false)
        {
            System.Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }
    /// <summary>Inherited Method</summary>
    public void Break()
    {
        durability--;
		if (durability > 0)
		{
			System.Console.WriteLine($"You hit the {name}. It cracks.");
		}
		else if (durability == 0)
        {
            System.Console.WriteLine($"You smash the {name}. What a mess.");
        }
        else if (durability < 0)
        {
            System.Console.WriteLine($"The {name} is already broken.");
        }
    }
}