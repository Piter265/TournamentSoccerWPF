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
    public class Match : MatchBase
    {


        public Match(Team team1, Team team2, Referee referee) : base(team1, team2, referee)
        {

        }



        public Match MakeRematch(Match match1)
        {
            Match match2 = (Match)match1.clone();

            //List<Person> squad1 = new List<Person>(match2.Squad2);
            //List<Person> squad2 = new List<Person>(match2.Squad1);

            // Swaping squads
            List<Person>  tmpSquad1 = new List<Person>();
            Team2.People.ForEach(p => tmpSquad1.Add(p));

            List<Person> tmpSquad2 = new List<Person>();
            Team1.People.ForEach(p => tmpSquad2.Add(p));

            Team2.People.Clear();
            tmpSquad1.ForEach(p => Team2.People.Add(p));

            Team1.People.Clear();
            tmpSquad2.ForEach(p => Team1.People.Add(p));


            return match2;
        }

    }
}
