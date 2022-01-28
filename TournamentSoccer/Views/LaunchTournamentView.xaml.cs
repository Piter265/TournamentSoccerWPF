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
using TournamentSoccer.ViewModel;

namespace TournamentSoccer.Views
{
    /// <summary>
    /// Interaction logic for LaunchTournamentView.xaml
    /// </summary>
    public partial class LaunchTournamentView : Window
    {
        public readonly LaunchTournamentViewModel _launchTournamentViewModel;
        public LaunchTournamentView()
        {
            InitializeComponent();

            _launchTournamentViewModel = new LaunchTournamentViewModel();

            DataContext = _launchTournamentViewModel;
        }

        private void addTeamBtn_Click(object sender, RoutedEventArgs e)
        {
            AddTeamView addTeam = new AddTeamView(_launchTournamentViewModel);
            addTeam.Show();
        }

        private void createNewTournamentBtn_Click(object sender, RoutedEventArgs e)
        {
            if (_launchTournamentViewModel.Teams.Count % 2 == 0 && _launchTournamentViewModel.Teams.Count() > 0 && _launchTournamentViewModel.Stadiums.Count() > 0)
            {
                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Add more teams or stadiums", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void addStadiumBtn_Click(object sender, RoutedEventArgs e)
        {
            AddStadiumView addStadium = new AddStadiumView(_launchTournamentViewModel);
            addStadium.Show();
        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (_launchTournamentViewModel.Rematches == false)
            {
                _launchTournamentViewModel.Rematches = true;
            }
            else
            {
                _launchTournamentViewModel.Rematches = false;
            }
        }
    }
}
