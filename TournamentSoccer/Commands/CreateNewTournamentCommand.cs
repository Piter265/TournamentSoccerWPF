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
            //List<Team> teams = new List<Team>();

            _launchTournamentViewModel.Teams
                .ToList()
                .ForEach(team => {
                    Team newTeam = new Team(team.TeamName, team.People);
                    Tournament.GetInstance().AddTeam(newTeam);
                    //teams.Add(newTeam);
                });


            IRandAlgorithm Algorithm;

            if (_launchTournamentViewModel.Rematches)
            {
                Algorithm = new RandAlgorithmWithRematches();
            }
            else
            {
                Algorithm = new RandAlgorithmWithoutRematches();
            }

            Tournament.GetInstance().DrawMatches(Algorithm);

        }


    }
}