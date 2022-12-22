﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for GameAI.xaml
    /// </summary>
    public partial class GameAI : Window
    {
        Random rnd = new();

        private static readonly int rows = 10;
        private static readonly int columns = 10;
        private bool shipShadow = false;
        private int calculatedCell = -1;
        char[,] playerPlayfield = new char[10, 10];
        char[,] aiPlayfield = new char[10, 10];
        private string player1Name;
        private int playerHits;
        private int changePlayerCounter = 0;

        public GameAI(Grid playfield, char[,] playerPlayfield, string player1Name)
        {
            InitializeComponent();

            this.playerPlayfield = playerPlayfield;
            this.player1Name = player1Name;
            tableLabel.Content = player1Name + "'s table";
            playerShipsLoad(playfield);
        }

        private void playerShipsLoad(Grid playfield)
        {
            for (int unit = playfield.Children.Count - 1; unit >= 0; unit--)
            {
                var child = playfield.Children[unit];
                playfield.Children.RemoveAt(unit);
                leftTable.Children.Add(child);
            }
        }
        private void deleteShipShadow(int shipLength)
        {
            if (shipShadow == true)
            {
                for (int i = 0; i < shipLength; i++)
                {
                    int lastItem = rightTable.Children.Count - 1;
                    rightTable.Children.RemoveAt(lastItem);
                }
            }
        }

        private int calculateCell() //which cell the cursor is on
        {
            var point = Mouse.GetPosition(rightTable);

            int row = 0;
            int col = 0;
            double accumulatedHeight = 0.0;
            double accumulatedWidth = 0.0;

            foreach (var rowDefinition in rightTable.RowDefinitions)
            {
                accumulatedHeight += rowDefinition.ActualHeight;
                if (accumulatedHeight >= point.Y)
                    break;
                row++;
            }

            foreach (var columnDefinition in rightTable.ColumnDefinitions)
            {
                accumulatedWidth += columnDefinition.ActualWidth;
                if (accumulatedWidth >= point.X)
                    break;
                col++;
            }

            return (row * 10) + col;
        }

        private void onGridMouseClick(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 1)
            {
                int shipLength = 1;
                deleteShipShadow(shipLength);
                shipShadow = false;

                int cell = calculateCell();

                Debug.WriteLine($"{cell % columns}, {cell / rows}");

                for (int i = 0; i < shipLength; i++)
                {
                    if (char.IsDigit(aiPlayfield[cell % columns, cell / rows]))
                    {
                        var ship = shipSettings(shipLength);
                        ship.Fill = Brushes.DarkRed;
                        Grid.SetRow(ship, cell / rows);
                        Grid.SetColumn(ship, cell % columns);

                        Debug.WriteLine(aiPlayfield[cell % columns, cell / rows]);

                        char c = aiPlayfield[cell % columns, cell / rows];

                        aiPlayfield[cell % columns, cell / rows] = 'T';

                        Debug.WriteLine(int.Parse(c.ToString()));

                        shipHp(int.Parse(c.ToString()));

                        ship.Visibility = Visibility.Visible;
                        rightTable.Children.Add(ship);

                        playerHits++;
                        playerHitsLabel.Content = playerHits;

                        if (isEndGame(0)) // player
                        {
                            onScore(player1Name);
                            MessageBox.Show("The Player won!", "Winner", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                            MainWindow startWindow = new MainWindow();
                            this.Close();
                            startWindow.Show();
                        }
                    }
                    else if (!(aiPlayfield[cell % columns, cell / rows] == 'T' || aiPlayfield[cell % columns, cell / rows] == 'V'))
                    {
                        var ship = shipSettings(shipLength);
                        ship.Fill = Brushes.Gray;
                        Grid.SetRow(ship, cell / rows);
                        Grid.SetColumn(ship, cell % columns);

                        aiPlayfield[cell % columns, cell / rows] = 'V';

                        ship.Visibility = Visibility.Visible;
                        rightTable.Children.Add(ship);

                        roundsLabelIncrement();

                        //Kell az ai lépése
                        if (isEndGame(1))
                        {
                            onScore("AI");
                            MessageBox.Show("The AI won!", "Loser", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                            MainWindow startWindow = new MainWindow();
                            this.Close();
                            startWindow.Show();
                        }
                    }
                }
            }
        }

        private void onGridMouseOver(object sender, MouseEventArgs e)
        {
            int shipLength = 1;

            if (shipLength != 0)
            {
                int cell = calculateCell();

                if (calculatedCell != cell)
                {
                    calculatedCell = cell;

                    deleteShipShadow(shipLength);

                    for (int i = 0; i < shipLength; i++)
                    {
                        var ship = new Rectangle();
                        ship.Fill = Brushes.LightGray;
                        var Y = rightTable.Width / rows;
                        var X = rightTable.Height / columns;
                        ship.Width = Y;
                        ship.Height = X;

                        Grid.SetRow(ship, cell / rows + i);
                        Grid.SetColumn(ship, cell % columns);

                        shipShadow = true;
                        rightTable.Children.Add(ship);
                    }
                }
            }
        }

        public bool isEndGame(int player)
        {
            if (player == 0)
            {
                for (int row = 0; row < 10; row++)
                {
                    for (int col = 0; col < 10; col++)
                    {
                        if (char.IsDigit(aiPlayfield[row, col]))
                        {
                            return false;
                        }
                    }
                }
            }
            else if (player == 1)
            {
                for (int row = 0; row < 10; row++)
                {
                    for (int col = 0; col < 10; col++)
                    {
                        if (char.IsDigit(playerPlayfield[row, col]))
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        private void onScore(string winner)
        {
            List<Score> scores = ScoreResult.ReadResult("score.json");
            if (scores == null)
            {
                scores = new List<Score>();
            }
            Score newScore = new()
            {
                Enemy = "AI",
                EnemyHits = Convert.ToInt32(computerHitsLabel.Content),
                Player = player1Name,
                PlayerHits = Convert.ToInt32(playerHitsLabel.Content),
                Rounds = Convert.ToInt32(roundsLabel.Content),
                Winner = winner
            };

            scores.Add(newScore);
            ScoreResult.WriteResult(scores, "score.json");
        }

        private void roundsLabelIncrement()
        {
            changePlayerCounter++;
            if (changePlayerCounter % 2 == 0)
            {
                roundsLabel.Content = Convert.ToInt32(roundsLabel.Content) + 1;
            }
        }

        private Rectangle shipSettings(int shipLength)
        {
            Rectangle ship = new()
            {
                Fill = Brushes.DodgerBlue
            };
            var Y = rightTable.Width / rows;
            var X = rightTable.Height / columns;
            ship.Width = Y;
            ship.Height = X;

            shipSetName(ship, shipLength);

            ship.Visibility = Visibility.Hidden;

            return ship;
        }

        private void shipSetName(Rectangle ship, int shipLength)
        {
            switch (shipLength)
            {
                case 5:
                    ship.Name = "Carrier";
                    break;
                case 4:
                    ship.Name = "Battleship";
                    break;
                case 3:
                    ship.Name = "Cruiser";
                    break;
                case 2:
                    ship.Name = "Submarine";
                    break;
                case 1:
                    ship.Name = "Destroyer";
                    break;
            }
        }

        private void shipHp(int s)
        {
            Debug.WriteLine(s);

            if (s == 1)
            {
                destroyerHpGrid.Children.RemoveAt(destroyerHpGrid.Children.Count - 1);
            }
            else if (s == 2)
            {
                submarineHpGrid.Children.RemoveAt(submarineHpGrid.Children.Count - 1);
            }
            else if (s == 3)
            {
                cruiserHpGrid.Children.RemoveAt(cruiserHpGrid.Children.Count - 1);
            }
            else if (s == 4)
            {
                battleshipHpGrid.Children.RemoveAt(battleshipHpGrid.Children.Count - 1);
            }
            else if (s == 5)
            {
                carrierHpGrid.Children.RemoveAt(carrierHpGrid.Children.Count - 1);
            }
        }

        private void stats_Click(object sender, RoutedEventArgs e)
        {
        }

        private void surrendBtn_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
