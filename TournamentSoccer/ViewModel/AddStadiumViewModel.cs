using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TournamentSoccer.Commands;

namespace TournamentSoccer.ViewModel
{
    public class AddStadiumViewModel : ViewModelBase
    {
        public ICommand AddStadiumCommand { get; }
        public bool MatchStadium { get; set;   }

        public AddStadiumViewModel(LaunchTournamentViewModel launchTournamentViewModel)
        {
            AddStadiumCommand = new AddStadiumCommand(launchTournamentViewModel, this);
        }

        private string _stadiumName;
        private string _stadiumCity;
        private int _stadiumTribuneSize;


        public string StadiumName
        {
            get
            {
                return _stadiumName;
            }
            set
            {
                _stadiumName = value;
                OnPropertyChanged(nameof(StadiumName));
            }
        }


        public string StadiumCity
        {
            get
            {
                return _stadiumCity;
            }
            set
            {
                _stadiumCity = value;
                OnPropertyChanged(nameof(StadiumCity));
            }
        }

        public int StadiumTribuneSize
        {
            get
            {
                return _stadiumTribuneSize;
            }
            set
            {
                _stadiumTribuneSize = value;
                OnPropertyChanged(nameof(StadiumTribuneSize));
            }
        }
    }
}
