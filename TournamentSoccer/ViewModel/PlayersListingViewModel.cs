using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;

namespace TournamentSoccer.ViewModel
{
    class PlayersListingViewModel : ViewModelBase
    {
        private ObservableCollection<PlayerViewModel> _players;
        public IEnumerable<PlayerViewModel> Players => _players;

        public PlayersListingViewModel(Tournament tournament)
        {
            _players = new ObservableCollection<PlayerViewModel>();
        }    
        
    }
}
