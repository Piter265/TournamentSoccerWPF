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


        public List<Match> DrawMatches(List<Team> teams, List<Referee> referees, List<Stadium> stadiums)
        {
            List<Match> matches = new List<Match>();
            List<Team> teamsToDraw = new List<Team>();

            // Creating objeacts of teams with flag "drawed" which tell if team has been drawed already
            teams.ForEach(t =>
            {
                Team team = t;
                teamsToDraw.Add(team);
            });


            // Drawing matches with rematches
            teams.ForEach(t1 =>
            {
                teamsToDraw.ForEach(t2 =>
                {
                    if (t1 != t2)
                    {
                        // Get Reffere 
                        Random rand = new Random();
                        int refereeNum = rand.Next(0, referees.Count);
                        Referee referee = referees.ElementAt(refereeNum);

                        //Get Stadium
                        int stadiumNum = rand.Next(0, stadiums.Count);
                        Stadium stadium = stadiums.ElementAt(stadiumNum);

                        Match newMatch = new Match(t1, t2, referee, stadium);
                        matches.Add(newMatch);
                    }
                });

            });

            return matches;

        }
    }
}