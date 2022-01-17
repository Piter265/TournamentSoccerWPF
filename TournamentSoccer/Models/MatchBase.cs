using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentSoccer.Models
{
    public abstract class MatchBase : IMatchBase
    {
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int Shots { get; set; }
        public int ShotsOnTarget { get; set; }
        public int YellowCards { get; set; }
        public int RedCards { get; set; }
        public Person Referee { get; }

        public Team Team1 { get; }
        public Team Team2 { get; }


        public MatchBase(Team team1, Team team2, Referee referee)
        {
            Team1 = team1;
            Team2 = team2;
            Referee = referee;
        }

        public IMatchBase clone()
        {
            return (MatchBase)this.MemberwiseClone();
        }
    }
}
