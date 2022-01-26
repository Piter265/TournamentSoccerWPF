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
    public class Match
    {

        public string Goals { get; set; } = "0-0";
        public string Assists { get; set; } = "0-0";
        public string Shots { get; set; } = "0-0";
        public string ShotsOnTarget { get; set; } = "0-0";
        public string YellowCards { get; set; } = "0-0";
        public string RedCards { get; set; } = "0-0";


        public Referee Referee { get; set; }

        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Stadium Stadium { get; set; }


        public Match(Team team1, Team team2, Referee referee, Stadium stadium)
        {
            Team1 = team1;
            Team2 = team2;
            Referee = referee;
            Stadium = stadium;
        }

    }
}