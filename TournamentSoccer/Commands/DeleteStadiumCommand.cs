using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;
using TournamentSoccer.ViewModel;

namespace TournamentSoccer.Commands
{
    public class DeleteStadiumCommand : CommandBase
    {
        private readonly LaunchTournamentViewModel _launchTournamentViewModel;

        public DeleteStadiumCommand(LaunchTournamentViewModel launchTournamentViewModel)
        {
            _launchTournamentViewModel = launchTournamentViewModel;
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
            _launchTournamentViewModel.DeleteStadium(_launchTournamentViewModel.SelectedStadium);
            /*
            var director = new TeamDirector();

            if (_addTeamViewModel.Disabilities)
            {
                var builder = new UniqueTeamBuilder();
                director.TeamBuilder = builder;
                director.BuildUniqueTeam(_addTeamViewModel.TeamName, people);
                _launchTournamentViewModel.Add(new Team(builder.GetTeam()));
            }
            else
            {
                var builder = new ClassicalTeamBuilder();
                director.TeamBuilder = builder;
                director.BuildClassicalTeam(_addTeamViewModel.TeamName, people);
                _launchTournamentViewModel.Add(new Team(builder.GetTeam()));
            }*/
        }
    }
}
