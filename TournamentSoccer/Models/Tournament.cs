﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.design_patterns;

namespace TournamentSoccer.Models
{
    public sealed class Tournament
    {
        public string Name { get; set; }
        public bool Rematches { get; set; }
        public List<Match> Matches { get; set; } = new List<Match>();
        public List<Team> Teams { get; set; } = new List<Team>();
        public List<Referee> Referees { get; set; } = new List<Referee>();
        public IRandAlgorithm Algorithm { get; set; }
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


        public List<Match> DrawMatches()
        {
            List<Match> matches = new List<Match>();
            if (Rematches)
            {
                Algorithm = new RandAlgorithmWithRematches();
            }
            else
            {
                Algorithm = new RandAlgorithmWithoutRematches();
            }

            Algorithm.DrawMatches(Teams);

            return matches;
        }

        public void AddTeam(Team team)
        {
            Teams.Add(team);
        }

        public void DeleteTeam(Team team)
        {
            Teams.Remove(team);
        }

        public void LoadRefeeres()
        {

        }
    }
}