using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    internal class ConsoleMon
    {
        public string Name;
        public int HP;
        public int energy;


        public void TakeDamage(int damage)
        {
            HP = HP - damage; 
        }

        public void DepleteEnergy(int energy)
        {
            this.energy = this.energy - energy;
        }
    }


}
