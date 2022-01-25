﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.design_patterns.Builder;
using TournamentSoccer.Models;
using TournamentSoccer.ViewModel;

namespace TournamentSoccer.Commands
{
    public class AddStadiumCommand : CommandBase
    {
        private readonly LaunchTournamentViewModel _launchTournamentViewModel;
        private readonly AddStadiumViewModel _addStadiumViewModel;

        public AddStadiumCommand(LaunchTournamentViewModel launchTournamentViewModel, AddStadiumViewModel addStadiumViewModel)
        {
            _launchTournamentViewModel = launchTournamentViewModel;
            _addStadiumViewModel = addStadiumViewModel;
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
           // _launchTournamentViewModel.AddStadium(new Stadium());
            
            var director = new StadiumDirector();

            if (_addStadiumViewModel.MatchStadium)
            {
                var builder = new MatchStadiumBuilder();
                director.Builder = builder;
                director.BuildMatchStadium(_addStadiumViewModel.StadiumName, _addStadiumViewModel.StadiumCity, _addStadiumViewModel.StadiumTribuneSize);
                _launchTournamentViewModel.AddStadium(new Stadium(builder.GetStadium()));
            }
            else
            {
                var builder = new TrainingStadiumBuilder();
                director.Builder = builder;
                director.BuildTrainingStadium(_addStadiumViewModel.StadiumName, _addStadiumViewModel.StadiumCity, _addStadiumViewModel.StadiumTribuneSize);
                _launchTournamentViewModel.AddStadium(new Stadium(builder.GetStadium()));
            }
        }
    }
}
