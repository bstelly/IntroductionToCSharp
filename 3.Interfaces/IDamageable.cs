using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Interfaces
{
    public interface IDamageable
    {
        int ArmorClass { get; set; }
        bool TakeDamage(int amount);
    }

    public interface IDamager
    {
        int HitModifier { get; set; }
        void DoDamage(IDamageable entity);
    }
}


