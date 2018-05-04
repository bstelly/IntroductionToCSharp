using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BackpackWinform
{
    public class Weapon : IPackable, IDamager
    {
        public string Name { get; set; }
        public bool PickedUp { get; set; }
        public string ImageDirectory { get; set; }
        public int AttackValue { get; set; }
        public void DoDamage(Entity enemy)
        {
            enemy.Health -= AttackValue;
        }
        public void Pack(Backpack backpack)
        {
            backpack.Packables.Add(this);
        }
        public void Equip(Player player)
        {
            player.Weapon = this;
        }
    }

    public class Gun : Weapon
    {
        public Gun()
        {
            Name = "Beretta 92";
            PickedUp = false;
            ImageDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName +
                @"\pics\beretta92.png";
            AttackValue = 35;
        }
    }

    public class Knife : Weapon
    {
        public Knife()
        {
            Name = "Combat Knife";
            PickedUp = false;
            ImageDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName +
                @"\pics\knife.png";
            AttackValue = 10;
        }
    }


}
