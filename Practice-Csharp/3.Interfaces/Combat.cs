using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Interfaces
{
    class Combat
    {
        public List<Entity> FightersList;
        private List<IDamager> damagers;
        private List<IDamageable> damageables;

        public Combat(List<Entity> fighters)
        {
            FightersList = fighters;
            damageables = new List<IDamageable>();
            damagers = new List<IDamager>();
            for (int i = 0; i < fighters.Count; i++)
            {
                damageables.Add(fighters[i]);
                damagers.Add(fighters[i]);
            }
        }

        public void Fight()
        {
            Console.WriteLine("Press enter to begin a new round.");
            var rand = new Random();
            int fighterOne;
            int fighterTwo;

            while (FightersList.Count > 1)
            {
                fighterOne = 0;
                fighterTwo = 0;
                Console.ReadLine();
                Console.Clear();
                foreach (var fighter in FightersList)
                {
                    Console.Write(fighter.Name + "'s Health:  \t" + fighter.Health + "\n");
                }
                Console.WriteLine();

                while (fighterTwo == fighterOne)
                {
                    fighterOne = rand.Next(0, FightersList.Count);
                    fighterTwo = rand.Next(0, FightersList.Count);
                }

                damagers[fighterOne].DoDamage(damageables[fighterTwo]);

                for (int i = 0; i < FightersList.Count; i++)
                {
                    if (FightersList[i].Health <= 0)
                    {
                        FightersList.Remove(FightersList[i]);
                        damageables.Remove(damageables[i]);
                        damagers.Remove(damagers[i]);
                    }
                }
            }

            Console.Clear();
            Console.WriteLine(FightersList[0].Name + "'s Health:\t" + FightersList[0].Health + "\n");
            Console.WriteLine(FightersList[0].Name + " Wins!");
            Console.ReadLine();
        }
    }
}
