using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Interfaces
{
    class Animal : ILoggable
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Animal(string name)
        {
            Name = name;
        }
        public void Log()
        {
            Console.WriteLine("Animal - Name: " + name);
        }
    }
}
