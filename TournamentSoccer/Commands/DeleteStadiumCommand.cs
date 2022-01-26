﻿using System;
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
        }
    }
}
