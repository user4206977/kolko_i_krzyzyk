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
using System.Windows.Threading;

namespace kółko_i_krzyżyk
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        private int secondsElapsed = 0;
        private bool isTimerRunning = false;


        Random rnd = new Random();
        int player = 0;

        int X_wins = 0;
        int O_wins = 0;
        int NO_wins = 0;

        public MainWindow()
        {
            InitializeComponent();
            StartTimer();
            player = rnd.Next(0, 2);
            CheckWInner();
        }

        private void zasady(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Gra strategiczna rozgrywana przez dwóch graczy, najczęściej na kartce w kratkę. Gracze obejmują pola na przemian dążąc do objęcia trzech pól w jednej linii, przy jednoczesnym uniemożliwieniu tego samego przeciwnikowi. Pole może być objęte przez jednego gracza i nie zmienia swego właściciela przez cały przebieg gry.", "Zasady gry", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void reset(object sender, RoutedEventArgs e)
        {
            P1.IsEnabled = true;
            P2.IsEnabled = true;
            P3.IsEnabled = true;
            P4.IsEnabled = true;
            P5.IsEnabled = true;
            P6.IsEnabled = true;
            P7.IsEnabled = true;
            P8.IsEnabled = true;
            P9.IsEnabled = true;
            P1.Content = "";
            P2.Content = "";
            P3.Content = "";
            P4.Content = "";
            P5.Content = "";
            P6.Content = "";
            P7.Content = "";
            P8.Content = "";
            P9.Content = "";
            player = rnd.Next(0, 2);
            CheckWInner();
        }

        private void PF1(object sender, RoutedEventArgs e)
        {
            P1.IsEnabled = false;
            if(player == 1)
            {
                P1.Content = "X";
                player = 0;
            } else
            {
                P1.Content = "O";
                player = 1;
            }
            CheckWInner();
        }

        private void PF2(object sender, RoutedEventArgs e)
        {
            P2.IsEnabled = false;
            if (player == 1)
            {
                P2.Content = "X";
                player = 0;
            }
            else
            {
                P2.Content = "O";
                player = 1;
            }
            CheckWInner();
        }

        private void PF3(object sender, RoutedEventArgs e)
        {
            P3.IsEnabled = false;
            if (player == 1)
            {
                P3.Content = "X";
                player = 0;
            }
            else
            {
                P3.Content = "O";
                player = 1;
            }
            CheckWInner();
        }

        private void PF4(object sender, RoutedEventArgs e)
        {
            P4.IsEnabled = false;
            if (player == 1)
            {
                P4.Content = "X";
                player = 0;
            }
            else
            {
                P4.Content = "O";
                player = 1;
            }
            CheckWInner();
        }

        private void PF5(object sender, RoutedEventArgs e)
        {
            P5.IsEnabled = false;
            if (player == 1)
            {
                P5.Content = "X";
                player = 0;
            }
            else
            {
                P5.Content = "O";
                player = 1;
            }
            CheckWInner();
        }

        private void PF6(object sender, RoutedEventArgs e)
        {
            P6.IsEnabled = false;
            if (player == 1)
            {
                P6.Content = "X";
                player = 0;
            }
            else
            {
                P6.Content = "O";
                player = 1;
            }
            CheckWInner();
        }

        private void PF7(object sender, RoutedEventArgs e)
        {
            P7.IsEnabled = false;
            if (player == 1)
            {
                P7.Content = "X";
                player = 0;
            }
            else
            {
                P7.Content = "O";
                player = 1;
            }
            CheckWInner();
        }

        private void PF8(object sender, RoutedEventArgs e)
        {
            P8.IsEnabled = false;
            if (player == 1)
            {
                P8.Content = "X";
                player = 0;
            }
            else
            {
                P8.Content = "O";
                player = 1;
            }
            CheckWInner();
        }

        private void PF9(object sender, RoutedEventArgs e)
        {
            P9.IsEnabled = false;
            if (player == 1)
            {
                P9.Content = "X";
                player = 0;
            }
            else
            {
                P9.Content = "O";
                player = 1;
            }
            CheckWInner();
        }

        private void CheckWInner()
        {
            if((P1.Content.ToString() == "X" && P2.Content.ToString() == "X" && P3.Content.ToString() == "X") ||
                (P4.Content.ToString() == "X" && P5.Content.ToString() == "X" && P6.Content.ToString() == "X") ||
                (P7.Content.ToString() == "X" && P8.Content.ToString() == "X" && P9.Content.ToString() == "X") ||
                (P1.Content.ToString() == "X" && P4.Content.ToString() == "X" && P7.Content.ToString() == "X") ||
                (P2.Content.ToString() == "X" && P5.Content.ToString() == "X" && P8.Content.ToString() == "X") ||
                (P3.Content.ToString() == "X" && P6.Content.ToString() == "X" && P9.Content.ToString() == "X") ||
                (P1.Content.ToString() == "X" && P5.Content.ToString() == "X" && P9.Content.ToString() == "X") ||
                (P3.Content.ToString() == "X" && P5.Content.ToString() == "X" && P7.Content.ToString() == "X"))
            {
                MessageBox.Show("Wygrał X!", "Wygrany", MessageBoxButton.OK, MessageBoxImage.Information);
                X_wins++;
                reset(null, null);
            }

            if ((P1.Content.ToString() == "O" && P2.Content.ToString() == "O" && P3.Content.ToString() == "O") ||
                (P4.Content.ToString() == "O" && P5.Content.ToString() == "O" && P6.Content.ToString() == "O") ||
                (P7.Content.ToString() == "O" && P8.Content.ToString() == "O" && P9.Content.ToString() == "O") ||
                (P1.Content.ToString() == "O" && P4.Content.ToString() == "O" && P7.Content.ToString() == "O") ||
                (P2.Content.ToString() == "O" && P5.Content.ToString() == "O" && P8.Content.ToString() == "O") ||
                (P3.Content.ToString() == "O" && P6.Content.ToString() == "O" && P9.Content.ToString() == "O") ||
                (P1.Content.ToString() == "O" && P5.Content.ToString() == "O" && P9.Content.ToString() == "O") ||
                (P3.Content.ToString() == "O" && P5.Content.ToString() == "O" && P7.Content.ToString() == "O"))
            {
                MessageBox.Show("Wygrał O!", "Wygrany", MessageBoxButton.OK, MessageBoxImage.Information);
                O_wins++;
                reset(null, null);
            }

            if (P1.IsEnabled == false && P2.IsEnabled == false && P3.IsEnabled == false &&
                P4.IsEnabled == false && P5.IsEnabled == false && P6.IsEnabled == false &&
                P7.IsEnabled == false && P8.IsEnabled == false && P9.IsEnabled == false)
            {
                MessageBox.Show("Nikt nie wygrywa, remis!", "Wygrany", MessageBoxButton.OK, MessageBoxImage.Information);
                NO_wins++;
                reset(null, null);
            }

            Xwins.Content = "Ilość wygranych X: " + X_wins;
            Owins.Content = "Ilość wygranych O: " + O_wins;
            NOwins.Content = "Ilość remisów: " + NO_wins;

            if(player == 1)
            {
                kolej.Content = "Teraz kolej: X";
            } else
            {
                kolej.Content = "Teraz kolej: O";
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            secondsElapsed++;
            time.Content = $"Czas gry: {secondsElapsed} s";
        }

        private void ResetTimer()
        {
            if (timer != null)
            {
                timer.Stop();
                timer = null;
                isTimerRunning = false;
            }
            secondsElapsed = 0;
            time.Content = "Czas gry: 0 s";
        }

        private void StartTimer()
        {
            if (isTimerRunning) return;

            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
            isTimerRunning = true;
        }


    }
}
