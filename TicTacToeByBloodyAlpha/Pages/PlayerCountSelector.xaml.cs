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
    /// Логика взаимодействия для PlayerCountSelector.xaml
    /// </summary>
    public partial class PlayerCountSelector : Page
    {
        public PlayerCountSelector()
        {
            InitializeComponent();
        }

        private void Btn_SoloGame_Click(object sender, RoutedEventArgs e)
        {
            Difucy difucy = new Difucy();
            NavigationService.Navigate(difucy);
        }

        private void Btn_DuoGame_Click(object sender, RoutedEventArgs e)
        {
            Game game = new Game(3,2);
            NavigationService.Navigate(game);
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
