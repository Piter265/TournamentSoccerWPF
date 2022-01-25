﻿using System;
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

        public string Goals { get; set; }
        public string Assists { get; set; }
        public string Shots { get; set; }
        public string ShotsOnTarget { get; set; }
        public string YellowCards { get; set; }
        public string RedCards { get; set; }


        public Referee Referee { get; set; }

        public Team Team1 { get; set; }
        public Team Team2 { get; set; }


        public Match(Team team1, Team team2, Referee referee)
        {
            Team1 = team1;
            Team2 = team2;
            Referee = referee;
        }



        public Match MakeRematch(Match match1)
        {
            Match match2 = new Match(new Team(Team2), new Team(Team1), match1.Referee);

            return match2;
        }

    }
}