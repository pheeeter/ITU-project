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
using System.Windows.Shapes;

namespace Project
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void registration_click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(registerBox.Text) || string.IsNullOrWhiteSpace(passwdRegisterBox.Password))
            {
                MessageBox.Show("Please enter e-mail and password!");
                return;
            }
            MessageBox.Show("Registration was successful!");
            MainWindow loginWindow = new MainWindow();
            loginWindow.Show();
            this.Close();
        }


    }
}
