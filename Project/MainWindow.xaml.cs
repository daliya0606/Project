using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        Warrior warrior = new Warrior();
        public string[] items { get; set; }
        
        public MainWindow() 
        {

            InitializeComponent();
            items = new string[] { "Warrior", "Item 2", "Item 3" };
            DataContext = this;
            Choice_name_person.Content = "Введите имя перса";
            Choice_person.Content = "Выберите перса";
            strength.Content = $"strengt равно {warrior.Strength.ToString()}";
            vitality.Content = $"vitality {warrior.Vitality.ToString()}";
            dexterity.Content = $"dex {warrior.Dexterity.ToString()}";
            inteligence.Content = $"int {warrior.Inteligence.ToString()}";
            health.Content = $"hp: {warrior.Health.ToString()} / {warrior.MaxHealth.ToString()}";
            mana.Content = $"mana {warrior.Mana.ToString()}";

        }
        public void statsUpdate()
        {
            
        }
    }
}

