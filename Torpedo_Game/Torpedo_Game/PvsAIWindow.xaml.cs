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
    /// Interaction logic for PvsAIWindow.xaml
    /// </summary>
    public partial class PvsAIWindow : Window
    {
        private string playerName;
        public PvsAIWindow()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, RoutedEventArgs e)
        {
            playerName = PlayerName.Text;
            if (playerNameFilter(playerName))
            {
                ShipChoice player1ShipChoiceWindow = new(playerName);
                App.Current.MainWindow = player1ShipChoiceWindow;
                pvsaiWindow.Close();
                player1ShipChoiceWindow.Show();
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            pvsaiWindow.Close();
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
