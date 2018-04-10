using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Containers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Stat> SavingThrows = new Dictionary<string, Stat>();
            Stat strength = new Stat()
            {
                Name = "Strength",
                Value = 3,
                Description = "Determines which weapons a character can use"
            };

            Stat dexterity = new Stat()
            {
                Name = "Dexterity",
                Value = 4,
                Description = " "
            };

            Stat constitution = new Stat()
            {
                Name = "Constitution",
                Value = 5,
                Description = " "
            };

            Stat intelligence = new Stat()
            {
                Name = "Intelligence",
                Value = 6,
                Description = " "
            };

            Stat wisdom = new Stat()
            {
                Name = "Wisdom",
                Value = 5,
                Description = " "
            };

            Stat charisma = new Stat()
            {
                Name = "Charisma",
                Value = 4,
                Description = " "
            };

            #region MyRegion
            //Stat health = new Stat()
            //{
            //    Name = "Health",
            //    Value = 100,
            //    Description = "Wholeness of an Entities ability to participate"
            //};

            //Stat speed = new Stat()
            //{
            //    Name = "Speed",
            //    Value = 10,
            //    Description = "How fast you move"
            //};

            //Stat attackPower = new Stat()
            //{
            //    Name = "Attack Power",
            //    Value = 15,
            //    Description = "How much 'this' entity will affect others' ability to participate"
            //};

            //Stat charisma = new Stat()
            //{
            //    Name = "charisma",
            //    Value = 5,
            //    Description = "Likelyhood of someone affecting your ability to participate"
            //};

            //Stat attackCooldown = new Stat()
            //{
            //    Name = "Attack cooldown",
            //    Value = 10,
            //    Description = "Frequency of affecting others ability to participate"
            //};

            //stats.Add("health", health);
            //stats.Add("speed", speed);
            //stats.Add("attack power", attackPower);
            //stats.Add("charisma", charisma);
            //stats.Add("attack cooldown", attackCooldown);
            #endregion
            SavingThrows.Add("Strength", strength);
            SavingThrows.Add("Dexterity", dexterity);
            SavingThrows.Add("Constitution", constitution);
            SavingThrows.Add("Intelligence", intelligence);
            SavingThrows.Add("Wisdom", wisdom);
            SavingThrows.Add("Charisma", charisma);
        }
    }
}
