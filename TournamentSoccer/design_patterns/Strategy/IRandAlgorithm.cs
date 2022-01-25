using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;

namespace TournamentSoccer
{
    public interface IRandAlgorithm
    {
        List<Match> DrawMatches(List<Team> teams, List<Referee> referees, List<Stadium> stadiums);
    }
}