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
using TicTacToeByBloodyAlpha.Pages;

namespace TicTacToeByBloodyAlpha
{
    /// <summary>
    /// Логика взаимодействия для PrimaryWindows.xaml
    /// </summary>
    public partial class PrimaryWindows : Window
    {
        public PrimaryWindows()
        {
            InitializeComponent();
            MainMenu mainMenu = new MainMenu();
            PrimaryFrame.Navigate(mainMenu);
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void CurrentWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mouse.LeftButton == MouseButtonState.Pressed) { this.DragMove(); }
        }
    }
}
