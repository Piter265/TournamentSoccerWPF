using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentSoccer.Models
{
    class Match
    {
        public int Goals { get; set; }
        public int Assists { get; set; }
        public int Shots { get; set; }
        public int ShotsOnTarget { get; set; }
        public int YellowCards { get; set; }
        public int RedCards { get; set; }

        private List<Player> Squad1;
        private List<Player> Squad2;


        public Match(int goals, int assists, int shots, int shotsOnTarget, int yellowCards, int redCards)
        {
            Goals = goals;
            Assists = assists;
            Shots = shots;
            ShotsOnTarget = shotsOnTarget;
            YellowCards = yellowCards;
            RedCards = redCards;
            Squad1 = new List<Player>();
            Squad2 = new List<Player>();

        }
    }
}
