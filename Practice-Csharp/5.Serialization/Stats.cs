using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.Containers;

namespace _5.Serialization
{
    [Serializable]

    public class Stats
    {
        public List<Stat> statList = new List<Stat>();

        public Stats()
        {
            statList = new List<Stat>();
        }
    }
}
