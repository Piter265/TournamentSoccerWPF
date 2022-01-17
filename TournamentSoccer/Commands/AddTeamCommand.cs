using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;
using TournamentSoccer.ViewModel;

namespace TournamentSoccer.Commands
{
    public class AddTeamCommand : CommandBase
    {
        private readonly LaunchTournamentViewModel _launchTournamentViewModel;//!!
        private readonly AddTeamViewModel _addTeamViewModel;

        public AddTeamCommand(AddTeamViewModel addTeamViewModel, LaunchTournamentViewModel launchTournamentViewModel)
        {
            _launchTournamentViewModel = launchTournamentViewModel;
            _addTeamViewModel = addTeamViewModel;
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
            List<Person> people = new List<Person>();
            _addTeamViewModel.People
                .ToList()
                .ForEach(person => people.Add(new Coach(person.PersonName, person.PersonLastName, person.PersonFunction, person.PersonAge)));

            var director = new TeamDirector();

            if (_launchTournamentViewModel.Disabilities)
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
            }
        }
    }
}
