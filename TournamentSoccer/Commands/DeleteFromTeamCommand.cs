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
        private readonly AddTeamViewModel _addTeamViewModel;

        public DeleteFromTeamCommand(AddTeamViewModel addTeamViewModel)
        {
            _addTeamViewModel = addTeamViewModel;
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
           _addTeamViewModel.Delete(_addTeamViewModel.SelectedPerson);
        }
    }
}
