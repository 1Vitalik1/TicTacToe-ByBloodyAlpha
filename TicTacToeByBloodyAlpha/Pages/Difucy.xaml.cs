﻿using System;
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
    /// Логика взаимодействия для Difucy.xaml
    /// </summary>
    public partial class Difucy : Page
    {
        public Difucy()
        {
            InitializeComponent();
        }

        private void Btn_Hard_Click(object sender, RoutedEventArgs e)
        {
            Game game = new Game(3,1);
            NavigationService.Navigate(game);
        }

        private void Btn_Normal_Click(object sender, RoutedEventArgs e)
        {
            Game game = new Game(2, 1);
            NavigationService.Navigate(game);
        }

        private void Btn_Easy_Click(object sender, RoutedEventArgs e)
        {
            Game game = new Game(1, 1);
            NavigationService.Navigate(game);
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();

        }
    }
}
