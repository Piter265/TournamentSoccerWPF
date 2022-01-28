using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.ViewModel;

namespace TournamentSoccer.Commands
{
    public class ComputeMatchesCommand : CommandBase
    {
        public ComputeMatchesCommand()
        {

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
            MatchesListingViewModel.cleanStatsInTeams();
            TeamsListingViewModel.sortTeams();
            TeamsListingViewModel.refreshList();
        }
    }
}
