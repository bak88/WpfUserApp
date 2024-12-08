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

namespace WpfUserApp
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

        private void ButtonRegClick(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string password = passBox.Password.Trim();
            string passwordRepeat = passBoxRepeat.Password.Trim();
            string email = textBoxEmail.Text.Trim().ToLower();

            if (login.Length < 5)
            {
                textBoxLogin.ToolTip = "Это поле введенно не корректно!";
                textBoxLogin.Background=Brushes.DarkRed;
            }
            else if(password.Length < 5) 
            {
                passBox.ToolTip = "Это поле введенно не корректно!";
                passBox.Background = Brushes.DarkRed;
            }
            else if (password != passwordRepeat)
            {
                passBoxRepeat.ToolTip = "Это поле введенно не корректно!";
                passBoxRepeat.Background = Brushes.DarkRed;
            }
            else if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                textBoxEmail.ToolTip = "Это поле введенно не корректно!";
                textBoxEmail.Background = Brushes.DarkRed;
            }
            else
            {
                textBoxLogin.ToolTip = string.Empty;
                textBoxLogin.Background = Brushes.Transparent;
                passBox.ToolTip = string.Empty;
                passBox.Background = Brushes.Transparent;
                passBoxRepeat.ToolTip = string.Empty;
                passBoxRepeat.Background = Brushes.Transparent;
                textBoxEmail.ToolTip = string.Empty;
                textBoxEmail.Background = Brushes.Transparent;

                MessageBox.Show("Все хорошо!");
            }


        }
    }
}
