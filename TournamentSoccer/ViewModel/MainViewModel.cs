using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;

namespace TournamentSoccer.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        public ViewModelBase MatchesViewModel { get; }
        public ViewModelBase TeamViewModel { get; }
        public ViewModelBase PlayersViewModel { get; }
        public ViewModelBase AddTeamViewModel { get; }

        public MainViewModel(Tournament tournament)
        {
            MatchesViewModel = new MatchesListingViewModel(tournament);
            TeamViewModel = new TeamsListingViewModel(tournament);
            PlayersViewModel = new PlayersListingViewModel(tournament);
            AddTeamViewModel = new AddTeamViewModel(tournament);

        }
    }
}
