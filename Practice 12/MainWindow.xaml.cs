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
using System.Windows.Threading;

namespace Practice_12
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DispatcherTimer livetime = new DispatcherTimer();
            livetime.Interval = TimeSpan.FromSeconds(1);
            livetime.Tick += (o, e) => { dataTimer.Text = DateTime.Now.ToString("dd/MM/yyyy"); periodTimer.Text = DateTime.Now.ToString("HH:mm:ss"); };
            livetime.Start();
        }

        private void Distance_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(xOneInput.Text) || string.IsNullOrEmpty(xTwoInput.Text) || string.IsNullOrEmpty(yOneInput.Text) || string.IsNullOrEmpty(yTwoInput.Text))
            {
                MessageBox.Show("Введите значения!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                firstTaskResult.Text = Math.Round(Math.Sqrt(Math.Pow(Double.Parse(xTwoInput.Text) - Double.Parse(xOneInput.Text), 2) + Math.Pow(Double.Parse(yTwoInput.Text) - Double.Parse(yOneInput.Text), 2)), 2).ToString();
            }
        }

        private void FirstDigit_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(threeDigitNumberInput.Text))
            {
                MessageBox.Show("Введите значение!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                secondTaskReuslt.Text = (int.Parse(threeDigitNumberInput.Text) / 100).ToString();
            }
        }

        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил Гаврюшин К. А. ИСП-34.", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
