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
using TournamentSoccer.Models;
using TournamentSoccer.Views;

namespace TournamentSoccer
{
    /// <summary>
    /// Interaction logic for startWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void startNewTournamentBtn_click(object sender, RoutedEventArgs e)
        {
            LaunchTournamentView launchTournament = new LaunchTournamentView();
            launchTournament.Show();
            this.Close();
        }

        private void loadTournamentButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Tournament.GetInstance().LoadTournamentFromFile())
            {
                return;
            }
            else
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
        }
    }
}