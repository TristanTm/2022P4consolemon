using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    internal class Skill
    {
        public string skillName;
        public int damage;
        public int energyCost;



        internal void UseOn(ConsoleMon caster, ConsoleMon target)
        {
            caster.DepleteEnergy(energyCost);
            target.TakeDamage(damage);
        }
    }

 
}
