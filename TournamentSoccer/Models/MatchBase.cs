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

        public List<Person> Squad1;
        public List<Person> Squad2;


        public MatchBase(int goals, int assists, int shots, int shotsOnTarget, int yellowCards, int redCards)
        {
            Goals = goals;
            Assists = assists;
            Shots = shots;
            ShotsOnTarget = shotsOnTarget;
            YellowCards = yellowCards;
            RedCards = redCards;
            Squad1 = new List<Person>();
            Squad2 = new List<Person>();

        }

        public IMatchBase clone()
        {
            return (MatchBase)this.MemberwiseClone();
        }
    }
}
