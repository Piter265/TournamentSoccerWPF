using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TournamentSoccer.Commands;
using TournamentSoccer.Models;

namespace TournamentSoccer.ViewModel
{
    class AddTeamViewModel : ViewModelBase
    {
        private readonly ObservableCollection<PlayerViewModel> _players;

        public IEnumerable<PlayerViewModel> Players => _players;

        public ICommand SubmitCommand { get; }

        public AddTeamViewModel(Tournament tournament)
        {
            _players = new ObservableCollection<PlayerViewModel>();
            SubmitCommand = new AddTeamCommand(this, tournament);
        }

        private string _teamName;
        private int _teamWins;
        private int _teamLosses;
        private int _teamDraws;


        public string TeamName
        {
            get
            {
                return _teamName;
            }
            set
            {
                _teamName = value;
                OnPropertyChanged(nameof(TeamName));
            }
        }

        public int TeamWins
        {
            get
            {
                return _teamWins;
            }
            set
            {
                _teamWins = value;
                OnPropertyChanged(nameof(TeamWins));
            }
        }
        public int TeamLosses
        {
            get
            {
                return _teamLosses;
            }
            set
            {
                _teamLosses = value;
                OnPropertyChanged(nameof(TeamLosses));
            }
        }

        public int TeamDraws
        {
            get
            {
                return _teamDraws;
            }
            set
            {
                _teamDraws = value;
                OnPropertyChanged(nameof(TeamDraws));
            }
        }
    }
}
