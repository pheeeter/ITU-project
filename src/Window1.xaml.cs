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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void settings_click(object sender, RoutedEventArgs e)
        {
            Window2 settingsWindow = new Window2();
            settingsWindow.Show();
        }

        private void user_click(object sender, RoutedEventArgs e)
        {   
        
            Window3 userWindow = new Window3();
            userWindow.Show();
        
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (options.SelectedIndex.ToString())
            {
                case "0":
                    // Email
                    break;
                case "1":
                    // Chat
                    break;
                default:
                    MessageBox.Show("Unexpected selection!");
                    return;
            }
        }


    }
}
