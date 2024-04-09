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
using System.Data;
using System.Reflection.Emit;


namespace resistance
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            R1.Visibility = Visibility.Collapsed;
            R2.Visibility = Visibility.Collapsed;
            R.Visibility = Visibility.Collapsed;
            Resistance1.Visibility = Visibility.Collapsed;
            Resistance2.Visibility = Visibility.Collapsed;
            TotalResistance.Visibility = Visibility.Collapsed;
            Om.Visibility = Visibility.Collapsed;

            string[] items = { "Параллельное", "Последовательное" };
            ComboBox.ItemsSource = items;
            if (ComboBox.SelectedItem == null)
            {
                ComboBox.SelectedItem = null;
            }
        }

        string globalCurrentStrength1;
        string globalCurrentStrength2;
        string globalTotalCurrentStrenght;
        string globalVoltage1;
        string globalVoltage2;
        string globalTotalVoltage;
        string globalResistance1;
        string globalResistance2;
        string globalTotalResistance;
        string globalSum = "+";
        string globalMulti = "*";
        string globalDivision = "/";



        private void RemoveText(object sender, RoutedEventArgs e)
        {
            TextBox CurrentStrength1 = (TextBox)sender;
            if (CurrentStrength1.Text == "0" as string)
            {
                CurrentStrength1.Text = "";
            }
            else
            {
                CurrentStrength1.Text = CurrentStrength1.Text;
            }
        }

        private void Text(object sender, RoutedEventArgs e)
        {
            TextBox CurrentStrength1 = (TextBox)sender;
            if (string.IsNullOrEmpty(CurrentStrength1.Text))
            {
                CurrentStrength1.Text = "0";
            }
            else
            {
                CurrentStrength1.Text = CurrentStrength1.Text;
            }
        }


        private void RemoveText2(object sender, RoutedEventArgs e)
        {
            TextBox Voltage1 = (TextBox)sender;
            if (Voltage1.Text == "0" as string)
            {
                Voltage1.Text = "";
            }
            else
            {
                Voltage1.Text = Voltage1.Text;
            }
        }
        private void Text2(object sender, RoutedEventArgs e)
        {
            TextBox Voltage1 = (TextBox)sender;
            if (string.IsNullOrEmpty(Voltage1.Text))
            {
                Voltage1.Text = "0";
            }
            else
            {
                Voltage1.Text = Voltage1.Text;
            }
        }
        private void RemoveText3(object sender, RoutedEventArgs e)
        {
            TextBox CurrentStrength2 = (TextBox)sender;
            if (CurrentStrength2.Text == "0" as string)
            {
                CurrentStrength2.Text = "";
            }
            else
            {
                CurrentStrength2.Text = CurrentStrength2.Text;
            }
        }
        private void Text3(object sender, RoutedEventArgs e)
        {
            TextBox CurrentStrength2 = (TextBox)sender;
            if (string.IsNullOrEmpty(CurrentStrength2.Text))
            {
                CurrentStrength2.Text = "0";
            }
            else
            {
                CurrentStrength2.Text = CurrentStrength2.Text;
            }
        }
        private void RemoveText4(object sender, RoutedEventArgs e)
        {
            TextBox Voltage2 = (TextBox)sender;
            if (Voltage2.Text == "0" as string)
            {
                Voltage2.Text = "";
            }
            else
            {
                Voltage2.Text = Voltage2.Text;
            }
        }
        private void Text4(object sender, RoutedEventArgs e)
        {
            TextBox Voltage2 = (TextBox)sender;
            if (string.IsNullOrEmpty(Voltage2.Text))
            {
                Voltage2.Text = "0";
            }
            else
            {
                Voltage2.Text = Voltage2.Text;
            }
        }

        private void CurrentStrength1_TextChanged(object sender, TextChangedEventArgs e)
        {
            CurrentStrength1.GotFocus += RemoveText;
            CurrentStrength1.LostFocus += Text;
            globalCurrentStrength1 = CurrentStrength1.Text;

            if (ComboBox != null)
            {
                string selectedValue = (string)ComboBox.SelectedItem;

                if (selectedValue == "Последовательное")
                {
                    globalCurrentStrength2 = CurrentStrength1.Text;
                    CurrentStrength2.Text = CurrentStrength1.Text;
                    globalTotalCurrentStrenght = globalCurrentStrength1;
                }
            }

        }

        private void Voltage1_TextChanged(object sender, TextChangedEventArgs e)
        {
            Voltage1.GotFocus += RemoveText2;
            Voltage1.LostFocus += Text2;
            globalVoltage1 = Voltage1.Text;
           
            if (ComboBox != null)
            {
                string selectedValue = (string)ComboBox.SelectedItem;
                if (selectedValue == "Параллельное")
                {
                    globalVoltage2 = Voltage1.Text;
                    Voltage2.Text = Voltage1.Text;
                    globalTotalVoltage = globalVoltage1;
                } 
                if (globalVoltage1 == "0")
                {
                    MessageBox.Show("Напряжение не может быть 0");
                }
            }
        }

        private void CurrentStrength2_TextChanged(object sender, TextChangedEventArgs e)
        {
            CurrentStrength2.GotFocus += RemoveText3;
            CurrentStrength2.LostFocus += Text3;
            globalCurrentStrength2 = CurrentStrength2.Text;
            if (ComboBox != null)
            {
                string selectedValue = (string)ComboBox.SelectedItem;

                if (selectedValue == "Последовательное")
                {
                    globalCurrentStrength1 = CurrentStrength2.Text;
                    CurrentStrength1.Text = CurrentStrength2.Text;
                    globalTotalCurrentStrenght = globalCurrentStrength2;
                }
            }
        }

        private void Voltage2_TextChanged(object sender, TextChangedEventArgs e)
        {
            Voltage2.GotFocus += RemoveText4;
            Voltage2.LostFocus += Text4;
            globalVoltage2 = Voltage2.Text;
            
            if (ComboBox != null)
            {
                string selectedValue = (string)ComboBox.SelectedItem;
                if (selectedValue == "Параллельное")
                {
                    globalVoltage1 = Voltage2.Text;
                    Voltage1.Text = Voltage2.Text;
                    globalTotalVoltage = globalVoltage2;
                }
                if (globalVoltage2 == "0")
                {
                    MessageBox.Show("Напряжение не может быть 0");
                }
                
            }
        }


        private void CurrentStrength1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (ComboBox.SelectedItem == null)
            {
                e.Handled = true;
                MessageBox.Show("Выберите тип резистора");
            }
            TextBox CurrentStrength1 = sender as TextBox;
            if (!char.IsDigit(e.Text, 0) && e.Text != "," && e.Text != ".")
            {
                e.Handled = true;
            }
            else if ((e.Text == "," || e.Text == ".") && CurrentStrength1.Text.Contains(",") && CurrentStrength1.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void Voltage1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (ComboBox.SelectedItem == null)
            {
                e.Handled = true;
                MessageBox.Show("Выберите тип резистора");
            }
            TextBox Voltage1 = sender as TextBox;
            if (!char.IsDigit(e.Text, 0) && e.Text != "," && e.Text != ".")
            {
                e.Handled = true;
            }
            else if ((e.Text == "," || e.Text == ".") && Voltage1.Text.Contains(",") && Voltage1.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void CurrentStrength2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (ComboBox.SelectedItem == null)
            {
                e.Handled = true;
                MessageBox.Show("Выберите тип резистора");
            }
            TextBox CurrentStrength2 = sender as TextBox;
            if (!char.IsDigit(e.Text, 0) && e.Text != "," && e.Text != ".")
            {
                e.Handled = true;
            }
            else if ((e.Text == "," || e.Text == ".") && CurrentStrength2.Text.Contains(",") && CurrentStrength2.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void Voltage2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (ComboBox.SelectedItem == null)
            {
                e.Handled = true;
                MessageBox.Show("Выберите тип резистора");
            }
            TextBox Voltage2 = sender as TextBox;
            if (!char.IsDigit(e.Text, 0) && e.Text != "," && e.Text != ".")
            {
                e.Handled = true;
            }
            else if ((e.Text == "," || e.Text == ".") && Voltage2.Text.Contains(",") && Voltage2.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ComboBox != null  && globalVoltage1 != "0" && globalVoltage2 != "0")
            {
                R1.Visibility = Visibility.Visible;
                R2.Visibility = Visibility.Visible;
                R.Visibility = Visibility.Visible;
                Resistance1.Visibility = Visibility.Visible;
                Resistance2.Visibility = Visibility.Visible;
                TotalResistance.Visibility = Visibility.Visible;
                Om.Visibility = Visibility.Visible;
                string selectedValue = (string)ComboBox.SelectedItem;
                string globalTotalCurrentStrenght = $"{globalCurrentStrength1} {globalSum} {globalCurrentStrength2}";
                string globalResistance1 = $"{globalVoltage1} {globalDivision} {globalCurrentStrength1}";
                Resistance1.Content = new DataTable().Compute(globalResistance1, null).ToString();
                string globalResistance2 = $"{globalVoltage2} {globalDivision} {globalCurrentStrength2}";
                Resistance2.Content = new DataTable().Compute(globalResistance2, null).ToString();
                if (selectedValue == "Параллельное")
                {
                    string globalTotalResistance = $" ({globalResistance1} {globalMulti} {globalResistance2}) {globalDivision} ({globalResistance1} {globalSum} {globalResistance2}) ";
                    TotalResistance.Content = new DataTable().Compute(globalTotalResistance, null).ToString();

                    string contentText = TotalResistance.Content.ToString();

                    if (double.TryParse(contentText, out double resistanceValue))
                    {
                        if (resistanceValue >= 1000)
                        {
                            double newValue = resistanceValue / 1000;

                            TotalResistance.Content = newValue;
                            Om.Content = "КОм";
                        }
                    }
                }
                else if (selectedValue == "Последовательное")
                {
                    string globalTotalResistance = $"{globalResistance1} {globalSum} {globalResistance2}";
                    TotalResistance.Content = new DataTable().Compute(globalTotalResistance, null).ToString();
                    string contentText = TotalResistance.Content.ToString();

                    if (double.TryParse(contentText, out double resistanceValue))
                    {
                        if (resistanceValue >= 1000)
                        {
                            double newValue = resistanceValue / 1000;

                            TotalResistance.Content = newValue;
                            Om.Content = "КОм";
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            CurrentStrength1.Text = "0";
            CurrentStrength2.Text = "0";
            Voltage1.Text = "0";
            Voltage2.Text = "0";



        }
    }
}
