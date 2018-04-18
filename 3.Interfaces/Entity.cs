using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.Interfaces;

namespace _3.Interfaces
{
    public abstract class Entity : IDamageable, IDamager
    {
        private int health;
        private string name;
        public int HitModifier { get; set; }
        public int ArmorClass { get; set; }
        public void TakeDamage(int amount)
        {
            if (amount == 0)
            {
                Console.WriteLine(Name + "\n");
                Console.WriteLine("The attack misses.");
            }
            else
            {
                Console.WriteLine(Name + "\n");
                Health -= amount;
                Console.WriteLine(Name + " is hit for " + amount + "\n");
            }
        }
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void DoDamage(IDamageable entity)
        {
            var rand = new Random();
            int roll = rand.Next(1, 21);
            if (roll > entity.ArmorClass - HitModifier)
            {
                Console.WriteLine(Name + " is attacking ");
                entity.TakeDamage(HitModifier + roll);
            }
            else
            {
                Console.WriteLine(Name + " is attacking ");
                entity.TakeDamage(0);
            }
        }
    }
}

public class Assassin : Entity
{
    public Assassin(string name, int health, int armor, int modifier)
    {
        Name = name;
        Health = health;
        ArmorClass = armor;
        HitModifier = modifier;
    }
}

public class Ninja : Entity
{
    public Ninja(string name, int health, int armor, int modifier)
    {
        Name = name;
        Health = health;
        ArmorClass = armor;
        HitModifier = modifier;
    }
}

public class Robot : Entity
{
    public Robot(string name, int health, int armor, int modifier)
    {
        Name = name;
        Health = health;
        ArmorClass = armor;
        HitModifier = modifier;
    }
}

public class Witcher : Entity
{    public Witcher(string name, int health, int armor, int modifier)
    {
        Name = name;
        Health = health;
        ArmorClass = armor;
        HitModifier = modifier;
    }
}

public class Spartan : Entity
{
    public Spartan(string name, int health, int armor, int modifier)
    {
        Name = name;
        Health = health;
        ArmorClass = armor;
        HitModifier = modifier;
    }
}

public class Nord : Entity
{
    public Nord(string name, int health, int armor, int modifier)
    {
        Name = name;
        Health = health;
        ArmorClass = armor;
        HitModifier = modifier;
    }
}

public class Soldier : Entity
{
    public Soldier(string name, int health, int armor, int modifier)
    {
        Name = name;
        Health = health;
        ArmorClass = armor;
        HitModifier = modifier;
    }
}