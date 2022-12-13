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
        private object sender;

        public int ships = 2;

        public Game()
        {
            InitializeComponent();
        }

        public Game(string p1, string p2, object sender)
        {
            InitializeComponent();
            this.player1Name = p1;
            this.player2Name = p2;
            this.sender = sender;
            Player1TextBox.Text = player1Name;
            Player2TextBox.Text = player2Name;
            Restart();
        }

        public void Restart()
        {
            
        }

        public void PlayerPositionButtonEvent(object sender, EventArgs e)
        {

            if (ships > 0)
            {
                var button = (Button)sender;

                button.IsEnabled = false;
                button.Tag = "ship";
                button.Background = Brushes.Gray;
                ships -= 1;
            }
        }
    }
}
