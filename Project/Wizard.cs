using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Wizard : Unit
    {
        public Wizard() : base(15, 20, 35, 15, 45, 80, 250, 70, 0.5, 1, 1, 1, 0.2, 1, 1.4, 0.2, 1.5, "Wizard")
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
