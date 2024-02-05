using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project
{

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Interface1 character;
        public string[] items { get; set; }
        Unit unit;
        
        int Token = 0;
        public MainWindow() 
        {
            InitializeComponent();
            items = new string[] { "Warrior", "Wizard", "Rogue" };
            DataContext = this;
        }




        private void Choice_person_comboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
 

            if (Choice_person_comboBox.SelectedItem != null)
            {
                string selectedValue = Choice_person_comboBox.SelectedItem.ToString();
                if (selectedValue == "Warrior")

                {
                    unit = new Warrior();
                    CreateUnit(unit);
                }
                else if (selectedValue == "Wizard")
                {
                    unit = new Wizard();
                    CreateUnit(unit);
                }
                else if (selectedValue == "Rogue")
                {
                    unit = new Rogue();
                    CreateUnit(unit);
                }
            }

        }


        private void CreateUnit(Unit unit)
        {
            strength.Content = $" {unit.Strength.ToString()}";
            vitality.Content = $" {unit.Vitality.ToString()}";
            Dexterity.Content = $" {unit.Dexterity.ToString()}";
            Inteligence.Content = $" {unit.Inteligence.ToString()}";
            hp.Content = $" {unit.Health.ToString()}";
            mp.Content = $" {unit.Mana.ToString()}";
            pdam.Content = $"{unit.PDmg.ToString()}";
            mdam.Content = $"{unit.MDmg.ToString()}";
            crtdam.Content = $"{unit.CrtDmg.ToString()}";
            armor.Content = $"{unit.Armor.ToString()}";
            crtch.Content = $"{unit.CrtChance.ToString()}";
            mdef.Content = $"{unit.MDef.ToString()}";
            numberTokens.Content = Token.ToString();

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            numberTokens.Content = NumberOfTokens.Text;
            string strToken = NumberOfTokens.Text;
            Token += Convert.ToInt32(strToken);       
        }

        private void One_Click_1(object sender, RoutedEventArgs e)
        {


            if (unit != null & Token > 0 )
            {
                
                unit.Strength += 1;
                unit.StartHealth();
                unit.StartPDamage();
                
                Token--;
                CreateUnit(unit);
            }
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            if (unit != null & Token > 0)
            {
                unit.Dexterity += 1;
                unit.StartCrtDamage();
                unit.StartCrtChance();
                unit.StartArmor();
               
                Token--;
                CreateUnit(unit);
            }
        }

        private void throe_Click(object sender, RoutedEventArgs e)
        {
            if (unit != null & Token > 0)
            {
                unit.Vitality += 1;
                unit.StartHealth();
                
                Token--;
                CreateUnit(unit);
            }
        }

        private void three_click(object sender, RoutedEventArgs e)
        {
            if (unit != null & Token > 0)
            {
                unit.Inteligence += 1;
                unit.StartMDefense();
                unit.StartMDamage();
                unit.StartMana();
                
                Token--;
                CreateUnit(unit);
            }
        }
    }
}

