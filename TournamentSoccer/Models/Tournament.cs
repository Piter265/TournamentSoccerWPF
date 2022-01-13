using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentSoccer.Models
{
    public sealed class Tournament
    {
        public readonly string Name;
        public readonly bool Rematches;
        public static List<Match> Matches { get; set; } = new List<Match>();
        public static List<Team> Teams { get; set; } = new List<Team>();
        public static List<Referee> Referees { get; set; } = new List<Referee>();
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


        public static List<Match>DrawMatches(List<Team> clubs)
        {
            List<Match> matches = new List<Match>();

            return matches;
        }

        public static void AddTeam(Team team)
        {
            Teams.Add(team);
        }

        public static void DeleteTeam(Team team)
        {
            Teams.Remove(team);
        }

        public static void LoadRefeeres()
        {

        }
    }
}
