using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Containers
{
    public class Stat
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
