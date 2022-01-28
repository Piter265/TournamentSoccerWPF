using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TournamentSoccer.Models
{
    public class Match
    {
        private string _goals = "0-0";
        private string _assists { get; set; } = "0-0";
        private string _shots { get; set; } = "0-0";
        private string _shotsOnTarget { get; set; } = "0-0";
        private string _yellowCards { get; set; } = "0-0";
        private string _redCards { get; set; } = "0-0";


        public Referee Referee { get; set; }

        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Stadium Stadium { get; set; }

        public Match()
        {

        }

        public Match(Team team1, Team team2, Referee referee, Stadium stadium)
        {
            Team1 = team1;
            Team2 = team2;
            Referee = referee;
            Stadium = stadium;
        }


        public string Goals
        {
            get
            {
                return _goals;
            }
            set
            {
                if(!value.Any(x => char.IsLetter(x)))
                {
                    _goals = value;
                }
                else
                {
                    _goals = "0-0";
                }
            }
        }


        public string Assists
        {
            get
            {
                return _assists;
            }
            set
            {
                if (!value.Any(x => char.IsLetter(x)))
                {
                    _assists = value;
                }
                else
                {
                    _assists = "0-0";
                }
            }
        }


        public string Shots
        {
            get
            {
                return _shots;
            }
            set
            {
                if (!value.Any(x => char.IsLetter(x)))
                {
                    _shots = value;
                }
                else
                {
                    _shots = "0-0";
                }
            }
        }


        public string ShotsOnTarget
        {
            get
            {
                return _shotsOnTarget;
            }
            set
            {
                if (!value.Any(x => char.IsLetter(x)))
                {
                    _shotsOnTarget = value;
                }
                else
                {
                    _shotsOnTarget = "0-0";
                }
            }
        }


        public string YellowCards
        {
            get
            {
                return _yellowCards;
            }
            set
            {
                if (!value.Any(x => char.IsLetter(x)))
                {
                    _yellowCards = value;
                }
                else
                {
                    _yellowCards = "0-0";
                }
            }
        }


        public string RedCards
        {
            get
            {
                return _redCards;
            }
            set
            {
                if (!value.Any(x => char.IsLetter(x)))
                {
                    _redCards= value;
                }
                else
                {
                    _redCards = "0-0";
                }
            }
        }
    }
}