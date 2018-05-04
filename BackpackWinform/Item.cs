using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BackpackWinform
{
    public class Item : IPackable, IConsumable
    {
        public string Name { get; set; }
        public bool PickedUp { get; set; }
        public string ImageDirectory { get; set; }
        public bool Cure { get; set; }
        public int Heal { get; set; }
        public void Pack(Backpack backpack)
        {
            PickedUp = true;
            backpack.Packables.Add(this);
        }

        public void Consume(Player player)
        {
            if (Heal != 0)
            {
                player.Health += Heal;
                if (player.Health > 100)
                {
                    player.Health = 100;
                }
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

    public class HPotion : Item
    {
        public HPotion()
        {
            Name = "Health Potion";
            PickedUp = false;
            Cure = false;
            Heal = 50;
            ImageDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName +
                @"\pics\potion.png";
        }

    }
    public class Antidote : Item
    {
        public Antidote()
        {
            Name = "Antidote";
            PickedUp = false;
            Cure = true;
            Heal = 0;
            ImageDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName +
                @"\pics\antidote.png";
        }
    }



}

