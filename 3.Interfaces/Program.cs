using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            List<Animal> animals = new List<Animal>();
            Animal dog = new Animal("Scooby");
            Animal cat = new Animal("Fluffy");
            Animal hedgehog = new Animal("Sonic");
            Animal fox = new Animal("Tails");
            Animal duck = new Animal("Quackers");
            Vehicle carOne = new Vehicle("Lightning");
            Vehicle carTwo = new Vehicle("Herby");
            Vehicle carThree = new Vehicle("Blue");
            animals.Add(dog);
            animals.Add(cat);
            animals.Add(hedgehog);
            animals.Add(fox);
            animals.Add(duck);
            vehicles.Add(carOne);
            vehicles.Add(carTwo);
            vehicles.Add(carThree);



            for (int i = 0; i < animals.Count; i++)
            {
                animals[i].Log();
            }
            for (int i = 0; i < vehicles.Count; i++)
            {
                vehicles[i].Log();
            }

            Console.ReadLine();
        }
    }
}
