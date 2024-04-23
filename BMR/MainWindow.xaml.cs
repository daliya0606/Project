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
using System.Data;

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
            Mistake_Age.Visibility = Visibility.Collapsed;
            Mistake_Height.Visibility = Visibility.Collapsed;
            Mistake_Weight.Visibility = Visibility.Collapsed;
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
            if (!string.IsNullOrWhiteSpace(Height.Text))
            { 
                if (int.Parse(Height.Text) > 250 || int.Parse(Height.Text) < 50)
                {
                    Mistake_Height.Content = "Введите коректное значение роста!";
                    Mistake_Height.Visibility = Visibility.Visible;
                }

                else
                {
                    Mistake_Height.Visibility = Visibility.Collapsed;
                    globalHeight = Height.Text;
                }

            }
               
        }
        

        private void Age_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Age.Text))
            {
                if (int.Parse(Age.Text) > 100 || int.Parse(Age.Text) < 0)
                {
                    Mistake_Age.Content = "Введите коректное значение возраста!";
                    Mistake_Age.Visibility = Visibility.Visible;
                }

                else
                {
                    Mistake_Age.Visibility = Visibility.Collapsed;
                    globalAge = Age.Text;
                }

            }
        }

        private void Weight_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Weight.Text))
            {
                if (int.Parse(Weight.Text) > 200 || int.Parse(Weight.Text) < 2)
                {
                    Mistake_Weight.Content = "Введите коректное значение веса!";
                    Mistake_Weight.Visibility = Visibility.Visible;
                }

                else
                {
                    Mistake_Weight.Visibility = Visibility.Collapsed;
                    globalWeight = Weight.Text;
                }

            }
        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            if (TheGender.SelectedItem != null && Activity.SelectedItem != null && globalAge != null && globalWeight != null && globalHeight != null)
               
            {
                string selectedGender = (string)TheGender.SelectedItem;
                string selectedActivity = (string)Activity.SelectedItem;
                if (selectedGender == "Мужской")
                {
                    globalBMR = $"66 + 13.7 * {globalWeight} + 5 * {globalHeight} - 6.8 * {globalAge}";
                    BMR.Content = new DataTable().Compute(globalBMR, null).ToString();
                    switch (selectedActivity)
                    {
                        case "Сидячий":
                            globalTEED = $"({globalBMR})* 1.2";
                            TDEE.Content = new DataTable().Compute((globalTEED, null).ToString();
                            break;
                        case "Немного активный":
                            globalTEED = $"({globalBMR}) * 1.375";
                            TDEE.Content = new DataTable().Compute(globalTEED, null).ToString();
                            break;
                        case "Средняя активность":
                            globalTEED = $"({globalBMR}) * 1.55";
                            TDEE.Content = new DataTable().Compute(globalTEED, null).ToString();
                            break;
                        case "Большая активность":
                            globalTEED = $"({globalBMR}) * 1.725";
                            TDEE.Content = new DataTable().Compute(globalTEED, null).ToString();
                            break;
                        case "Экстра нагрузка":
                            globalTEED = $"({globalBMR}) * 1.9";
                            TDEE.Content = new DataTable().Compute(globalTEED, null).ToString();
                            break;
                    }
                }
                if (selectedGender == "Женский")
                {
                    globalBMR = $"655 + 9.6 * {globalWeight} + 1.8 * {globalHeight} - 4.7 * {globalAge}";
                    BMR.Content = new DataTable().Compute(globalBMR, null).ToString();
                    switch (selectedActivity)
                    {
                        case "Сидячий":
                            globalTEED = $"({globalBMR}) * 1.2";
                            TDEE.Content = new DataTable().Compute(globalTEED, null).ToString();
                            break;
                        case "Немного активный":
                            globalTEED = $"({globalBMR}) * 1.375";
                            TDEE.Content = new DataTable().Compute(globalTEED, null).ToString();
                            break;
                        case "Средняя активность":
                            globalTEED = $"({globalBMR}) * 1.55";
                            TDEE.Content = new DataTable().Compute(globalTEED, null).ToString();
                            break;
                        case "Большая активность":
                            globalTEED = $"({globalBMR}) * 1.725";
                            TDEE.Content = new DataTable().Compute(globalTEED, null).ToString();
                            break;
                        case "Экстра нагрузка":
                            globalTEED = $"({globalBMR}) * 1.9";
                            TDEE.Content = new DataTable().Compute(globalTEED, null).ToString();
                            break;
                        default:
                            MessageBox.Show("Укажите все значения");
                            break;

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
            Height.Text = null;
            Weight.Text = null;
            Age.Text = null;
            TheGender.SelectedItem = null;
            Activity.SelectedItem = null;
            BMR.Content = null;
            TDEE.Content = null;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
