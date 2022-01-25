using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;

namespace TournamentSoccer.ViewModel
{
    public class MatchesListingViewModel : ViewModelBase
    {
        public ObservableCollection<MatchViewModel> Matches { get; set; }
        public MatchViewModel SelectedMatch { get; set; }

        public MatchesListingViewModel()
        {
            Matches = new ObservableCollection<MatchViewModel>();
        }
    }
}
