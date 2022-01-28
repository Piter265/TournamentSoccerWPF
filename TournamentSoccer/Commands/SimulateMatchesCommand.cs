using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;
using TournamentSoccer.ViewModel;

namespace TournamentSoccer.Commands
{
    public class SimulateMatchesCommand : CommandBase
    {
        private Tournament _tournament;
        public SimulateMatchesCommand(Tournament tournament)
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
            MatchesListingViewModel.cleanStatsInTeams();
            MatchesListingViewModel.Matches = _tournament.simulateMatches(MatchesListingViewModel.Matches);
            //czyszczenie wyników teamów

            /*var teams = _tournament.Teams;
            _tournament.Teams = new List<Team>();
            teams.ForEach(team =>
            {
                _tournament.Teams.Add(new Team(team.Name, team.People));
            });*/


            MatchesListingViewModel.refreshList();
            /*
            TeamsListingViewModel.sortTeams();
            TeamsListingViewModel.refreshList();*/
        }
    }
}
