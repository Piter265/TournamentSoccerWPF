using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;

namespace TournamentSoccer.ViewModel
{
    public class MatchViewModel
    {
        public Match Match { get; }

        public string TeamName1 => Match.Team1.Name;
        public string TeamName2 => Match.Team2.Name;
        public string Goals => Match.Goals;
        public string Asists => Match.Assists;
        public string Shots => Match.Shots;
        public string ShotsOnTarget => Match.ShotsOnTarget;
        public string YellowCards => Match.YellowCards;
        public string RedCards => Match.RedCards;
        public string RefereeName => Match.Referee.Name + " " + Match.Referee.LastName;
        public string StadiumName => Match.Stadium.Name;

        public MatchViewModel(Match match)
        {
            Match = match;
        }
    }
}
