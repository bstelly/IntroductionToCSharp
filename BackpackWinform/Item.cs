using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackpackWinform
{
    class Item : IPackable
    {
        public string Name { get; set; }
        public bool PickedUp { get; set; }
        public string ImageDirectory { get; set; }
        public bool Cure { get; set; }
        public int Heal { get; set; }
        public void Pack(Backpack backpack)
        {
            backpack.Packables.Add(this);
        }

        public void Consume(Player player)
        {
            if (Heal != 0)
            {
                player.Health += Heal;
            }
            else
            {
                if (Cure)
                {
                    player.Poisoned = Cure;
                }
            }
        }
    }
}

