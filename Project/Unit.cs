using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Unit
    {
        private string _name;
        private int _health; //  есть
        private int _maxHealth;
        private int _strength;
        private int _vitality;
        private int _inteligence;
        private int _dexterity;
        private int _maxStrength;
        private int _maxVitality;
        private int _maxInteligence;
        private int _maxDexterity;
        private int _maxhealth; // не нужен 
        private int _mana;
        private int _maxMana;
        private int _damage;
        private int _armor;
        private int _maxDefense;
        private int _maxDamage;
        private int _crtChanse;
        private int _crtDamage;
        private int _defense;


        public Unit( int maxHealth, int health, int strength,
            int dexterity, int inteligence, int vitality, int maxStrength,
            int maxDexterity, int maxInteligence, int maxVitality, int mana, int maxMana, int damage, int crtDamage,
            int defense, int crtChanse, int maxDamage, int armor, int maxDefense)
        {

            
            _health = health;
            _maxHealth = maxHealth;
            _strength = strength;
            _vitality = vitality;
            _inteligence = inteligence;
            _maxStrength = maxStrength;
            _maxDexterity = maxDexterity;
            _maxInteligence = maxInteligence;
            _maxVitality = maxVitality;
            _mana = mana;
            _maxMana = maxMana;
            _damage = damage;
            _crtDamage = crtDamage;
            _dexterity = dexterity;
            _defense = defense;
            _crtChanse = crtChanse;
            _maxDamage = maxDamage;
            _armor = armor;
            _maxDefense = maxDefense;



        }




        //public Warrior()
        //{
        //    Strength = 30;
        //    Dexterity = 15;
        //    Inteligence = 10;
        //    Vitality = 25;
        //    addVital();
        //}
        public int Strength
        {
            get { return _strength; }
            set
            {
                _strength = value;
                PDmg = value;
                if (_strength > _maxStrength)
                {
                    Strength = _maxStrength;
                }
                addVital();
            }
        }
        public int Vitality
        {
            get { return _vitality; }
            set
            {
                _vitality = value;
                if (_vitality > _maxVitality)
                {
                    _vitality = _maxVitality;

                }
                addVital();
            }
        }
        public int Inteligence
        {
            get { return _inteligence; }
            set
            {
                _inteligence = value;
                int mp = 0;
                int mdmg = 0;
                double mdmg_b = 0;
                int mdef = 0;
                double mdef_b = 0;
                if (_inteligence > _maxInteligence)
                {
                    _inteligence = _maxInteligence;
                }
                for (int i = 0; i < _inteligence; i++)
                {
                    mp++;
                    mdmg_b += 0.2;
                    mdef_b += 0.5;
                    if (mdmg_b >= 1)
                    {
                        mdmg++;
                        mdmg_b--;
                    }
                    if (mdef_b >= 1)
                    {
                        mdef++;
                        mdef_b--;
                    }
                }
                MDef = mdef;
                MDmg = mdmg;
                MaxMana = mp;
            }
        }
        public int Dexterity
        {
            get { return _dexterity; }
            set
            {
                _dexterity = value;
                Armor = value;
                int crtch = 0;
                double crtch_b = 0;
                int crtdmg = 0;
                double crtdmg_b = 0;
                if (_dexterity > _maxDexterity)
                {
                    _dexterity = _maxDexterity;
                }
                for (int i = 0; i <= _dexterity; i++)
                {
                    crtch_b += 0.2;
                    crtdmg_b += 0.1;
                    if (crtch_b >= 1)
                    {
                        crtch++;
                        crtch_b--;
                    }
                    if (crtdmg_b >= 1)
                    {
                        crtdmg++;
                        crtdmg_b--;
                    }
                }
                CrtChance = crtch;
                CrtDmg = crtdmg;
            }
        }
        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }
        public int MaxHealth
        {
            get { return _maxHealth; }
            set
            {
                if (Health == MaxHealth)
                {
                    _maxHealth = value;
                    _health = value;
                }
                else
                    _maxHealth = value;
            }
        }
        public int Mana
        {
            get { return _mana; }
            set
            {
                _mana = value;
                if (_mana > _maxMana)
                    _mana = _maxMana;
            }
        }

        public int MaxMana
        {
            get { return _maxMana; }
            set
            {

                if (Mana == MaxMana)
                {
                    _maxMana = value;
                    _mana = _maxMana;
                }
                else
                    _maxMana = value;
            }
        }
        public int PDmg
        {
            get { return _damage; }
            set { _damage = value; }
        }
        public int Armor
        {
            get { return _armor; }
            set
            {
                _armor = value;
            }
        }
        public int MDef
        {
            get { return _maxDefense; }
            set
            {
                _maxDefense = value;
            }
        }
        public int MDmg
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }
        public int CrtChance
        {
            get { return _crtChanse; }
            set { _crtChanse = value; }
        }
        public int CrtDmg
        {
            get { return _crtDamage; }
            set
            {
                _crtDamage = value;
            }
        }
        public void addVital()
        {
            int hp = 0;
            for (int i = 0; i < _vitality; i++)
            {
                hp += 2;
            }
            for (int i = 0; i < _strength; i++)
            {
                hp++;
            }
            MaxHealth = hp;
        }
    }

}

