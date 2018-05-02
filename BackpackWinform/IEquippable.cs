using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackpackWinform
{
    interface IEquippable
    {
        void Equip(Player player);
        int Defense { get; set; }
    }
}
