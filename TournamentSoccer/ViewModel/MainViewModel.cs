using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentSoccer.ViewModel
{
    class MainViewModel : ViewModelBase
    {
        public ViewModelBase MatchesViewModel { get; }
        public ViewModelBase ClubViewModel { get; }
        public ViewModelBase PlayersViewModel { get; }

        public MainViewModel()
        {
            MatchesViewModel = new MatchesListingViewModel();
            ClubViewModel = new ClubsListingViewModel();
            PlayersViewModel = new PlayersListingViewModel();
        }
    }
}
