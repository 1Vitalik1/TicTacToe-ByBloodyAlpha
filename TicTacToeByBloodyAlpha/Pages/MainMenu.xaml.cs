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

namespace TicTacToeByBloodyAlpha.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Page
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Btn_StartGame_Click(object sender, RoutedEventArgs e)
        {
            PlayerCountSelector playerCountSelector = new PlayerCountSelector();
            NavigationService.Navigate(playerCountSelector);
        }

        private void Btn_About_Click(object sender, RoutedEventArgs e)
        {
            About about = new About();
            NavigationService.Navigate(about);

        }

        private void Btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
