using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;
using TournamentSoccer.Views;

namespace TournamentSoccer.ViewModel
{
    public class MatchesListingViewModel : ViewModelBase
    {
        public static List<Match> Matches { get; set; } = new List<Match>();
        private readonly Tournament _tournament = Tournament.GetInstance();
        private MatchesListingView _matchesListingView;

        public MatchesListingViewModel(MatchesListingView matchesListingView)
        {
            _matchesListingView = matchesListingView;
        }


        public static void UpdateList()
        {
            /*ItemsSource =
            MatchesListingViewModel.Matches;*/
        }
    }
}
