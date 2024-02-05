using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Project
{
    internal class Warrior : Unit
    {
        public Warrior() : base(30, 15, 10, 25, 250, 80, 50, 100, 1, 1, 0.2, 0.5, 0.2, 1, 2, 1, 1, "Warrior")
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
