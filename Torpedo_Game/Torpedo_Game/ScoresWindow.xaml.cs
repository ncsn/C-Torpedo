using System.Collections.Generic;
using System.Windows;

namespace Torpedo_Game
{
    public partial class ScoresWindow : Window
    {
        //public List<Score> result;
        public ScoresWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            List<Score> result = ScoreResult.ReadResult("score.json");
            table.ItemsSource = result;
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            scoreWindow.Close();
        }
    }
}
