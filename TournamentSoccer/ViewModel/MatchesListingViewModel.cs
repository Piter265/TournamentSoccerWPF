using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TournamentSoccer.Commands;
using TournamentSoccer.Models;
using TournamentSoccer.Views;

namespace TournamentSoccer.ViewModel
{
    public class MatchesListingViewModel : ViewModelBase
    {
        public static List<Match> Matches { get; set; } = new List<Match>();
        private MatchesListingView _matchesListingView;

        public MatchesListingViewModel(MatchesListingView matchesListingView)
        {
            _matchesListingView = matchesListingView;
        }
    }
}
