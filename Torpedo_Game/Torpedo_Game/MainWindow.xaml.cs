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
        private void pvspButton_Click(object sender, RoutedEventArgs e)
        {
            PvsPWindow pvsp = new PvsPWindow();
            pvsp.Show();
            mainWindow.Close();
        }

        private void pvsaiButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void scoresButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
