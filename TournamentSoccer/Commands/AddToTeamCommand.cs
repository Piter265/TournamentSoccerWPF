using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;
using TournamentSoccer.ViewModel;

namespace TournamentSoccer.Commands
{
    class AddToTeamCommand : CommandBase
    {
        private readonly AddTeamViewModel _addTeamViewModel;

        public AddToTeamCommand(AddTeamViewModel addTeamViewModel)
        {
            _addTeamViewModel = addTeamViewModel;
            _addTeamViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }


        private void OnViewModelPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(_addTeamViewModel.PersonName))
            {
                OnExecutedChanged();
            }
            if (e.PropertyName == nameof(_addTeamViewModel.PersonLastName))
            {
                OnExecutedChanged();
            }
            if (e.PropertyName == nameof(_addTeamViewModel.PersonAge))
            {
                OnExecutedChanged();
            }
            if (e.PropertyName == nameof(_addTeamViewModel.PersonFunction))
            {
                OnExecutedChanged();
            }
            /*if (e.PropertyName == nameof(_addTeamViewModel.PersonType))
            {
                OnExecutedChanged();
            }*/
        }

        public override bool CanExecute(object parameter)
        {
            return !string.IsNullOrEmpty(_addTeamViewModel.PersonName) &&
                !string.IsNullOrEmpty(_addTeamViewModel.PersonLastName) &&
                !string.IsNullOrEmpty(_addTeamViewModel.PersonFunction) &&
                !string.IsNullOrEmpty(Convert.ToString(_addTeamViewModel.PersonAge));
        }

        public override void Execute(object parameter)
        {
            var person = new Person(
                _addTeamViewModel.PersonName,
            _addTeamViewModel.PersonLastName,
            _addTeamViewModel.PersonFunction,
            _addTeamViewModel.PersonAge
                );

            //if (_addTeamViewModel.PersonType.Equals("Player"))
            {
                var player = (Player)person.clone();
                this._addTeamViewModel.Add(player);
            }
            //else
            {
                var coach = (Coach)person.clone();
                this._addTeamViewModel.Add(coach);
            }

        }
    }
}