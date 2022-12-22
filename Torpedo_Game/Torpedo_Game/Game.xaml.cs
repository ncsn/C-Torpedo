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
        private char[,] enemyPlayfield = new char[10, 10];
        private int changePlayerCounter = 0;

        private bool shadowExists = false;
        private int calculatedCell = -1;

        public delegate string Hit(int cell);
        public event Hit OnHit;

        private char[,] playerPlayfield = new char[10, 10];

        Game player2Window;
        Random rnd = new Random();

        public delegate void CloseWindow();
        public event CloseWindow onCloseWindow;

        private static readonly int rows = 10;
        private static readonly int columns = 10;

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
            playerShipsLoad(player1PlayfieldGrid);
            player2Window.OnHit += new Hit(this.onShoot);
            this.OnHit += new Hit(player2Window.onShoot);
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
            playerShipsLoad(player2PlayfieldGrid);
        }

        public string onShoot(int cell)
        {
            bool isHit = isHitShipUnit(cell);

            setShipUnit(cell, isHit, true);

            if (isHit)
            {
                hitsLabelChange();
                return myPlayfield[cell / rows, cell % columns].ToString();
            }

            player1Coming = !player1Coming;
            roundsLabelChange();

            return "false";
        }

        private bool isHitShipUnit(int cell)
        {
            if (char.IsDigit(myPlayfield[cell / rows, cell % columns]))
            {
                return true;
            }

            return false;
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
            int cell = calculateCell();

            if (calculatedCell != cell)
            {
                calculatedCell = cell;

                deleteShadow();

                Rectangle shadow = shadowUnitSettings();

                Grid.SetRow(shadow, cell / rows);
                Grid.SetColumn(shadow, cell % columns);

                rightTable.Children.Add(shadow);
                shadowExists = true;
            }
        }

        private void onGridMouseClick(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 1)
            {
                if (player1Coming && windowPlayer1 || !player1Coming && !windowPlayer1)
                {
                    deleteShadow();
                    shadowExists = false;

                    int cell = calculateCell();

                    bool shooted = isCellShooted(cell);

                    if (!shooted)
                    {
                        string shipUnitName = this.OnHit(cell);

                        if (shipUnitName != "false")
                        {
                            setShipUnit(cell, true, false);
                            //shipHpDecrement(shipUnitName);
                            enemyPlayfield[cell / rows, cell % columns] = 'T';

                            hitsLabelChange();
                            everyShipDestroyed();
                        }
                        else
                        {
                            setShipUnit(cell, false, false);
                            enemyPlayfield[cell / rows, cell % columns] = 'V';

                            player1Coming = !player1Coming;
                            roundsLabelChange();
                        }
                    }
                }
            }
        }

        private void stats_Click(object sender, RoutedEventArgs e)
        {
            ScoresWindow scoreWindow = new ScoresWindow();
            scoreWindow.Show();
        }

        private void surrendBtn_Click(object sender, RoutedEventArgs e)
        {
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

        private void hitsLabelChange()
        {
            if (windowPlayer1 && player1Coming)
            {
                player1HitsLabel.Content = Convert.ToInt32(player1HitsLabel.Content) + 1;
            }
            else if (!windowPlayer1 && !player1Coming)
            {
                player2HitsLabel.Content = Convert.ToInt32(player2HitsLabel.Content) + 1;
            }

            if (windowPlayer1 && !player1Coming)
            {
                player2HitsLabel.Content = Convert.ToInt32(player2HitsLabel.Content) + 1;
            }
            else if (!windowPlayer1 && player1Coming)
            {
                player1HitsLabel.Content = Convert.ToInt32(player1HitsLabel.Content) + 1;
            }
        }

        private int calculateCell()
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

        private void deleteShadow()
        {
            if (shadowExists)
            {
                int lastItem = rightTable.Children.Count - 1;
                rightTable.Children.RemoveAt(lastItem);
            }
        }

        private Rectangle shadowUnitSettings()
        {
            var shadow = new Rectangle();
            shadow.Fill = Brushes.LightGray;
            var Y = rightTable.Width / rows;
            var X = rightTable.Height / columns;
            shadow.Width = Y;
            shadow.Height = X;

            return shadow;
        }

        private bool isCellShooted(int cell)
        {
            if (enemyPlayfield[cell / rows, cell % columns] == 'T' || enemyPlayfield[cell / rows, cell % columns] == 'V')
            {
                return true;
            }

            return false;
        }

        private void setShipUnit(int cell, bool isHit, bool setLeftTable)
        {
            Rectangle ship = shipUnitSettings(isHit);

            Grid.SetRow(ship, cell / rows);
            Grid.SetColumn(ship, cell % columns);

            if (setLeftTable)
            {
                leftTable.Children.Add(ship);
            }
            else
            {
                rightTable.Children.Add(ship);
            }
        }

        private Rectangle shipUnitSettings(bool isHit)
        {
            Rectangle unit = new Rectangle();

            if (isHit)
            {
                unit.Fill = Brushes.DarkRed;
            }
            else
            {
                unit.Fill = Brushes.LightGray;
            }

            var Y = unit.Width / rows;
            var X = unit.Height / columns;
            unit.Width = Y;
            unit.Height = X;

            return unit;
        }

        private void gameEnd(string winner)
        {
            List<Score> scores = ScoreResult.ReadResult("score.json");
            Score newScore = new()
            {
                Enemy = player2Name,
                EnemyHits = Convert.ToInt32(player2HitsLabel.Content),
                Player = player1Name,
                PlayerHits = Convert.ToInt32(player1HitsLabel.Content),
                Rounds = Convert.ToInt32(roundsLabel.Content),
                Winner = winner
            };

            scores.Add(newScore);
            ScoreResult.WriteResult(scores, "score.json");


            this.onCloseWindow();

            MainWindow startWindow = new MainWindow();
            this.Close();
            startWindow.Show();
        }

        //Rossz
       /* private void shipHpDecrement(string shipUnitName)
        {
            switch (shipUnitName)
            {
                case "5":
                    carrierHpGrid.Children.RemoveAt(carrierHpGrid.Children.Count - 1);
                    break;
                case "4":
                    battleshipHpGrid.Children.RemoveAt(battleshipHpGrid.Children.Count - 1);
                    break;
                case "3":
                    cruiserHpGrid.Children.RemoveAt(cruiserHpGrid.Children.Count - 1);
                    break;
                case "2":
                    submarineHpGrid.Children.RemoveAt(submarineHpGrid.Children.Count - 1);
                    break;
                case "1":
                    destroyerHpGrid.Children.RemoveAt(destroyerHpGrid.Children.Count - 1);
                    break;
            }
        }*/

       private void roundsLabelChange()
        {
            changePlayerCounter++;

            if (changePlayerCounter % 2 == 0)
            {
                roundsLabel.Content = Convert.ToInt32(roundsLabel.Content) + 1;
            }
        }

        private void everyShipDestroyed()
        {
            if (player1HitsLabel.Content.ToString() == "15")
            {
                MessageBox.Show(player1Name + " won the game!", "The game is over", MessageBoxButton.OK);
                gameEnd(player1Name);
            }
            else if (player2HitsLabel.Content.ToString() == "15")
            {
                MessageBox.Show(player2Name + " won the game!", "The game is over", MessageBoxButton.OK);
                gameEnd(player2Name);
            }
        }
    }
}
