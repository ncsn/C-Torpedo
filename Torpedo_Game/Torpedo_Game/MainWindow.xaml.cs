using System.Windows;

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
