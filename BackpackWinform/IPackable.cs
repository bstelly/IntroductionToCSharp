using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackpackWinform
{
    interface IPackable
    {
        string Name { get; set; }

        bool PickedUp { get; set; }

        void Pack(Backpack backpack);
    }
}
