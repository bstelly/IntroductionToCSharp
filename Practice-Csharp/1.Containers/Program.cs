using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _1.Containers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Stat> SavingThrows = new Dictionary<string, Stat>();
            Stat strength = new Stat("strength", 3, "Determines which weapons a character can use");
            Stat dexterity = new Stat("Dexterity", 4, "A measure of a character's attack, movement speed, and accuracy.");
            Stat constitution = new Stat("Constitution", 5, "A measure of how sturdy a character is");
            Stat intelligence = new Stat("Intelligence", 6, "A measure of a character's problem-solving ability.");
            Stat wisdom = new Stat("Wisdom", 5, "A measure of a character's common sense and/or spirituality.");
            Stat charisma = new Stat("Charisma", 4, "A measure of a characters social skills");

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

            int x = 100;
            Stat newStat = (Stat) x;
            string y = "Health";
            Stat newerStat = (Stat) y;
        }
    }
}
