using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;
using TournamentSoccer.ViewModel;

namespace TournamentSoccer.Commands
{
    class SubmitTeamCommand : CommandBase
    {
        private readonly LaunchTournamentViewModel _launchTournamentViewModel;//!!
        private readonly AddTeamViewModel _addTeamViewModel;

        public SubmitTeamCommand(AddTeamViewModel addTeamViewModel, LaunchTournamentViewModel launchTournamentViewModel)
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
                .ForEach(person => people.Add(new Coach(person.Name, person.LastName, person.Function, person.Age)));

            _launchTournamentViewModel.Add(new Team(_addTeamViewModel.TeamName, people));
        }
    }
}
