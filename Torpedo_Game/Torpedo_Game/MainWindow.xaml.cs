using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Torpedo_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PvsPButton_Click(object sender, RoutedEventArgs e)
        {
            PvsPWindow pvsPWindow = new PvsPWindow();
            pvsPWindow.Show();
            mainWindow.Close();
        }

        private void PvsAIButton_Click(object sender, RoutedEventArgs e)
        {
            PvsAIWindow pvsAIWindow = new PvsAIWindow();
            pvsAIWindow.Show();
            mainWindow.Close();
        }

        private void scoresButton_Click(object sender, RoutedEventArgs e)
        {
            ScoresWindow scoresWindow = new ScoresWindow();
            scoresWindow.Show();
            mainWindow.Close();
        }
    }
}
