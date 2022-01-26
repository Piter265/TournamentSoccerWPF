using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;

namespace TournamentSoccer.FileHandlers
{
    class DataFromJSON
    {
        public List<Match> Matches { get; set; } = new List<Match>();
        public List<Team> Teams { get; set; } = new List<Team>();
        public List<Referee> Referees { get; set; } = new List<Referee>();
        public List<Stadium> Stadiums { get; set; } = new List<Stadium>();

    }
}