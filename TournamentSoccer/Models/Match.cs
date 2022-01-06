using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace TournamentSoccer.Models
{
    class Match : MatchBase
    {
        public Match(int goals, int assists, int shots, int shotsOnTarget, int yellowCards, int redCards) 
            : base(goals, assists, shots, shotsOnTarget, yellowCards, redCards)
        {

        }

        public Match MakeRematch(Match match1)
        {
            Match match2 = (Match)match1.clone();


            // Swaping squads
            List<Player>  tmpSquad1 = new List<Player>();
            Squad2.ForEach(p => tmpSquad1.Add(p));

            List<Player> tmpSquad2 = new List<Player>();
            Squad2.ForEach(p => tmpSquad1.Add(p));

            Squad2.Clear();
            tmpSquad1.ForEach(p => Squad2.Add(p));

            Squad1.Clear();
            tmpSquad2.ForEach(p => Squad1.Add(p));


            return match2;
        }

    }
}
