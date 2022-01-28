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
        private static MatchesListingView _matchesListingView;

        public MatchesListingViewModel(MatchesListingView matchesListingView)
        {
            _matchesListingView = matchesListingView;
        }

        public static void refreshList()
        {
            _matchesListingView.matchesList.Items.Refresh();
        }

        public static void cleanStatsInTeams()
        {
            TeamsListingViewModel.Teams.ForEach(team =>
            {
                resetStatsInTeam(team);
            });
        }

        private static void resetStatsInTeam(Team team)
        {
            team.Wins = 0;
            team.Losses = 0;
            team.Draws = 0;
            team.Points = 0;
            team.Balance = "0-0";
        }
    }
}
