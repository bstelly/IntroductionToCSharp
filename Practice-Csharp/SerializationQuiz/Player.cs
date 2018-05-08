using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace SerializationQuiz
{
    [Serializable]
    public class Player
    {
        public int Experience { get; set; }
        public int Level { get; set; }

        public Player(int experience, int level)
        {
            Experience = experience;
            Level = level;
        }
    }
}
