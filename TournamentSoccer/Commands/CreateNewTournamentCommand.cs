using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;
using TournamentSoccer.ViewModel;

namespace TournamentSoccer.Commands
{
    public class CreateNewTournamentCommand : CommandBase
    {
        private readonly LaunchTournamentViewModel _launchTournamentViewModel;

        public CreateNewTournamentCommand(LaunchTournamentViewModel launchTournamentViewModel)
        {
            _launchTournamentViewModel = launchTournamentViewModel;
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            _launchTournamentViewModel.Teams
                .ToList()
                .ForEach(team => Tournament.GetInstance().AddTeam((new Team(team.TeamName, team.People))));

            Tournament.GetInstance().DrawMatches();
        }

    }
}
