using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentSoccer.ViewModel
{
    class ClubsListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ClubViewModel> _clubs;

        public IEnumerable<ClubViewModel> Clubs => _clubs;

        private string _name;

        public ClubsListingViewModel()
        {
            _clubs = new ObservableCollection<ClubViewModel>();

            _clubs.Add(new ClubViewModel(new Models.Club("Jaga", 1, 2, 3)));
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