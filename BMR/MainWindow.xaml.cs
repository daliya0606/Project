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
        private void textBox1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }
        private void Age_TextChanged(object sender, TextChangedEventArgs e)
        {
            RemovingTheSymbols(Age);
            globalAge = Age.Text;
        }
    }
}
