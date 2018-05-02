using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackpackWinform
{
    class Armor : IPackable
    {
        public string Name { get; set; }
        public bool PickedUp { get; set; }
        public string ImageDirectory { get; set; }
        public void Pack(Backpack backpack)
        {
            backpack.Packables.Add(this);
        }
    }
}
