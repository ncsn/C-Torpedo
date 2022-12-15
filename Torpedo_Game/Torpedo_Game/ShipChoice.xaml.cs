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
    /// Interaction logic for ShipChoice.xaml
    /// </summary>
    public partial class ShipChoice : Window
    {
        private string selectedShip = null;
        private char selectedShipUnit;
        private int rows = 10;
        private int columns = 10;
        private int calculatedCell = -1;
        private bool shipShadow = false;
        private bool shipHorizontal = false;

        private char[,] battleshipPlayfield = new char[10, 10];

        private bool vsComputer;
        private bool player2PlaceShips = false;
        private string player1Name;
        private string player2Name;
        private char[,] player1BattleshipPlayfield = new char[10, 10];
        private Grid player1PlayfieldGrid;

        public ShipChoice(string player1Name)
        {
            InitializeComponent();

            vsComputer = true;
            this.player1Name = player1Name;

            this.Title = player1Name + "'s ship placement";
            welcomeLabel.Content = player1Name + "'s ship placement";
        }

        public ShipChoice(string player1Name, string player2Name)
        {
            InitializeComponent();

            vsComputer = false;
            this.player1Name = player1Name;
            this.player2Name = player2Name;

            this.Title = player1Name + "'s ship placement";
            welcomeLabel.Content = player1Name + "'s ship placement";
        }

        public ShipChoice(string player1Name, string player2Name, Grid playfield, char[,] battleshipPlayfield)
        {
            InitializeComponent();

            player2PlaceShips = true;
            this.player1Name = player1Name;
            this.player2Name = player2Name;
            this.player1BattleshipPlayfield = battleshipPlayfield;
            this.player1PlayfieldGrid = playfield;

            this.Title = player2Name + "'s ship placement";
            welcomeLabel.Content = player2Name + "'s ship placement";
        }

        private void onGridMouseClick(object sender, MouseButtonEventArgs e) //ship placement in the playfield
        {
            if (e.ClickCount == 1)
            {
                int shipLength = shipLengthCalculate();
                deleteShipShadow(shipLength);
                shipShadow = false;

                bool shipPlacementEnoughSpace = true;

                for (int i = 0; i < shipLength; i++)
                {
                    int cell = calculateCell();

                    Rectangle ship = shipSettings();

                    //enough space for the selected ship or not
                    shipPlacementEnoughSpace = !shipExtendsBeyond(cell, shipLength, shipHorizontal);

                    //collision with another ship
                    if (shipPlacementEnoughSpace)
                    {
                        shipPlacementEnoughSpace = !shipCollision(i, cell, shipLength, shipHorizontal);
                    }

                    if (shipPlacementEnoughSpace)
                    {
                        shipPlaceToPlayfield(ship, i, cell, shipHorizontal);
                    }
                    else
                    {
                        break;
                    }
                }

                if (shipPlacementEnoughSpace)
                {
                    setSelectedShipButtonDisabled();
                }
            }
        }

        private void setSelectedShipButtonDisabled()
        {
            switch (selectedShip) //placed ship button set disabled
            {
                case "Carrier":
                    carrierBtn.IsEnabled = false;
                    break;
                case "Battleship":
                    battleshipBtn.IsEnabled = false;
                    break;
                case "Cruiser":
                    cruiserBtn.IsEnabled = false;
                    break;
                case "Submarine":
                    submarineBtn.IsEnabled = false;
                    break;
                case "Destroyer":
                    destroyerBtn.IsEnabled = false;
                    break;
            }

            selectedShip = null;
        }

        private void shipPlaceToPlayfield(Rectangle ship, int i, int cell, bool shipHorizontal)
        {
            if (shipHorizontal)
            {
                Grid.SetRow(ship, cell / rows);
                Grid.SetColumn(ship, cell % columns + i);

                //save the ship position
                battleshipPlayfield[cell / rows, cell % columns + i] = selectedShipUnit;
            }
            else if (!shipHorizontal)
            {
                Grid.SetRow(ship, cell / rows + i);
                Grid.SetColumn(ship, cell % columns);

                //save the ship position
                battleshipPlayfield[cell / rows + i, cell % columns] = selectedShipUnit;
            }

            playfield.Children.Add(ship);
        }

        private bool shipExtendsBeyond(int cell, int shipLength, bool shipHorizontal)
        {
            if (shipHorizontal)
            {
                if (cell / rows < rows && cell % columns + shipLength - 1 < columns)
                {
                    return false;
                }
            }
            else if (!shipHorizontal)
            {
                if (cell / rows + shipLength - 1 < rows && cell % columns < columns)
                {
                    return false;
                }
            }

            return true;
        }

        private bool shipCollision(int i, int cell, int shipLength, bool shipHorizontal)
        {
            for (int unit = 0 + i; unit < shipLength; unit++)
            {
                if (shipHorizontal)
                {
                    if (char.IsDigit(battleshipPlayfield[cell / rows, cell % columns + unit]))
                    {
                        return true;
                    }
                }
                else if (!shipHorizontal)
                {
                    if (char.IsDigit(battleshipPlayfield[cell / rows + unit, cell % columns]))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private Rectangle shipSettings()
        {
            Rectangle ship = new()
            {
                Fill = Brushes.DodgerBlue
            };
            var Y = playfield.Width / rows;
            var X = playfield.Height / columns;
            ship.Width = Y;
            ship.Height = X;

            ship.Name = selectedShip;

            return ship;
        }

        private void onGridMouseOver(object sender, MouseEventArgs e) //ship shadow
        {
            int shipLength = shipLengthCalculate();

            if (shipLength != 0)
            {
                int cell = calculateCell();

                if (calculatedCell != cell)
                {
                    calculatedCell = cell;

                    deleteShipShadow(shipLength);

                    for (int i = 0; i < shipLength; i++)
                    {
                        Rectangle shadow = shadowUnitSettings();

                        // horizontal/vertical ship alignment
                        if (!shipHorizontal)
                        {
                            Grid.SetRow(shadow, cell / rows + i);
                            Grid.SetColumn(shadow, cell % columns);
                        }
                        else if (shipHorizontal)
                        {
                            Grid.SetRow(shadow, cell / rows);
                            Grid.SetColumn(shadow, cell % columns + i);
                        }

                        shipShadow = true;
                        playfield.Children.Add(shadow);
                    }
                }
            }
        }

        private Rectangle shadowUnitSettings()
        {
            Rectangle shadow = new()
            {
                Fill = Brushes.LightGray
            };
            var Y = playfield.Width / rows;
            var X = playfield.Height / columns;
            shadow.Width = Y;
            shadow.Height = X;

            return shadow;
        }

        private int calculateCell() //which cell the cursor is on
        {
            var point = Mouse.GetPosition(playfield);

            int row = 0;
            int col = 0;
            double accumulatedHeight = 0.0;
            double accumulatedWidth = 0.0;

            foreach (var rowDefinition in playfield.RowDefinitions)
            {
                accumulatedHeight += rowDefinition.ActualHeight;
                if (accumulatedHeight >= point.Y)
                    break;
                row++;
            }

            foreach (var columnDefinition in playfield.ColumnDefinitions)
            {
                accumulatedWidth += columnDefinition.ActualWidth;
                if (accumulatedWidth >= point.X)
                    break;
                col++;
            }

            return (row * 10) + col;
        }

        private int shipLengthCalculate()
        {
            int length = selectedShip switch
            {
                "Carrier" => 5,
                "Battleship" => 4,
                "Cruiser" => 3,
                "Submarine" => 2,
                "Destroyer" => 1,
                _ => 0,
            };
            return length;
        }

        private void deleteShipShadow(int shipLength)
        {
            if (shipShadow == true)
            {
                for (int i = 0; i < shipLength; i++)
                {
                    int lastItem = playfield.Children.Count - 1;
                    playfield.Children.RemoveAt(lastItem);
                }
            }
        }

        private bool everyShipPlaced()
        {
            if (!carrierBtn.IsEnabled && !battleshipBtn.IsEnabled && !cruiserBtn.IsEnabled && !submarineBtn.IsEnabled && !destroyerBtn.IsEnabled)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private Rectangle shipSettings(int shipLength)
        {
            Rectangle ship = new()
            {
                Fill = Brushes.DodgerBlue
            };
            var Y = playfield.Width / rows;
            var X = playfield.Height / columns;
            ship.Width = Y;
            ship.Height = X;

            shipSetName(ship, shipLength);

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
    }
}
