using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            _tournament.Matches = new List<Match>(MatchesListingViewModel.Matches);
            _tournament.SaveTournamentToFile();
        }
    }
}
