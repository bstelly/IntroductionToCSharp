using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackpackWinform
{
    interface IDamager
    {
        int DoDamage(Entity enemy);
        int attackValue { get; set; }
    }
}
