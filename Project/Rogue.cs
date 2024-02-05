using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Rogue : Unit
    {
        public Rogue() : base(20, 30, 15, 20, 65, 250, 70, 80, 0.5, 1.5, 0.2, 0.5, 0.2, 1, 1.5, 0.5, 1.2, "Rogue")
        {
            StartHealth();
            StartMana();
            StartPDamage();
            StartArmor();
            StartMDamage();
            StartMDefense();
            StartCrtChance();
            StartCrtDamage();
        }
    }
}
