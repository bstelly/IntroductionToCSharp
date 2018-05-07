using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BackpackWinform
{
    public class Armor : IPackable, IWearable
    {
        public string Name { get; set; }
        public bool PickedUp { get; set; }
        public string ImageDirectory { get; set; }
        public int Defense { get; set; }
        public void Pack(Backpack backpack)
        {
            backpack.Packables.Add(this);
        }
        public void EquipShield(Player player)
        {
            player.Shield = this;
        }
        public void EquipBodyArmor(Player player)
        {
            player.BodyArmor = this;
        }
    }

    public class Shield : Armor
    {
        public Shield()
        {
            Name = "Shield";
            PickedUp = false;
            ImageDirectory = Directory.GetParent(Directory.GetCurrentDirectory()) +
                @"\pics\shield.png";
            Defense = 10;
        }

    }

    public class BodyArmor : Armor
    {
        public BodyArmor()
        {
            Name = "Body Armor";
            PickedUp = false;
            ImageDirectory = Directory.GetParent(Directory.GetCurrentDirectory()) +
                @"\pics\KevlarVest.png";
            Defense = 15;

        }
    }
}
