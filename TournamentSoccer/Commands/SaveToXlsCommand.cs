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
    public class SaveToXlsCommand : CommandBase
    {
        private Tournament _tournament;
        public SaveToXlsCommand(Tournament tournament)
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
            //_tournament.Teams = TeamsListingViewModel.Teams;
            //_tournament.Matches = MatchesListingViewModel.Matches;
            MessageBox.Show("Available soon...", "XLS message", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
