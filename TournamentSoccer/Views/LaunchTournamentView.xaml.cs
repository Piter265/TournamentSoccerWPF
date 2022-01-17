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

            _launchTournamentViewModel= new LaunchTournamentViewModel();

            DataContext = _launchTournamentViewModel;
        }

        private void addTeamBtn_Click(object sender, RoutedEventArgs e)
        {
            AddTeamView addTeam = new AddTeamView(_launchTournamentViewModel);
            addTeam.Show();
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
