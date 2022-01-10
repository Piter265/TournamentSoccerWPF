using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentSoccer.Models
{
    sealed class Tournament
    {
        public readonly string Name;
        public readonly bool Rematches;
        public List<Match> Matches { get; set; } = new List<Match>();
        public List<Team> Teams { get; set; } = new List<Team>();
        public List<Coach> Coaches { get; set; } = new List<Coach>();
        private static readonly object _lock = new object();

        private static Tournament _instance;

        private Tournament()
        {

        }

        public static Tournament GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Tournament();
                    }
                }
            }

            return _instance;
        }
    }
}
