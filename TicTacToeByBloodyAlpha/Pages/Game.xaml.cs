using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
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
using TicTacToeByBloodyAlpha.Class;

namespace TicTacToeByBloodyAlpha.Pages
{
    /// <summary>
    /// Логика взаимодействия для Game.xaml
    /// </summary>
    public partial class Game : Page
    {
        Player player1 = new Player { Name = "0" }; //0
        Player player2 = new Player { Name = "X" }; //X

        private bool Step = false; // (0 - false) (X - true)
        private int StepNum = 0;
        private int AiStep;
        private bool AiStepRand = true;
        private int AiDifucy = 3;

        private bool CurrentField1;
        private bool CurrentField2;
        private bool CurrentField3;
        private bool CurrentField4;
        private bool CurrentField5;
        private bool CurrentField6;
        private bool CurrentField7;
        private bool CurrentField8;
        private bool CurrentField9;

        private bool StopGame;

        Random rnd = new Random();


        private bool Mode;

        private Brush SCB1;
        private Brush SCB2;
        private Brush SCB3;
        private Brush SCB4;
//        private Brush SCB5;
        public Game(int difucyCount, int playersCount)
        {

            InitializeComponent();
            SCB1 = Btn_GoToMainMenu_Border.Background;
            SCB2 = Btn_Restart_Border.Background;
            SCB3 = Btn_GoToMainMenu_Border.Background;
            SCB4 = Label_BloodyAlphaStudio.Foreground;
            //            SCB5 = Btn_Info_Border.Background;

            if (playersCount == 1)
            {
                Mode = true;
                switch (difucyCount) { case 1: AiDifucy = 1; break; case 2: AiDifucy = 2; break; case 3: AiDifucy = 3; break;
                
                }

                if (AiDifucy == 3) { Btn_AiDif_Label.Content = "H"; }
                if (AiDifucy == 2) { Btn_AiDif_Label.Content = "N"; }
                if (AiDifucy == 1) { Btn_AiDif_Label.Content = "E"; }
                Btn_AiDifucy_Border.Visibility = Visibility.Visible;

            }

            if (playersCount == 2)
            {
                Mode = false;
            }
        }

        private void Btn_MouseEnter(object sender, MouseEventArgs e)
        {
            Btn_GoToMainMenu_Border.Background = Brushes.Coral;
        }

        private void Btn_exit_Border_MouseLeave(object sender, MouseEventArgs e)
        {
            Btn_GoToMainMenu_Border.Background = SCB3;
            Btn_Restart_Border.Background = SCB2;
            Label_BloodyAlphaStudio.Foreground = SCB4;
            Btn_Mode_Border.Background = SCB2;
            Btn_AiDifucy_Border.Background = SCB2;
        }



        public void CheckComputerStep()
        {
            if (AiDifucy >= 2)
            {
                if (player2.Field1 == true & player2.Field2 == true & CurrentField3 == false) { AiStep = 3; AiStepRand = false; }
                if (player2.Field4 == true & player2.Field5 == true & CurrentField6 == false) { AiStep = 6; AiStepRand = false; }
                if (player2.Field7 == true & player2.Field8 == true & CurrentField9 == false) { AiStep = 9; AiStepRand = false; }
                if (player2.Field2 == true & player2.Field3 == true & CurrentField1 == false) { AiStep = 1; AiStepRand = false; }
                if (player2.Field5 == true & player2.Field6 == true & CurrentField4 == false) { AiStep = 4; AiStepRand = false; }
                if (player2.Field8 == true & player2.Field9 == true & CurrentField7 == false) { AiStep = 7; AiStepRand = false; } //Block 1
                if (player2.Field1 == true & player2.Field4 == true & CurrentField7 == false) { AiStep = 7; AiStepRand = false; }
                if (player2.Field2 == true & player2.Field5 == true & CurrentField8 == false) { AiStep = 8; AiStepRand = false; }
                if (player2.Field3 == true & player2.Field6 == true & CurrentField9 == false) { AiStep = 9; AiStepRand = false; }
                if (player2.Field7 == true & player2.Field4 == true & CurrentField1 == false) { AiStep = 1; AiStepRand = false; }
                if (player2.Field8 == true & player2.Field5 == true & CurrentField2 == false) { AiStep = 2; AiStepRand = false; }
                if (player2.Field9 == true & player2.Field6 == true & CurrentField3 == false) { AiStep = 3; AiStepRand = false; } // Block 2
                if (player2.Field1 == true & player2.Field5 == true & CurrentField9 == false) { AiStep = 9; AiStepRand = false; }
                if (player2.Field3 == true & player2.Field5 == true & CurrentField7 == false) { AiStep = 7; AiStepRand = false; }
                if (player2.Field7 == true & player2.Field5 == true & CurrentField3 == false) { AiStep = 3; AiStepRand = false; }
                if (player2.Field9 == true & player2.Field5 == true & CurrentField1 == false) { AiStep = 1; AiStepRand = false; }
                if (player2.Field1 == true & player2.Field9 == true & CurrentField5 == false) { AiStep = 5; AiStepRand = false; }
                if (player2.Field7 == true & player2.Field3 == true & CurrentField5 == false) { AiStep = 5; AiStepRand = false; }// Block 3
                if (player2.Field1 == true & player2.Field3 == true & CurrentField2 == false) { AiStep = 2; AiStepRand = false; }
                if (player2.Field4 == true & player2.Field6 == true & CurrentField5 == false) { AiStep = 5; AiStepRand = false; }
                if (player2.Field7 == true & player2.Field9 == true & CurrentField8 == false) { AiStep = 8; AiStepRand = false; }
                if (player2.Field1 == true & player2.Field7 == true & CurrentField4 == false) { AiStep = 4; AiStepRand = false; }
                if (player2.Field2 == true & player2.Field8 == true & CurrentField5 == false) { AiStep = 5; AiStepRand = false; }
                if (player2.Field3 == true & player2.Field9 == true & CurrentField6 == false) { AiStep = 6; AiStepRand = false; }// Block 4
                if (player1.Field1 == true & player1.Field2 == true & CurrentField3 == false) { AiStep = 3; AiStepRand = false; }
                if (player1.Field4 == true & player1.Field5 == true & CurrentField6 == false) { AiStep = 6; AiStepRand = false; }
                if (player1.Field7 == true & player1.Field8 == true & CurrentField9 == false) { AiStep = 9; AiStepRand = false; }
                if (player1.Field2 == true & player1.Field3 == true & CurrentField1 == false) { AiStep = 1; AiStepRand = false; }
                if (player1.Field5 == true & player1.Field6 == true & CurrentField4 == false) { AiStep = 4; AiStepRand = false; }
                if (player1.Field8 == true & player1.Field9 == true & CurrentField7 == false) { AiStep = 7; AiStepRand = false; } //Block 5
                if (player1.Field1 == true & player1.Field4 == true & CurrentField7 == false) { AiStep = 7; AiStepRand = false; }
                if (player1.Field2 == true & player1.Field5 == true & CurrentField8 == false) { AiStep = 8; AiStepRand = false; }
                if (player1.Field3 == true & player1.Field6 == true & CurrentField9 == false) { AiStep = 9; AiStepRand = false; }
                if (player1.Field7 == true & player1.Field4 == true & CurrentField1 == false) { AiStep = 1; AiStepRand = false; }
                if (player1.Field8 == true & player1.Field5 == true & CurrentField2 == false) { AiStep = 2; AiStepRand = false; }
                if (player1.Field9 == true & player1.Field6 == true & CurrentField3 == false) { AiStep = 3; AiStepRand = false; } //Block 6
                if (player1.Field1 == true & player1.Field5 == true & CurrentField9 == false) { AiStep = 9; AiStepRand = false; }
                if (player1.Field3 == true & player1.Field5 == true & CurrentField7 == false) { AiStep = 7; AiStepRand = false; }
                if (player1.Field7 == true & player1.Field5 == true & CurrentField3 == false) { AiStep = 3; AiStepRand = false; }
                if (player1.Field9 == true & player1.Field5 == true & CurrentField1 == false) { AiStep = 1; AiStepRand = false; }
                if (player1.Field1 == true & player1.Field9 == true & CurrentField5 == false) { AiStep = 5; AiStepRand = false; }
                if (player1.Field7 == true & player1.Field3 == true & CurrentField5 == false) { AiStep = 5; AiStepRand = false; } //Block 7
                if (player1.Field1 == true & player1.Field3 == true & CurrentField2 == false) { AiStep = 2; AiStepRand = false; }
                if (player1.Field4 == true & player1.Field6 == true & CurrentField5 == false) { AiStep = 5; AiStepRand = false; }
                if (player1.Field7 == true & player1.Field9 == true & CurrentField8 == false) { AiStep = 8; AiStepRand = false; }
                if (player1.Field1 == true & player1.Field7 == true & CurrentField4 == false) { AiStep = 4; AiStepRand = false; }
                if (player1.Field2 == true & player1.Field8 == true & CurrentField5 == false) { AiStep = 5; AiStepRand = false; }
                if (player1.Field3 == true & player1.Field9 == true & CurrentField6 == false) { AiStep = 6; AiStepRand = false; } //Block8 

                if (AiDifucy == 3)
                {
                    if (StepNum < 2 & (player1.Field1 == true || player1.Field3 == true || player1.Field7 == true || player1.Field9 == true)) { AiStep = 5; AiStepRand = false; }
                    if (StepNum < 2 & (player1.Field5 == true)) { int Edge; Edge = rnd.Next(1, 5); if (Edge == 1) { AiStep = 1; AiStepRand = false; } if (Edge == 2) { AiStep = 3; AiStepRand = false; } if (Edge == 3) { AiStep = 7; AiStepRand = false; } if (Edge == 4) { AiStep = 9; AiStepRand = false; } }
                }

            }
        }



        public void PlayerComputer()
        {
            if (Step == true)
            {

                

                if (StopGame == false && StepNum != 9)
                {
                    if (AiDifucy >= 2) { CheckComputerStep(); }


                    if (AiStepRand == true)
                    {
                        AiStep = rnd.Next(1, 9);
                    }

                    if (AiStep == 1)
                    {
                        if (CurrentField1 == false)
                        {
                            StepNum++;
                            CurrentField1 = true;
                            player2.Field1 = true;
                            Btn_Field_1.Content = "X"; Step = false; CurrentField1 = true; player2.Field1 = true; CheckDrawGame(); CheckWin(player2);
                            AiStepRand = true;
                            Step = false;
                        }
                        else { PlayerComputer(); }
                    }

                    if (AiStep == 2)
                    {
                        if (CurrentField2 == false)
                        {
                            StepNum++;
                            CurrentField2 = true;
                            player2.Field2 = true;
                            Btn_Field_2.Content = "X"; Step = false; CurrentField2 = true; player2.Field2 = true; CheckDrawGame(); CheckWin(player2);
                            AiStepRand = true;
                            Step = false;
                        }
                        else { PlayerComputer(); }
                    }

                    if (AiStep == 3)
                    {
                        if (CurrentField3 == false)
                        {
                            StepNum++;
                            CurrentField3 = true;
                            player2.Field3 = true;
                            Btn_Field_3.Content = "X"; Step = false; CurrentField3 = true; player2.Field3 = true; CheckDrawGame(); CheckWin(player2);
                            AiStepRand = true;
                            Step = false;
                        }
                        else { PlayerComputer(); }
                    }

                    if (AiStep == 4)
                    {
                        if (CurrentField4 == false)
                        {
                            StepNum++;
                            CurrentField4 = true;
                            player2.Field4 = true;
                            Btn_Field_4.Content = "X"; Step = false; CurrentField4 = true; player2.Field4 = true; CheckDrawGame(); CheckWin(player2);
                            AiStepRand = true;
                            Step = false;
                        }
                        else { PlayerComputer(); }
                    }

                    if (AiStep == 5)
                    {
                        if (CurrentField5 == false)
                        {
                            StepNum++;
                            CurrentField5 = true;
                            player2.Field5 = true;
                            Btn_Field_5.Content = "X"; Step = false; CurrentField5 = true; player2.Field5 = true; CheckDrawGame(); CheckWin(player2);
                            AiStepRand = true;
                            Step = false;
                        }
                        else { PlayerComputer(); }
                    }

                    if (AiStep == 6)
                    {
                        if (CurrentField6 == false)
                        {
                            StepNum++;
                            CurrentField6 = true;
                            player2.Field6 = true;
                            Btn_Field_6.Content = "X"; Step = false; CurrentField6 = true; player2.Field6 = true; CheckDrawGame(); CheckWin(player2);
                            AiStepRand = true;
                            Step = false;
                        }
                        else { PlayerComputer(); }
                    }

                    if (AiStep == 7)
                    {
                        if (CurrentField7 == false)
                        {
                            StepNum++;
                            CurrentField7 = true;
                            player2.Field7 = true;
                            Btn_Field_7.Content = "X"; Step = false; CurrentField7 = true; player2.Field7 = true; CheckDrawGame(); CheckWin(player2);
                            AiStepRand = true;
                            Step = false;
                        }
                        else { PlayerComputer(); }
                    }

                    if (AiStep == 8)
                    {
                        if (CurrentField8 == false)
                        {
                            StepNum++;
                            CurrentField8 = true;
                            player2.Field8 = true;
                            Btn_Field_8.Content = "X"; Step = false; CurrentField8 = true; player2.Field8 = true; CheckDrawGame(); CheckWin(player2);
                            AiStepRand = true;
                            Step = false;
                        }
                        else { PlayerComputer(); }
                    }

                    if (AiStep == 9)
                    {
                        if (CurrentField9 == false)
                        {
                            StepNum++;
                            CurrentField9 = true;
                            player2.Field9 = true;
                            Btn_Field_9.Content = "X"; Step = false; CurrentField9 = true; player2.Field9 = true; CheckDrawGame(); CheckWin(player2);
                            AiStepRand = true;
                            Step = false;
                        }
                        else { PlayerComputer(); }
                    }
                    CheckWin(player2);
                }
            }

        }

        #region ButtonField
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
            else
            {
                if (CurrentField1 == false && StepNum != 9)
                {
                    StepNum++;
                    Btn_Field_1.Content = "0";
                    Step = true;
                    CurrentField1 = true;

                    player1.Field1 = true;
                    CheckDrawGame();
                    CheckWin(player1);
                    PlayerComputer();
                };
            }

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
            else
            {
                if (CurrentField2 == false && StepNum != 9)
                {
                    StepNum++;
                    Btn_Field_2.Content = "0";
                    Step = true;
                    CurrentField2 = true;
                    player1.Field2 = true;
                    CheckDrawGame();
                    CheckWin(player1);
                    PlayerComputer();
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
            else
            {
                if (CurrentField3 == false && StepNum != 9)
                {
                    StepNum++;
                    Btn_Field_3.Content = "0";
                    Step = true;
                    CurrentField3 = true;
                    player1.Field3 = true;
                    CheckDrawGame();
                    CheckWin(player1);
                    PlayerComputer();
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
            else
            {
                if (CurrentField4 == false && StepNum != 9)
                {
                    StepNum++;
                    Btn_Field_4.Content = "0";
                    Step = true;
                    CurrentField4 = true;
                    player1.Field4 = true;
                    CheckDrawGame();
                    CheckWin(player1); PlayerComputer();
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
            else
            {
                if (CurrentField5 == false && StepNum != 9)
                {
                    StepNum++;
                    Btn_Field_5.Content = "0";
                    Step = true;
                    CurrentField5 = true;
                    player1.Field5 = true;
                    CheckDrawGame();
                    CheckWin(player1); PlayerComputer();
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
            else
            {
                if (CurrentField6 == false && StepNum != 9)
                {
                    StepNum++;
                    Btn_Field_6.Content = "0";
                    Step = true;
                    CurrentField6 = true;
                    player1.Field6 = true;
                    CheckDrawGame();
                    CheckWin(player1); PlayerComputer();
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
            else
            {
                if (CurrentField7 == false && StepNum != 9)
                {
                    StepNum++;
                    Btn_Field_7.Content = "0";
                    Step = true;
                    CurrentField7 = true;
                    player1.Field7 = true;
                    CheckDrawGame();
                    CheckWin(player1); PlayerComputer();
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
            else
            {
                if (CurrentField8 == false && StepNum != 9)
                {
                    StepNum++;
                    Btn_Field_8.Content = "0";
                    Step = true;
                    CurrentField8 = true;
                    player1.Field8 = true;
                    CheckDrawGame();
                    CheckWin(player1); PlayerComputer();
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
            else
            {
                if (CurrentField9 == false && StepNum != 9)
                {
                    StepNum++;
                    Btn_Field_9.Content = "0";
                    Step = true;
                    CurrentField9 = true;
                    player1.Field9 = true;
                    CheckDrawGame();
                    CheckWin(player1); PlayerComputer();
                }
            }
        }

        #endregion 

        private void CheckDrawGame()
        {


            if (StepNum == 9)
            {
                Label_Winer.Content = "Ничья";
                Label_Winer.Visibility = Visibility.Visible;
                StopGame = true;
                //RestartGame()
            }
        }

        private void RestartGame()
        {
            StopGame = false;
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
            if (player.Field1 & player.Field2 & player.Field3) { Winer(player); Rectangle_Horizontal_Up.Visibility = Visibility.Visible; StopGame = true; }

            if (player.Field4 & player.Field5 & player.Field6) { Winer(player); Rectangle_Horizontal_Center.Visibility = Visibility.Visible; StopGame = true; }

            if (player.Field7 & player.Field8 & player.Field9) { Winer(player); Rectangle_Horizontal_Down.Visibility = Visibility.Visible; StopGame = true; }

            if (player.Field1 & player.Field4 & player.Field7) { Winer(player); Rectangle_Vertical_Left.Visibility = Visibility.Visible; StopGame = true; }

            if (player.Field2 & player.Field5 & player.Field8) { Winer(player); Rectangle_Vertical_Center.Visibility = Visibility.Visible; StopGame = true; }

            if (player.Field3 & player.Field6 & player.Field9) { Winer(player); Rectangle_Vertical_Right.Visibility = Visibility.Visible; StopGame = true; }

            if (player.Field1 & player.Field5 & player.Field9) { Winer(player); Rectangle_Diag_LeftUp_RightDown.Visibility = Visibility.Visible; StopGame = true; }

            if (player.Field3 & player.Field5 & player.Field7) { Winer(player); Rectangle_Diag_LeftDown_RightUp.Visibility = Visibility.Visible; StopGame = true; }
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
                Btn_AiDifucy_Border.Visibility = Visibility.Visible;
                RestartGame();
            }
            else
            {
                Btn_Mode_Label.Content = "T";
                Mode = false;
                Btn_AiDifucy_Border.Visibility = Visibility.Hidden;
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

        private void Btn_AiDifucy_Border_MouseEnter(object sender, MouseEventArgs e)
        {
            Btn_AiDifucy_Border.Background = Brushes.Coral;
        }

        private void Btn_AiDifucy_Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AiDifucy++;
            if (AiDifucy > 3) { AiDifucy = 1; }

            if (AiDifucy == 3) { Btn_AiDif_Label.Content = "H"; }
            if (AiDifucy == 2) { Btn_AiDif_Label.Content = "N"; }
            if (AiDifucy == 1) { Btn_AiDif_Label.Content = "L"; }

            RestartGame();
        }

        private void Btn_Info_Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();

        }

        private void Btn_GoToMainMenu_Border_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Btn_GoToMainMenu_Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            NavigationService.Navigate(mainMenu);
        }
    }
}
