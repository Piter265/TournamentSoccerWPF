using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using TournamentSoccer.design_patterns;
using TournamentSoccer.Models;
using TournamentSoccer.ViewModel;

namespace TournamentSoccer.Commands
{
    public class CreateNewTournamentCommand : CommandBase
    {
        private readonly LaunchTournamentViewModel _launchTournamentViewModel;
        private Tournament _tournament;

        public CreateNewTournamentCommand(LaunchTournamentViewModel launchTournamentViewModel, Tournament tournament)
        {
            _launchTournamentViewModel = launchTournamentViewModel;
            _tournament = tournament;
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            if(_launchTournamentViewModel.Teams.Count % 2 != 0 || _launchTournamentViewModel.Teams.Count() == 0 || _launchTournamentViewModel.Stadiums.Count() == 0)
            {
                return;
            }

            _launchTournamentViewModel.Teams
                .ToList()
                .ForEach(team => {
                    Team newTeam = new Team(team.TeamName, team.People);
                    _tournament.AddTeam(newTeam);
                });

            _launchTournamentViewModel.Stadiums
                .ToList()
                .ForEach(stadium =>
                {
                    _tournament.AddStadium(stadium.Stadium);
                });

            IRandAlgorithm algorithm;
            if (_launchTournamentViewModel.Rematches)
            {
                algorithm = new RandAlgorithmWithRematches();
            }
            else
            {
                algorithm = new RandAlgorithmWithoutRematches();
            }

            _tournament.LoadRefeeres();

            List<Match> matches = _tournament.DrawMatches(algorithm);

            matches.ToList().ForEach(match => MatchesListingViewModel.Matches.Add(match));
            MatchesListingViewModel.refreshList();
            //_tournament.Matches = MatchesListingViewModel.Matches;
        }

    }
}