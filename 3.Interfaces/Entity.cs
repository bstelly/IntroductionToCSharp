using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.Interfaces;

namespace _3.Interfaces
{
    public abstract class Entity : IDamageable
    {
        private int health;
        private string name;
        public int HitModifier;
        public int ArmorClass { get; set; }
        public bool TakeDamage(int amount)
        {
            return true;
        }
        void DoDamage(IDamageable entity)
        {

        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }


    }
}

public class Assassin : Entity
{
    public Assassin(string name, int health)
    {
        Name = name;
        Health = health;
    }
}

public class Ninja : Entity
{
    public Ninja(string name, int health)
    {
        Name = name;
        Health = health;
    }
}

public class Robot : Entity
{
    public Robot(string name, int health)
    {
        Name = name;
        Health = health;
    }
}

public class Witcher : Entity
{    public Witcher(string name, int health)
    {
        Name = name;
        Health = health;
    }
}

public class Spartan : Entity
{
    public Spartan(string name, int health)
    {
        Name = name;
        Health = health;
    }
}

public class Nord : Entity
{
    public Nord(string name, int health)
    {
        Name = name;
        Health = health;
    }
}

public class Soldier : Entity
{
    public Soldier(string name, int health)
    {
        Name = name;
        Health = health;
    }
}