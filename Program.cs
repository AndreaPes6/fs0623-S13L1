using System;
using System.Xml.Linq;
namespace Fallout3Enemies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is your character");
            You YourCharacter = new You("ClaudioBisio", 4, 4, 5, 1, 9, 6, 6);
            SideQuest Start = new SideQuest("You see 2 deathclaws and 2 ghouls fighting in the distance, near them there is a scared person");
            Enemy AdultDeathclaw = new Enemy("Deathclaw", 550, 40, 75, 20, 90);
            Enemy YoungDeathclaw = new Enemy("Young Deathclaw", 200, 20, 50, 15, 50);
            Enemy Ghoul = new Enemy("Ghoul", 120, 9, 35, 11, 30);
            Enemy GlowingOne = new Enemy("GlowingOne", 250, 25, 55, 17, 38);
            SideQuest NpcDialogue = new SideQuest("You hear the person in the distance shouting something");
            Npc Elio = new Npc("Elio", 30, 2, "Please help me!", "The Biggest Magnum");
            SideQuest Choice = new SideQuest("Nope, i return after your death for the reward, bye");

            YourCharacter.ShowMainCharacter();
            Start.QuestText();
            AdultDeathclaw.ShowStats();
            YoungDeathclaw.ShowStats();
            Ghoul.ShowStats();
            GlowingOne.ShowStats();
            NpcDialogue.QuestText();
            Elio.SideQuest();
            Choice.QuestText();
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

public class Npc
{
    public string _name;
    public int _health;
    public int _protection;
    public string _dialogue;
    public string _reward;

    public string Name;
    public int Health;
    public int Protection;
    public string Dialogue;
    public string Reward;
    public Npc(string name, int health, int protection, string dialogue, string reward)
    {
        Name = name;
        Health = health;
        Protection = protection;
        Dialogue = dialogue;
        Reward = reward;
    }

    public void SideQuest()
    {
        Console.WriteLine(Name);
        Console.WriteLine(Health.ToString() + "HP");
        Console.WriteLine(Protection.ToString() + "DEF");
        Console.WriteLine("Elio:" + Dialogue.ToString());
        Console.WriteLine("Reward:" + Reward.ToString());
    }

}

public class SideQuest
{
    public string _text;
    public string Text;

    public SideQuest(string text)
    {
        Text = text;
    }
    public void QuestText()
    {
        Console.WriteLine(Text);
    }
}