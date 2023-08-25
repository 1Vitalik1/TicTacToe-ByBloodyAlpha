using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
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
using TicTacToeByBloodyAlpha.Class;

namespace TicTacToeByBloodyAlpha
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Player player1 = new Player { Name = "0"  }; //0
        Player player2 = new Player { Name = "X"  }; //X

        private bool Step = false; // (0 - false) (X - true)
        private int StepNum = 0;

        private bool CurrentField1;
        private bool CurrentField2;
        private bool CurrentField3;
        private bool CurrentField4;
        private bool CurrentField5;
        private bool CurrentField6;
        private bool CurrentField7;
        private bool CurrentField8;
        private bool CurrentField9;

        private bool Mode;

        private Brush SCB;
        public MainWindow()
        {
            InitializeComponent();
            SCB = Btn_exit_Border.Background;
        }

        private void Btn_MouseEnter(object sender, MouseEventArgs e)
        {
            Btn_exit_Border.Background = Brushes.Coral;
        }

        private void Btn_exit_Border_MouseLeave(object sender, MouseEventArgs e)
        {
            Btn_Restart_Border.Background = SCB;
            Btn_exit_Border.Background = SCB;
            Label_BloodyAlphaStudio.Foreground = SCB;
            Btn_Mode_Border.Background = SCB;
        }

        private void Btn_exit_Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void CurrentWindow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(Mouse.LeftButton == MouseButtonState.Pressed) { this.DragMove(); }
        }

 
        private void Btn_Field_1_Click(object sender, RoutedEventArgs e)
        {
            if (Mode == false)
            {

                if (CurrentField1 == false)
                {
                    StepNum++;

                    if (Step == false)
                    {
                        Btn_Field_1.Content = "0";
                        Step = true;
                        CurrentField1 = true;

                        player1.Field1 = true;
                        CheckDrawGame();
                        CheckWin(player1);
                    }
                    else { Btn_Field_1.Content = "X"; Step = false; CurrentField1 = true; player2.Field1 = true; CheckDrawGame(); CheckWin(player2); }

                }

            } //Two Players Mode

        }

        private void Btn_Field_2_Click(object sender, RoutedEventArgs e)
        {
            if (Mode == false)
            {
                if (CurrentField2 == false)
                {
                    StepNum++;

                    if (Step == false)
                    {
                        Btn_Field_2.Content = "0";
                        Step = true;
                        CurrentField2 = true;
                        player1.Field2 = true;
                        CheckDrawGame();
                        CheckWin(player1);
                    }
                    else { Btn_Field_2.Content = "X"; Step = false; CurrentField2 = true; player2.Field2 = true; CheckDrawGame(); CheckWin(player2); }

                }
            }
        }

        private void Btn_Field_3_Click(object sender, RoutedEventArgs e)
        {
            if (Mode == false)
            {

                if (CurrentField3 == false)
                {
                    StepNum++;

                    if (Step == false)
                    {
                        Btn_Field_3.Content = "0";
                        Step = true;
                        CurrentField3 = true;
                        player1.Field3 = true;
                        CheckDrawGame();
                        CheckWin(player1);
                    }
                    else { Btn_Field_3.Content = "X"; Step = false; CurrentField3 = true; player2.Field3 = true; CheckDrawGame(); CheckWin(player2); }

                }
            }
        }

        private void Btn_Field_4_Click(object sender, RoutedEventArgs e)
        {
            if (Mode == false)
            {
                if (CurrentField4 == false)
                {
                    StepNum++;

                    if (Step == false)
                    {
                        Btn_Field_4.Content = "0";
                        Step = true;
                        CurrentField4 = true;
                        player1.Field4 = true;
                        CheckDrawGame();
                        CheckWin(player1);
                    }
                    else { Btn_Field_4.Content = "X"; Step = false; CurrentField4 = true; player2.Field4 = true; CheckDrawGame(); CheckWin(player2); }

                }
            }
        }

        private void Btn_Field_5_Click(object sender, RoutedEventArgs e)
        {
            if (Mode == false)
            {
                if (CurrentField5 == false)
                {
                    StepNum++;

                    if (Step == false)
                    {
                        Btn_Field_5.Content = "0";
                        Step = true;
                        CurrentField5 = true;
                        player1.Field5 = true;
                        CheckDrawGame();
                        CheckWin(player1);
                    }
                    else { Btn_Field_5.Content = "X"; Step = false; CurrentField5 = true; player2.Field5 = true; CheckDrawGame(); CheckWin(player2); }

                }
            }

        }

        private void Btn_Field_6_Click(object sender, RoutedEventArgs e)
        {
            if (Mode == false)
            {

                if (CurrentField6 == false)
                {
                    StepNum++;

                    if (Step == false)
                    {
                        Btn_Field_6.Content = "0";
                        Step = true;
                        CurrentField6 = true;
                        player1.Field6 = true;
                        CheckDrawGame();
                        CheckWin(player1);
                    }
                    else { Btn_Field_6.Content = "X"; Step = false; CurrentField6 = true; player2.Field6 = true; CheckDrawGame(); CheckWin(player2); }

                }
            }

        }


        private void Btn_Field_7_Click(object sender, RoutedEventArgs e)
        {
            if (Mode == false)
            {

                if (CurrentField7 == false)
                {
                    StepNum++;

                    if (Step == false)
                    {
                        Btn_Field_7.Content = "0";
                        Step = true;
                        CurrentField7 = true;
                        player1.Field7 = true;
                        CheckDrawGame();
                        CheckWin(player1);
                    }
                    else { Btn_Field_7.Content = "X"; Step = false; CurrentField7 = true; player2.Field7 = true; CheckDrawGame(); CheckWin(player2); }

                }
            }

        }

        private void Btn_Field_8_Click(object sender, RoutedEventArgs e)
        {
            if (Mode == false)
            {

                if (CurrentField8 == false)
                {
                    StepNum++;

                    if (Step == false)
                    {
                        Btn_Field_8.Content = "0";
                        Step = true;
                        CurrentField8 = true;
                        player1.Field8 = true;
                        CheckDrawGame();
                        CheckWin(player1);
                    }
                    else { Btn_Field_8.Content = "X"; Step = false; CurrentField8 = true; player2.Field8 = true; CheckDrawGame(); CheckWin(player2); }

                }
            }

        }

        private void Btn_Field_9_Click(object sender, RoutedEventArgs e)
        {
            if (Mode == false)
            {

                if (CurrentField9 == false)
                {
                    StepNum++;

                    if (Step == false)
                    {
                        Btn_Field_9.Content = "0";
                        Step = true;
                        CurrentField9 = true;
                        player1.Field9 = true;
                        CheckDrawGame();
                        CheckWin(player1);
                    }
                    else { Btn_Field_9.Content = "X"; Step = false; CurrentField9 = true; player2.Field9 = true; CheckDrawGame(); CheckWin(player2); }

                }
            }
        }

        private void CheckDrawGame()
        {


                if (StepNum == 9)
                {
                    Label_Winer.Content = "Ничья";
                    Label_Winer.Visibility = Visibility.Visible;
                    //RestartGame()
                }
        }

        private void RestartGame()
        {
            Step = false;
            StepNum = 0;
            CurrentField1 = false;
            CurrentField2 = false;
            CurrentField3 = false;
            CurrentField4 = false;
            CurrentField5 = false;
            CurrentField6 = false;
            CurrentField7 = false;
            CurrentField8 = false;
            CurrentField9 = false;

            Btn_Field_1.Content = null;
            Btn_Field_2.Content = null;
            Btn_Field_3.Content = null;
            Btn_Field_4.Content = null;
            Btn_Field_5.Content = null;
            Btn_Field_6.Content = null;
            Btn_Field_7.Content = null;
            Btn_Field_8.Content = null;
            Btn_Field_9.Content = null;

            player1.Restart();
            player2.Restart();

            Rectangle_Horizontal_Up.Visibility = Visibility.Hidden;
            Rectangle_Horizontal_Center.Visibility = Visibility.Hidden;
            Rectangle_Horizontal_Down.Visibility = Visibility.Hidden;
            Rectangle_Vertical_Left.Visibility = Visibility.Hidden;
            Rectangle_Vertical_Right.Visibility = Visibility.Hidden;
            Rectangle_Vertical_Center.Visibility = Visibility.Hidden;
            Rectangle_Diag_LeftUp_RightDown.Visibility = Visibility.Hidden;
            Rectangle_Diag_LeftDown_RightUp.Visibility = Visibility.Hidden;

            Label_Winer.Visibility = Visibility.Hidden;

        }

        private void Btn_Restart_Border_MouseEnter(object sender, MouseEventArgs e)
        {
            Btn_Restart_Border.Background = Brushes.Coral;
        }

        private void Btn_Restart_Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            RestartGame();
        }

        public void CheckWin(Player player)
        {
            if (player.Field1 & player.Field2 & player.Field3) { Winer(player); Rectangle_Horizontal_Up.Visibility = Visibility.Visible;}

            if (player.Field4 & player.Field5 & player.Field6) { Winer(player); Rectangle_Horizontal_Center.Visibility = Visibility.Visible; }

            if (player.Field7 & player.Field8 & player.Field9) { Winer(player); Rectangle_Horizontal_Down.Visibility = Visibility.Visible; }

            if (player.Field1 & player.Field4 & player.Field7) { Winer(player); Rectangle_Vertical_Left.Visibility = Visibility.Visible; }

            if (player.Field2 & player.Field5 & player.Field8) { Winer(player); Rectangle_Vertical_Center.Visibility = Visibility.Visible; }

            if (player.Field3 & player.Field6 & player.Field9) { Winer(player); Rectangle_Vertical_Right.Visibility = Visibility.Visible; }

            if (player.Field1 & player.Field5 & player.Field9) { Winer(player); Rectangle_Diag_LeftUp_RightDown.Visibility = Visibility.Visible; }

            if (player.Field3 & player.Field5 & player.Field7) { Winer(player); Rectangle_Diag_LeftDown_RightUp.Visibility = Visibility.Visible; }
        }

        public void Winer(Player player)
        {
            CurrentField1 = true;
            CurrentField2 = true;
            CurrentField3 = true;
            CurrentField4 = true;
            CurrentField5 = true;
            CurrentField6 = true;
            CurrentField7 = true;
            CurrentField8 = true;
            CurrentField9 = true;

            Label_Winer.Content = "Победитель: " + player.Name;
            Label_Winer.Visibility = Visibility.Visible;

        }

        private void Label_BloodyAlphaStudio_MouseEnter(object sender, MouseEventArgs e)
        {
            Label_BloodyAlphaStudio.Foreground = Brushes.Coral;
        }

        private void Label_BloodyAlphaStudio_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Process GoToDiscord = new Process();
            GoToDiscord.StartInfo.FileName = "https://discord.gg/dPxKwbstxY";
            GoToDiscord.Start();
            
        }
        private void Btn_Mode_Border_MouseEnter(object sender, MouseEventArgs e)
        {
            Btn_Mode_Border.Background = Brushes.Coral;



        }

        private void Btn_Mode_Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Mode == false)
            {
                Btn_Mode_Label.Content = "S";
                Mode = true;
                RestartGame();
            }
            else
            {
                Btn_Mode_Label.Content = "T";
                Mode = false;
                RestartGame();
            }
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.NumPad1) { Btn_Field_7_Click(sender, e); }
            if (e.Key == Key.NumPad2) { Btn_Field_8_Click(sender, e); }
            if (e.Key == Key.NumPad3) { Btn_Field_9_Click(sender, e); }
            if (e.Key == Key.NumPad4) { Btn_Field_4_Click(sender, e); }
            if (e.Key == Key.NumPad5) { Btn_Field_5_Click(sender, e); }
            if (e.Key == Key.NumPad6) { Btn_Field_6_Click(sender, e); }
            if (e.Key == Key.NumPad7) { Btn_Field_1_Click(sender, e); }
            if (e.Key == Key.NumPad8) { Btn_Field_2_Click(sender, e); }
            if (e.Key == Key.NumPad9) { Btn_Field_3_Click(sender, e); }
            if (e.Key == Key.NumPad0) { RestartGame(); }
            if (e.Key == Key.R) { RestartGame(); }

        }
    }


        
    
}
