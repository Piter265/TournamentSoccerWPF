using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;

namespace TournamentSoccer
{
    interface IRandAlgorithm
    {
        IRandAlgorithm DrawMatches(List<Club> clubs);
    }
}
