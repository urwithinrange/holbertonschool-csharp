using System;
/// <summary>class Player</summary>
public class Player
{
    /// <summary>class Player</summary>
    private string name { get; set; }
    /// <summary>class Player</summary>
    private float maxHp { get; set; }
    /// <summary>class Player</summary>
    private float hp { get; set; }

    /// <summary>Player constructor</summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0f)
        {
           System.Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
           maxHp = 100f;
        }
        this.name = name;
        this.maxHp = maxHp;
        this.hp = maxHp;
    }
    /// <summary>Method for printing health</summary>
    public void PrintHealth()
    {
        System.Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
}