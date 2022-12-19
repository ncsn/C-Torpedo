using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
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

            if (playerNameFilter(player1Name) && playerNameFilter(player2Name))
            {
                ShipChoice playerShipChoiceWindow = new(player1Name, player2Name);
                App.Current.MainWindow = playerShipChoiceWindow;
                pvspWindow.Close();
                playerShipChoiceWindow.Show();
            }
        }

        private bool playerNameFilter(string p)
        {
            List<char> specialCharacters = new List<char>();
            char[] spec = new char[] { '~', '`', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '-', '+', '=', '{', '[', '}', ']', '|', ':', ';', '"', '<', ',', '>', '.', '?', '/', ' ', ' ' };
            specialCharacters.AddRange(spec);
            int error = 0;
            if (!string.IsNullOrEmpty(p))
            {
                for (int i = 0; i < p.Length; i++)
                {
                    for (int j = 0; j < specialCharacters.Count; j++)
                    {
                        if (p[i] == specialCharacters[j])
                        {
                            error++;
                        }
                    }
                }
            }
            else
            {
                return false;
            }


            if (error > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
