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
    public class TeamsListingViewModel : ViewModelBase
    {
        public static List<Team> Teams { get; set; } = new List<Team>();
        private static TeamsListingView _teamsListingView;
        public TeamsListingViewModel(TeamsListingView teamsListingView)
        {
            _teamsListingView = teamsListingView;
            //Teams = getTeamsFromMatches(updateStatsInTeams(MatchesListingViewModel.Matches));
            //Teams = getSortedTeams(Teams);
        }

        public static void refreshList()
        {
            _teamsListingView.teamsList.Items.Refresh();
            _teamsListingView.teamsList.ItemsSource = null;
            _teamsListingView.teamsList.ItemsSource = Teams;
        }

        public static void sortTeams()
        {
            Teams = Tournament.GetInstance().Teams;

            updateStatsInTeamsAndGetSortedTeams(MatchesListingViewModel.Matches);
        }

        private static void updateStatsInTeamsAndGetSortedTeams(List<Match> matches)
        {
            matches.ForEach(match =>
            {
                updateTeamStats(match);
            });
            getSortedTeams();
        }

        private static void updateTeamStats(Match match)
        {
            string[] goals;

            goals = match.Goals.Split("-");
            string[] balanceTeam1 = match.Team1.Balance.Split("-");
            string[] balanceTeam2 = match.Team2.Balance.Split("-");
            if (Convert.ToInt32(goals[0]) > Convert.ToInt32(goals[1]))
            {
                Teams.ForEach(team =>
                {
                    if (team.Equals(match.Team1))
                    {
                        team.Points += 3;
                        team.Wins += 1;
                    }
                    else if (team.Equals(match.Team2)) team.Losses += 1;
                });
            }
            else if (Convert.ToInt32(goals[0]) < Convert.ToInt32(goals[1]))
            {
                Teams.ForEach(team =>
                {
                    if (team.Equals(match.Team2))
                    {
                        team.Points += 3;
                        team.Wins += 1;
                    }
                    else if (team.Equals(match.Team1)) team.Losses += 1;
                });
            }
            else
            {
                Teams.ForEach(team =>
                {
                    if (team.Equals(match.Team1))
                    {
                        team.Points += 1;
                        team.Draws += 1;
                    }
                    else if (team.Equals(match.Team2))
                    {
                        team.Draws += 1;
                        team.Points += 1;
                    }
                });
            }

            int team1Scored = Convert.ToInt32(balanceTeam1[0]) + Convert.ToInt32(goals[0]);
            int team1Losed = Convert.ToInt32(balanceTeam1[1]) + Convert.ToInt32(goals[1]);
            match.Team1.Balance = team1Scored + "-" + team1Losed;

            int team2Scored = Convert.ToInt32(balanceTeam2[0]) + Convert.ToInt32(goals[1]);
            int team2Losed = Convert.ToInt32(balanceTeam2[1]) + Convert.ToInt32(goals[0]);
            match.Team2.Balance = team2Scored + "-" + team2Losed;
        }
        /*
        private static List<Team> getSortedTeamsFromMatches(List<Match> matches)
        {
            HashSet<Team> teams = new HashSet<Team>();
            matches.ForEach(match =>
            {
                teams.Add(match.Team1);
                teams.Add(match.Team2);
            });

            return getSortedTeams(teams);
        }*/

        private static void getSortedTeams()
        {
            var teams = Teams.OrderByDescending(team => team.Points)
                .ThenBy(team => Convert.ToInt32(team.Balance.Split("-")[0]))
                .ToList();
            Teams = teams;
        }
    }
}