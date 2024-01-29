using System;
namespace Fallout3Enemies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Danger: enemies in the area");
            Enemy AdultDeathclaw = new Enemy("Deathclaw", 550, 40, 75, 20, 90);
            Enemy YoungDeathclaw = new Enemy("Young Deathclaw", 200, 20, 50, 15, 50);
            Enemy Ghoul = new Enemy("Ghoul", 120, 9, 35, 11, 30);
            Enemy GlowingOne = new Enemy("GlowingOne", 250, 25, 55, 17, 38);
            You YourCharacter = new You("ClaudioBisio", 4, 4, 5, 1, 9, 6, 6);
            AdultDeathclaw.ShowStats();
            YoungDeathclaw.ShowStats();
            Ghoul.ShowStats();
            GlowingOne.ShowStats();
            YourCharacter.ShowMainCharacter();
        }
    }
}

public class Enemy
{
    public string _name;
    public int _health;
    public int _protection;
    public int _attack;
    public int _attackrate;
    public int _speed;

    public string Name;
    public int Health;
    public int Defence;
    public int Attack;
    public int Attackrate;
    public int Speed;

    public Enemy(string name, int hp, int defence, int attack, int attackrate, int speed)
    {
        Name = name;
        Health = hp;
        Defence = defence;
        Attack = attack;
        Attackrate = attackrate;
        Speed = speed;
    }
    public void ShowStats()
    {
        Console.WriteLine(Name);
        Console.WriteLine(Health.ToString() + "HP");
        Console.WriteLine(Defence.ToString() + "DF");
        Console.WriteLine(Attack.ToString() + "ATK");
        Console.WriteLine(Attackrate.ToString() + "DPS");
        Console.WriteLine(Speed.ToString() + "SP");
    }
}

public class You
{
    public string _name;
    public int _strength;
    public int _perception;
    public int _endurance;
    public int _charisma;
    public int _intelligence;
    public int _agility;
    public int _luck;

    public string Name;
    public int Strength;
    public int Perception;
    public int Endurance;
    public int Charisma;
    public int Intelligence;
    public int Agility;
    public int Luck;

    public You(string name, int strength, int perception, int endurance, int charisma, int intelligence, int agility, int luck)
    {
        Name = name;
        Strength = strength;
        Perception = perception;
        Endurance = endurance;
        Charisma = charisma;
        Intelligence = intelligence;
        Agility = agility;
        Luck = luck; 
    }
    public void ShowMainCharacter()
    {
        Console.WriteLine(Name);
        Console.WriteLine("Strenght:" + Strength.ToString());
        Console.WriteLine("Perception:" + Perception.ToString());
        Console.WriteLine("Endurance:" + Endurance.ToString());
        Console.WriteLine("Charisma:" + Charisma.ToString());
        Console.WriteLine("Intelligence:" + Intelligence.ToString());
        Console.WriteLine("Agility:" + Agility.ToString());
        Console.WriteLine("luck:" + Luck.ToString());
    }
}

