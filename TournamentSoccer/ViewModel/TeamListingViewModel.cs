using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;

namespace TournamentSoccer.ViewModel
{
    public class TeamsListingViewModel : ViewModelBase
    {
        public static List<Team> Teams;

        public TeamsListingViewModel()
        {
            Teams = getTeamsFromMatches(updateStatsInTeams(MatchesListingViewModel.Matches));
            Teams = getSortedTeams(Teams);
        }


        private List<Match> updateStatsInTeams(List<Match> matches)
        {
            matches.ForEach(match =>
            {
                changeTeamStats(match);
            });
            return matches;
        }

        private void changeTeamStats(Match match)
        {
            string[] goals;

            goals = match.Goals.Split("-");
            string[] balanceTeam1 = match.Team1.Balance.Split("-");
            string[] balanceTeam2 = match.Team2.Balance.Split("-");
            if (Convert.ToInt32(goals[0]) > Convert.ToInt32(goals[1]))
            {
                match.Team1.Points += 3;
                match.Team1.Wins += 1;
                match.Team2.Losses += 1;
            }
            else if (Convert.ToInt32(goals[0]) < Convert.ToInt32(goals[1]))
            {
                match.Team2.Points += 3;
                match.Team2.Wins += 1;
                match.Team1.Losses += 1;
            }
            else
            {
                match.Team1.Points += 1;
                match.Team2.Points += 1;
                match.Team1.Draws += 1;
                match.Team2.Draws += 1;
            }
            match.Team1.Balance = Convert.ToInt32(balanceTeam1[0]) + Convert.ToInt32(goals[0])
                    + "-" + Convert.ToInt32(balanceTeam1[1]) + Convert.ToInt32(goals[1]);

            match.Team2.Balance = Convert.ToInt32(balanceTeam2[0]) + Convert.ToInt32(goals[1])
                    + "-" + Convert.ToInt32(balanceTeam2[1]) + Convert.ToInt32(goals[0]);
        }

        private List<Team> getTeamsFromMatches(List <Match> matches)
        {
            HashSet<Team> teams = new HashSet<Team>();
            matches.ForEach(match =>
            {
                teams.Add(match.Team1);
                teams.Add(match.Team2);
            });

            return teams.ToList();
        }

        private List<Team> getSortedTeams(List <Team> teams)
        {
            return teams.OrderBy(team => team.Points).ToList();
        }
    }
}