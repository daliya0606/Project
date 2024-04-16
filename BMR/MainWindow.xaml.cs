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

namespace BMR
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string[] gender = { "Мужской", "Женский" };
            TheGender.ItemsSource = gender;
            if (TheGender.SelectedItem == null)
            {
                TheGender.SelectedItem = null;
            }

            string[] activity = { "Сидячий", "Немного активный", "Средняя активность", "Большая активность", "Экстра нагрузка" };
            Activity.ItemsSource = activity;
            if (Activity.SelectedItem == null)
            {
                Activity.SelectedItem = null;
            }
        }

        string globalAge;
        string globalWeight;
        string globalHeight;
        string globalBMR;
        string globalTEED;

        private void RemovingTheSymbols(TextBox textBox)
        {
            textBox.PreviewTextInput += (sender, e) =>
            {
                if (!char.IsDigit(e.Text, 0))
                {
                    e.Handled = true;
                }
            };
        }


        private void Age_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox CurrentStrength1 = sender as TextBox;
            if (!char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void Weight_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox CurrentStrength1 = sender as TextBox;
            if (!char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void Height_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox CurrentStrength1 = sender as TextBox;
            if (!char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void Height_TextChanged(object sender, TextChangedEventArgs e)
        {
            globalHeight = Height.Text;
            if (int.Parse(globalHeight) > 250 || int.Parse(globalHeight) < 50)
            {
                MessageBox.Show("Ведите коректное значение роста");
            }
        }
        

        private void Age_TextChanged(object sender, TextChangedEventArgs e)
        {
            globalAge = Age.Text;
        }

        private void Weight_TextChanged(object sender, TextChangedEventArgs e)
        {
            globalWeight = Weight.Text;
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            if (TheGender != null && Activity != null && globalAge != null && globalWeight != null && globalHeight != null)
               
            {
                string selectedGender = (string)TheGender.SelectedItem;
                string selectedActiviry = (string)Activity.SelectedItem;
                if (selectedGender == "Мужской")
                {
                    switch (selectedActiviry)
                    {
                        case Сидячий:
                    }    
                }
            }
            else
            {
                MessageBox.Show("Укажите все значения");
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
