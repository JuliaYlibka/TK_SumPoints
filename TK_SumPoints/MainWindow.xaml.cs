using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace TK_SumPoints
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Task1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Task2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Task3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Task4_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SumTask_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Rating_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        public bool Test( string one, string two, string tree, string four)
        {
            if (string.IsNullOrWhiteSpace(one) || string.IsNullOrWhiteSpace(two) || string.IsNullOrWhiteSpace(tree) || string.IsNullOrWhiteSpace(four))
            {
                MessageBox.Show("Введите баллы за все задачи!");
                return false;
            }
            if (int.TryParse(one, out int resone) && int.TryParse(two, out int restwo) && int.TryParse(tree, out int restree) && int.TryParse(four, out int resfour))
            {
                if (resone <= 10 && restwo <= 50 && restree <= 30 && resfour <= 10)
                {
                    int result = resone + restwo + restree + resfour;
                    SumTask.Text = result.ToString();
                    if (result >= 0 && result <= 19)
                    {
                        Rating.Text = "2";
                        Rating.Background = Brushes.Red; // здесь ошибка. исправить добавить везде ретёрн.
                    }
                    if (result >= 20 && result <= 39)
                    {
                        Rating.Text = "3";
                        Rating.Background = Brushes.Orange;
                        return true;

                    }
                    if (result >= 40 && result <= 69)
                    {
                        Rating.Text = "4";
                        Rating.Background = Brushes.YellowGreen;
                        return true;

                    }
                    if (result >= 70 && result <= 100)
                    {
                        Rating.Text = "5";
                        Rating.Background = Brushes.LightGreen;
                        return true;

                    }
                    return true;


                }
                else
                {
                    MessageBox.Show("Внимательно посмотрите на максимальное количество баллов в каждом задании!");
                    return false;

                }
            }
            return false;
        }
   
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Test(Task1.Text,Task2.Text,Task3.Text,Task4.Text);
        }
        public void OnlyInt(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[0-9]");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}



/*   код до рефакторинга
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace TK_SumPoints
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Task1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Task2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Task3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Task4_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SumTask_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Rating_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

   
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(Task1.Text) || string.IsNullOrWhiteSpace(Task2.Text) || string.IsNullOrWhiteSpace(Task3.Text) || string.IsNullOrWhiteSpace(Task4.Text))
            {
                MessageBox.Show("Введите баллы за все задачи!");
                return;
            }
            if (int.TryParse(Task1.Text, out int one) && int.TryParse(Task2.Text, out int two) && int.TryParse(Task3.Text, out int tree) && int.TryParse(Task4.Text, out int four))
            {
                if (one <= 10 && two <= 50 && tree <= 30 && four <= 10)
                {
                    int result = one + two + tree + four;
                    SumTask.Text = result.ToString();
                    if (result >= 0 && result <= 19)
                    {
                        Rating.Text = "2";
                        Rating.Background = Brushes.Red;
                    }
                    if (result >= 20 && result <= 39)
                    {
                        Rating.Text = "3";
                        Rating.Background = Brushes.Orange;
                    }
                    if (result >= 40 && result <= 69)
                    {
                        Rating.Text = "4";
                        Rating.Background = Brushes.YellowGreen;
                    }
                    if (result >= 70 && result <= 100)
                    {
                        Rating.Text = "5";
                        Rating.Background = Brushes.LightGreen;
                    }
                    return;
                }
                else
                {
                    MessageBox.Show("Внимательно посмотрите на максимальное количество баллов в каждом задании!");
                    return;

                }


            }
        }
        public void OnlyInt(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[0-9]");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
*/