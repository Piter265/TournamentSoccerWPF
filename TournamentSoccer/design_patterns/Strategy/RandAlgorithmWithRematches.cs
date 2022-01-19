using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;

namespace TournamentSoccer.design_patterns
{
    class RandAlgorithmWithRematches : IRandAlgorithm
    {


        public List<Match> DrawMatches(List<Team> teams)
        {
            List<Match> matches = new List<Match>();
            List<Team> teamsToDraw = new List<Team>();

            // Creating objeacts of teams with flag "drawed" which tell if team has been drawed already
            teams.ForEach(t =>
            {
                Team team = t;
                teamsToDraw.Add(team);
                //Match newMatch = new Match(0, 0, 0, 0, 0, 0);
                //matches.Add(newMatch);
            });


            // Get Reffere (Mockup)
            var referee = new Referee("a", "b", "c", 43);


            // Drawing matches
            while (teamsToDraw.Count > 0)
            {
                Random rand = new Random();

                int firstTeamNum = rand.Next(0, teamsToDraw.Count);
                int secondTeamNum = -1;

                do
                {
                    secondTeamNum = rand.Next(0, teamsToDraw.Count);
                } while (firstTeamNum == secondTeamNum);

                var firstTeam = teamsToDraw.ElementAt(firstTeamNum);
                var secondTeam = teamsToDraw.ElementAt(secondTeamNum);

                Match match = new Match(teamsToDraw.ElementAt(firstTeamNum), teamsToDraw.ElementAt(secondTeamNum), referee);
                Match rematch = match.MakeRematch(match);

                matches.Add(match);
                matches.Add(rematch);


                teamsToDraw.Remove(firstTeam);
                teamsToDraw.Remove(secondTeam);

            }



            return matches;

        }
    }
}