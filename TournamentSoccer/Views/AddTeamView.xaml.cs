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
using System.Windows.Shapes;
using TournamentSoccer.ViewModel;

namespace TournamentSoccer.Views
{
    /// <summary>
    /// Interaction logic for AddTeamView.xaml
    /// </summary>
    public partial class AddTeamView : Window
    {
        private AddTeamViewModel _addTeamViewModel;
        public AddTeamView(LaunchTournamentViewModel launchTournamentViewModel)
        {
            InitializeComponent();

            _addTeamViewModel = new AddTeamViewModel(launchTournamentViewModel);

            DataContext = _addTeamViewModel;
        }

        private void playerBtn_Checked(object sender, RoutedEventArgs e)
        {
            addToTeamBtn.Content = "Add Player";
            _addTeamViewModel.PlayerType = true;
        }

        private void coachBtn_Checked(object sender, RoutedEventArgs e)
        {
            addToTeamBtn.Content = "Add Coach";
            _addTeamViewModel.PlayerType = false;
        }

        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void disabilitiesCheckBox_Click(object sender, RoutedEventArgs e)
        {
            _addTeamViewModel.Disabilities = (bool)disabilitiesCheckBox.IsChecked;
        }
    }
}