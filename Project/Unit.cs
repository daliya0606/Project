
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
        private double _countPDamage;
        private double _countArmor;
        private double _countMDamage;
        private double _countMDefence;
        private double _countCrtChanse;
        private double _countCrtDamage;
        private double _countHealthVit;
        private int intNumber;
        private double DoubleNumber;
        private double _countHealthStr;
        private double _valueManaInt;

        public Unit(int strength,
            int dexterity, int inteligence, int vitality, int maxStrength,
            int maxDexterity, int maxInteligence, int maxVitality,
            double countPDamage, double countArmor, double countMDamage, double countMDefence,
            double countCrtChanse, double countCrtDamage, double countHealthVit, double countHealthStr,
            double valueManaInt, string name

           )
        {


            Strength = strength;
            Dexterity = dexterity;
            Inteligence = inteligence;
            Vitality = vitality;
            _strength = strength;
            _vitality = vitality;
            _inteligence = inteligence;
            _maxStrength = maxStrength;
            _maxDexterity = maxDexterity;
            _maxInteligence = maxInteligence;
            _maxVitality = maxVitality;
            _dexterity = dexterity;
            _countHealthVit = countHealthVit;
            _countHealthStr = countHealthStr;
            _valueManaInt = valueManaInt;
            _countPDamage = countPDamage;
            _countArmor = countArmor;
            _countMDamage = countMDamage;
            _countMDefence = countMDefence;
            _countCrtChanse = countCrtChanse;
            _countCrtDamage = countCrtDamage;
            _name = name;


        }
        public string Name { get { return _name; } set { _name = value; } }
        

        public int Strength
        {
            get { return _strength; }
            set
            {

                if (_strength >= _maxStrength)
                {
                    _strength = _maxStrength;
                }
                else _strength = value;

            }
        }
        public int Vitality
        {
            get { return _vitality; }
            set
            {

                if (_vitality >= _maxVitality)
                {
                    _vitality = _maxVitality;
                }
                else _vitality = value;

                
            }
        }
        public int Inteligence
        {
            get { return _inteligence; }
            set
            {

                if (_inteligence >= _maxVitality)
                {
                    _inteligence = _maxInteligence;
                }
                else _inteligence = value;

            }
        }
        public int Dexterity
        {
            get { return _dexterity; }
            set
            {

                if (_dexterity >= _maxDexterity)
                {
                    _dexterity = _maxDexterity;
                }
                else _dexterity = value;

            }
        }
        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }
        
        public int Mana
        {
            get { return _mana; }
            set { _mana = value; }
        }

        
        public int PDmg
        {
            get { return _damage; }
            set { _damage = value; }
        }
        public int Armor
        {
            get { return _armor; }
            set { _armor = value;}
        }
        public int MDef
        {
            get { return _maxDefense; }
            set { _maxDefense = value;}
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
            set { _crtDamage = value;}
        }
        public void StartCrtDamage()
        {
            CrtDmg = 0;
            double def = 0;
            int defInt = 0;
            CheckNumber(_countCrtDamage);
            for (int i = 0; i < Dexterity; i++)
            {

                def += (float)DoubleNumber;
                if (def >= 1)
                {
                    CrtDmg++;
                    defInt = (int)def;
                    def -= defInt;
                }

                CrtDmg += intNumber;
            }
        }
        public void StartCrtChance()
        {
            CrtChance = 0;
            double def = 0;
            int defInt = 0;
            CheckNumber(_countCrtChanse);
            for (int i = 0; i < Dexterity; i++)
            {

                def += (float)DoubleNumber;
                if (def >= 1)
                {
                    CrtChance++;
                    defInt = (int)def;
                    def -= defInt;
                }

                CrtChance += intNumber;
            }
        }
        public void StartMDefense()
        {
            MDef = 0;
            double def = 0;
            int defInt = 0;
            CheckNumber(_countMDefence);
            for (int i = 0; i < Inteligence; i++)
            {

                def += (float)DoubleNumber;
                if (def >= 1)
                {
                    MDef++;
                    defInt = (int)def;
                    def -= defInt;
                }

                MDef += intNumber;
            }
        }
        public void StartMDamage()
        {
            MDmg = 0;
            double def = 0;
            int defInt = 0;
            CheckNumber(_countMDamage);
            for (int i = 0; i < Inteligence; i++)
            {

                def += (float)DoubleNumber;
                if (def >= 1)
                {
                    MDmg++;
                    defInt = (int)def;
                    def -= defInt;
                }

                MDmg += intNumber;
            }
        }
        public void StartArmor()
        {
            Armor = 0;
            double def = 0;
            CheckNumber(_countArmor);
            for (int i = 0; i < Dexterity; i++)
            {

                def += DoubleNumber;
                
                if ((int)def >= 1)
                {
                    Armor++;
                    def--;
                }
                Armor += intNumber;



            }
        }
        public void StartPDamage()
        {PDmg = 0;
            double def = 0;
            CheckNumber(_countPDamage);
            for (int i = 0; i < Strength; i++)
            {
                
                def += DoubleNumber;
                if (def >= 1)
                {
                    PDmg++;
                    def--;
                }
                PDmg += intNumber;
            }
            
        }
        public void StartMana()
        {   Mana = 0; 
            double def = 0;
            CheckNumber(_valueManaInt);
             
            for (int i = 0; i < Inteligence; i++)
            {
                
                def += DoubleNumber;
                if (def >= 1)
                {
                    Mana++;
                    def--;
                }
                Mana += intNumber;


                
            }
            
        }
        public void StartHealth()
        {
            Health = 0;
            CheckNumber(_countHealthVit);
            double def = 0;
            int defInt = 0;
            for (int i = 0; i < Vitality; i++)
            {
                def += (float)DoubleNumber;
                
                if (def >= 1)
                {
                    Health++;
                    defInt = (int)def;
                    def-= defInt;
                    
                }
                Health += intNumber;


            }
            
            CheckNumber(_countHealthStr);
            def = 0;
            for (int i = 0; i < Strength; i++)
            {

                def += (float)DoubleNumber;
                if (def >= 1)
                {
                    Health++;
                    defInt = (int)def;
                    def -= defInt;
                }

                Health += intNumber;
            }
            

        }
        public void CheckNumber(double number)
        {
            if ((int)number == number)
            {
               intNumber = (int)number;
                DoubleNumber = 0;
            }
            else
            {
                intNumber = (int)number;
               
                DoubleNumber = number - (float)intNumber;  
            };
            
        }
        
    }

}



