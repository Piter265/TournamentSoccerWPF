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
        private readonly Match _match;

        public string TeamName1 => _match.Team1.Name;
        public string TeamName2 => _match.Team2.Name;
        public string Goals => _match.Goals;
        public string Asists => _match.Assists;
        public string Shots => _match.Shots;
        public string ShotsOnTarget => _match.ShotsOnTarget;
        public string YellowCards => _match.YellowCards;
        public string RedCards => _match.RedCards;
        public string RefereeName => _match.Referee.Name + _match.Referee.LastName;

        public MatchViewModel(Match match)
        {
            _match = match;
        }
    }
}
