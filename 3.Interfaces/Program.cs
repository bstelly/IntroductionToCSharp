using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Interfaces
{
    static class Program
    {
        static void Main(string[] args)
        {
            var fighters = new List<Entity>
            {
                new Assassin("Ezio", 100, 11, 10),
                new Ninja("Scorpion", 100, 10, 5),
                new Robot("Zero", 100, 14, 10),
                new Witcher("Geralt", 100, 13, 10),
                new Spartan("MasterChief", 100, 18, 12),
                new Nord("Ulfric", 100, 12, 3),
                new Soldier("Shephard", 100, 12, 11)
            };
            var game = new Combat(fighters);
            game.Fight();
        }





    }
}