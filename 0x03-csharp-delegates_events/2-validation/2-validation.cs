using System;
/// <summary>Delegate for health</summary>
public delegate void CalculateHealth(float f);

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
    /// <summary>Method that follows CalculateHealth</summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
            System.Console.WriteLine($"{name} takes 0 damage!");
        }
        else
            System.Console.WriteLine($"{name} takes {damage} damage!");
        hp -= damage;
        ValidateHP(hp);
    }
    /// <summary>Method that follows CalculateHealth</summary>
    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            System.Console.WriteLine($"{name} heals 0 HP!");
        }
        else
            System.Console.WriteLine($"{name} heals {heal} HP!");
        hp += heal;
        ValidateHP(hp);
    }
    /// <summary>Method that sets the new value of the Player’s.</summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            newHp = 0;
        else if (newHp > maxHp)
            hp = maxHp;
        else
            hp = newHp;        
    }
}