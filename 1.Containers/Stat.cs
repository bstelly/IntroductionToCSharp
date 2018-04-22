using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Containers
{
    public class Stat
    {
        public delegate int TStatIsChanged(int newValue);
        public TStatIsChanged OnChange;
        public string Name { get; set; }
        public int Value {
            get
            {
                return Value;
            }
            set
            {
                Value = value;
                OnChange(value);

            }
            }
        public string Description { get; private set; }

        public Stat(string name, int value, string description)
        {
            Name = name;
            Value = value;
            Description = description;
        }
        public static explicit operator Stat(int i)
        {
            Stat temp = new Stat("Default", i, "Description");
            return temp;
        }

        public static explicit operator Stat(string i)
        {
            Stat temp = new Stat(i, 10, "Description");
            return temp;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

}
