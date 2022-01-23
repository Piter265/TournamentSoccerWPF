using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.ViewModel;

namespace TournamentSoccer.Commands
{
    public class DeleteTeamCommand : CommandBase
    {
        private readonly LaunchTournamentViewModel _launchTournamentViewModel;//!!

        public DeleteTeamCommand(LaunchTournamentViewModel launchTournamentViewModel)
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
            _launchTournamentViewModel.DeleteTeam(_launchTournamentViewModel.SelectedTeam);
        }
    }
}

