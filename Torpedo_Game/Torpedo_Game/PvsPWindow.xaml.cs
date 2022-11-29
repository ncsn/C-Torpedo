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
    /// Interaction logic for PvsPWindow.xaml
    /// </summary>
    public partial class PvsPWindow : Window
    {
        private string player1Name;
        private string player2Name;
        public PvsPWindow()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            pvspWindow.Close();
        }

        private void playButton_Click(object sender, RoutedEventArgs e)
        {
            player1Name = Player1TextBox.Text;
            player2Name = Player2TextBox.Text;
            Game game = new Game(player1Name, player2Name, sender);
            game.Show();
            pvspWindow.Close();
        }
    }
}
