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

        private readonly ObservableCollection<PlayerViewModel> _players;
        public IEnumerable<PlayerViewModel> Players => _players;

        //public ICommand Maksesc{get;}

        private string _name;

        public PlayersListingViewModel()
        {
            _players = new ObservableCollection<PlayerViewModel>();
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

            
        
    }
}
