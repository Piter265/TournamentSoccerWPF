using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;
using TournamentSoccer.ViewModel;

namespace TournamentSoccer.Commands
{
    class DeleteFromTeamCommand : CommandBase
    {
        private readonly Tournament _tournament;
        private readonly AddTeamViewModel _addTeamViewModel;

        public DeleteFromTeamCommand(AddTeamViewModel addTeamViewModel, Tournament tournament)
        {
            _tournament = tournament;
            _addTeamViewModel = addTeamViewModel;
            _addTeamViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }


        private void OnViewModelPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(_addTeamViewModel.PersonName))
            {
                OnExecutedChanged();
            }
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            var person = new Coach(
                _addTeamViewModel.PersonName,
                _addTeamViewModel.PersonLastName,
                _addTeamViewModel.PersonFunction,
                _addTeamViewModel.PersonAge
                );
            _addTeamViewModel.Delete(person);
        }
    }
}
