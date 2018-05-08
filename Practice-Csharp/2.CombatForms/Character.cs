using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.Containers;

namespace _2.CombatForms
{
    public class Character
    {
        public Dictionary<string, Stat> SavingThrows = new Dictionary<string, Stat>();
        public int ExperiencePoints { get; set; }
        public string CharacterName { get; set; }
        public int Level { get; set; }
    }
}
