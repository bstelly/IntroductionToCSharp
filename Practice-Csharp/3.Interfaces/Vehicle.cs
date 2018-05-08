using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Interfaces
{
    class Vehicle : ILoggable
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Vehicle(string name)
        {
            Name = name;
        }
        public void Log()
        {
            Console.WriteLine("Vehicle - Name: " + name);
        }
    }
}
