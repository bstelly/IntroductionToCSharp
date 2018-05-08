using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackpackWinform
{
    public class Player : Entity
    {
        public Armor Shield { get; set; }
        public Armor BodyArmor { get; set; }
        public Weapon Weapon { get; set; }
        public bool Poisoned { get; set; }
        public Backpack Inventory { get; set; }

        public void TakeDamage(int damage)
        {
            damage = damage - (Shield.Defense + BodyArmor.Defense);
            Health -= damage;
        }
        public void Drop(IPackable item)
        {
            if(Inventory.Packables.Contains(item))
            {
                item.PickedUp = false;
            }
            Inventory.Packables.Remove(item);
        }

        public Player(Backpack backpack)
        {
            Health = 100;

            Shield = null;
            BodyArmor = null;
            Weapon = null;
            Poisoned = false;
            Inventory = backpack;
        }
    }
}