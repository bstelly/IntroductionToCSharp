using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Containers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Stat> stats = new Dictionary<string, Stat>();
            Stat health = new Stat()
            {
                Name = "Health",
                Value = 100,
                Description = "Wholeness of an Entities ability to participate"
            };

            Stat speed = new Stat()
            {
                Name = "Speed",
                Value = 10,
                Description = "How fast you move"
            };

            Stat attackPower = new Stat()
            {
                Name = "Attack Power",
                Value = 15,
                Description = "How much 'this' entity will affect others' abitlity to participate"
            };

            Stat charisma = new Stat()
            {
                Name = "charisma",
                Value = 5,
                Description = "Likelyhood of someone affecting your ability to participate"
            };

            Stat AttackCooldown = new Stat()
            {
                Name = "Attack cooldown",
                Value = 10,
                Description = "Frequency of affecting others ability to participate"
            };

            stats.Add("health", health);
            stats.Add("speed", speed);
            stats.Add("attack power", attackPower);
            stats.Add("charisma", charisma);
            stats.Add("attack cooldown", AttackCooldown);
        }
    }
}
