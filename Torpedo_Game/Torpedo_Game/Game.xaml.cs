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
        private char[,] myPlayfield = new char[10, 10];
        public Game(string player1Name, Grid player1PlayfieldGrid, char[,] player1Playfield, string player2Name, Grid player2PlayfieldGrid, char[,] player2Playfield)
        {
            InitializeComponent();
            this.Title = player1Name;
            this.myPlayfield = player1Playfield;

            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }
    }
}
