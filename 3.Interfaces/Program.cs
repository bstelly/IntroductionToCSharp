using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Interfaces
{
    static class Program
    {
        //static void Test(List<ILoggable> loggables)
        //{
        //    foreach (var item in loggables)
        //    {
        //        item.Log();
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    Test(new List<ILoggable>()
        //    {
        //        new Animal("Scooby"),
        //        new Animal("Fluffy"),
        //        new Animal("Sonic"),
        //        new Animal("Tails"),
        //        new Animal("Quackers"),
        //        new Vehicle("Lightning"),
        //        new Vehicle("Herby"),
        //        new Vehicle("Blue")
        //    });
        //    Console.ReadLine();
        //}
        static void Fight(List<IDamager> damagers)
        {

        }
        static void Main(string[] args)
        {
            var fighters = new List<Entity>
            {
                new Assassin("Ezio", 100),
                new Ninja("Scorpion", 100),
                new Robot("Zero", 100),
                new Witcher("Geralt", 100),
                new Spartan("Master Chief", 100),
                new Nord("Ulfric", 100),
                new Soldier("Shephard", 100)
            };
        }




    }
}