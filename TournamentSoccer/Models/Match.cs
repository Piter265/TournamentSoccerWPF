using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentSoccer.Models
{
    public class Match : MatchBase
    {
        public Match(Team team1, Team team2, Referee referee) : base(team1, team2, referee)
        {

        } 
    }
}
