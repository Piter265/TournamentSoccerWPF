using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;

namespace TournamentSoccer.design_patterns
{
    class RandAlgorithmWithoutRematches : IRandAlgorithm
    {
        public List<Match> DrawMatches(List<Team> teams)
        {
            List<Match> matches = new List<Match>();

            teams.ForEach(t =>
            {
                Match newMatch = new Match(0, 0, 0, 0, 0, 0);
                matches.Add(newMatch);
            });

            return matches;
        }
    }
}