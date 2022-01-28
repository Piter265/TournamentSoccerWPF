using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TournamentSoccer.Models;
using TournamentSoccer.ViewModel;

namespace TournamentSoccer.Commands
{
    public class SaveTournamentCommand : CommandBase
    {
        private Tournament _tournament;
        public SaveTournamentCommand(Tournament tournament)
        {
            _tournament = tournament;
        }

        private void OnViewModelPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            _tournament.Matches = MatchesListingViewModel.Matches;
            _tournament.Teams = TeamsListingViewModel.Teams;
            _tournament.SaveTournamentToFile();
            MessageBox.Show("Tournament was saved", "Save", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
