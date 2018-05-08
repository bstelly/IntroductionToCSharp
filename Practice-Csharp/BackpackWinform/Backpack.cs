using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackpackWinform
{
    public class Backpack
    {
        public List<IPackable> Packables;

        public Backpack()
        {
            Packables = new List<IPackable>();
        }
    }
}
