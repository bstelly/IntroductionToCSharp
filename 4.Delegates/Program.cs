using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.Containers;

namespace _4.Delegates
{
    class Program
    {
        static int HandleValueChange(int newValue)
        {
            Console.WriteLine("Stat has been changed to: " + newValue);
            return newValue;
        }
        static void Main(string[] args)
        {
            var myStat = new Stat("Health", 100, "Amount of health");
            myStat.OnChange = HandleValueChange;
            myStat.Value = 30;
            myStat.Value = 67;
            myStat.Value = 83;

            Console.ReadLine();
        }

    }
}
