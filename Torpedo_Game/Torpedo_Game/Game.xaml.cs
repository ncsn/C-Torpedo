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
using System.Windows.Shapes;

namespace Torpedo_Game
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        private string player1Name;
        private string player2Name;
        private bool windowPlayer1;
        private bool player1Coming;
        private string playerStart;
        private char[,] myPlayfield = new char[10, 10];

        char[,] playerPlayfield = new char[10, 10];

        Game player2Window;
        Random rnd = new Random();

        public Game(string player1Name, Grid player1PlayfieldGrid, char[,] player1Playfield, string player2Name, Grid player2PlayfieldGrid, char[,] player2Playfield)
        {
            InitializeComponent();
            this.myPlayfield = player1Playfield;

            this.player1Name = player1Name;
            this.player2Name = player2Name;
            windowPlayer1 = true;
            playerStart = whichPlayerStart(player1Name, player2Name);
            tableLabel.Content = playerStart + "'s table";
            player2Window = new Game(player1Name, player2Name, player2PlayfieldGrid, player2Playfield, player1Coming, playerStart);
            player2Window.Title = "Torpedo";
            player2Window.Show();
        }

        public Game(string player1Name, string player2Name, Grid player2PlayfieldGrid, char[,] player2Playfield, bool player1Coming, string playerStart)
        {
            InitializeComponent();
            windowPlayer1 = false;
            this.myPlayfield = player2Playfield;
            this.player1Coming = player1Coming;
            this.player1Name = player1Name;
            this.player2Name = player2Name;
            this.playerStart = playerStart;
            if (player1Name.Equals(playerStart))
            {
                tableLabel.Content = player2Name + "'s table";
            }
            else
            {
                tableLabel.Content = player1Name + "'s table";
            }
        }

        public Game(Grid playfield, char[,] playerPlayfield, string player1Name)
        {
            InitializeComponent();

            this.playerPlayfield = playerPlayfield;
            this.player1Name = player1Name;
            tableLabel.Content = player1Name + "'s table";
        }

        public Game()
        {
        }

        private string whichPlayerStart(string player1Name, string player2Name)
        {
            int randszam = rnd.Next(0, 2);
            if (randszam == 0)
            {
                player1Coming = true;
                return player1Name;
            }
            else
            {
                player1Coming = false;
                return player2Name;
            }
        }

        private void onGridMouseOver(object sender, MouseEventArgs e)
        {
        }

        private void onGridMouseClick(object sender, MouseButtonEventArgs e)
        {
        }

        private void stats_Click(object sender, RoutedEventArgs e)
        {
            ScoresWindow scoreWindow = new ScoresWindow();
            scoreWindow.Show();
        }

        private void surrendBtn_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
