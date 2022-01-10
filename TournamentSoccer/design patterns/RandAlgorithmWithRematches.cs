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


        public List<Match> DrawMatches(List<Club> clubs)
        {
            List<Match> matches = new List<Match>();



            return matches;
        }

        public IRandAlgorithm DrawMatches(List<Club> clubs)
        {
            throw new NotImplementedException();
        }
    }
}
