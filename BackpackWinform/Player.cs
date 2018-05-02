using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackpackWinform
{
    class Player : Entity
    {
        public int Shield { get; set; }
        public int BodyArmor { get; set; }
        public int Weapon { get; set; }
        public bool Poisoned { get; set; }
        public Backpack Inventory { get; set; }
    }
}