using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.design_patterns;
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
            //Tournament tournament = (Tournament)parameter;
            Tournament tournament = Tournament.GetInstance();

            //List<Team> teams = new List<Team>();

            _launchTournamentViewModel.Teams
                .ToList()
                .ForEach(team => {
                Team newTeam = new Team(team.TeamName, team.People);
                    tournament.AddTeam(newTeam);
                    //teams.Add(newTeam);
                });


            if (_launchTournamentViewModel.Rematches)
            {
                
                tournament.Algorithm = new RandAlgorithmWithRematches();
            }
            else
            {
                tournament.Algorithm = new RandAlgorithmWithoutRematches();
            }

            
        }

    }
}
