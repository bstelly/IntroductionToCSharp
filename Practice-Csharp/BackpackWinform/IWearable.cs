using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackpackWinform
{
    public interface IWearable
    {
        void EquipShield(Player player);
        void EquipBodyArmor(Player player);
        int Defense { get; set; }
    }
}
