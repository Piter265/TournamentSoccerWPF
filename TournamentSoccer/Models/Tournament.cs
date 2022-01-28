﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TournamentSoccer.design_patterns;
using TournamentSoccer.FilesHandlers;
using TournamentSoccer.Others;
using TournamentSoccer.ViewModel;

namespace TournamentSoccer.Models
{
    public sealed class Tournament
    {
        public string Name { get; set; }
        public bool Rematches { get; set; }
        public List<Match> Matches { get; set; } = new List<Match>();
        public List<Team> Teams { get; set; } = new List<Team>();
        public List<Referee> Referees { get; set; } = new List<Referee>();
        public List<Stadium> Stadiums { get; set; } = new List<Stadium>();
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


        public List<Match> DrawMatches(IRandAlgorithm algorithm)
        {
            return algorithm.DrawMatches(Teams, Referees, Stadiums);
        }

        public void AddTeam(Team team)
        {
            Teams.Add(team);
        }

        public void AddStadium(Stadium stadium)
        {
            Stadiums.Add(stadium);
        }

        public void LoadRefeeres()
        {
            Referees = new List<Referee>(RandReferees.DrawReferees());
        }

        public bool LoadTournamentFromFile()
        {
            LoadFromFile loadFromFile = new LoadFromFile(_instance);

            // if false there is no file to load
            if (!loadFromFile.LoadData())
            {
                return false;
            }

            return true;

        }

        public void SaveTournamentToFile()
        {
            SavetoFile savetoFile = new SavetoFile(_instance);
            savetoFile.SaveData();
        }

        public List<Match> SimulateMatches(List <Match> matches)
        {
            return TournamentSimulation.SimulateMatches(matches);
        }
    }
}