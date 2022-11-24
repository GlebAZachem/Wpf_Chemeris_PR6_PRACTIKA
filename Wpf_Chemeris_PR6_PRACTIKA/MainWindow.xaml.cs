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

namespace Wpf_Chemeris_PR6_PRACTIKA
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string User = Username.Text;
            string Password1 = Password.Text;
            if (User == "" && Password1 == "")
                MessageBox.Show($"{Environment.NewLine}Введите логин{Environment.NewLine}Введите пароль");
            else if (User == "")
                MessageBox.Show("Введите логин");
            else if (Password1 == "")
                MessageBox.Show("Введите пароль");
            else if (User == "1" && Password1 == "1")
                Pomogite.Navigate(new Uri("Page1.xaml", UriKind.Relative));
            else if (User != "1" && User != "2")
                MessageBox.Show("Логин неверный");
            else if (Password1 != "1" && Password1 != "2")
                MessageBox.Show("Пароль не правильный");
            else if (User == "2" && Password1 == "2")
                Pomogite.Navigate(new Uri("Page2.xaml", UriKind.Relative));

            Label2.Content = "Password";
            Password.Text = "";

            if (RM.IsChecked == false)
            {Label1.Content = "Username";
                Username.Text = "";}
            else if (RM.IsChecked == true)
            {Label1.Content = "";
                Username.Text = User;}
        }
        private void Username_TextChanged(object sender, TextChangedEventArgs e)
        {
            Label1.Content = "";
            if (Username.Text == "")
                Label1.Content = "Username";
        }
        private void Password_TextChanged(object sender, TextChangedEventArgs e)
        {
            Label2.Content = "";
            if (Password.Text == "")
                Label2.Content = "Password";
        }
    }
}
