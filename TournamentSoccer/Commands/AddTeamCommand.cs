using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;
using TournamentSoccer.ViewModel;

namespace TournamentSoccer.Commands
{
    class AddTeamCommand : CommandBase
    {
        private readonly Tournament _tournament;
        private readonly AddTeamViewModel _addTeamViewModel;

        public AddTeamCommand(AddTeamViewModel addTeamViewModel, Tournament tournament)
        {
            _tournament = tournament;
            _addTeamViewModel = addTeamViewModel;
            _addTeamViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }


        private void OnViewModelPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(_addTeamViewModel.TeamName))
            {
                OnExecutedChanged();
            }
        }

        public override bool CanExecute(object parameter)
        {
            return !string.IsNullOrEmpty(_addTeamViewModel.TeamName) && base.CanExecute(parameter);
        }

        public override void Execute(object parameter)
        {
            Team team = new Team(
                _addTeamViewModel.TeamName,
                _addTeamViewModel.TeamWins,
                _addTeamViewModel.TeamLosses,
                _addTeamViewModel.TeamDraws
                );
            _tournament.Teams.Add(team);
        }
    }
}
