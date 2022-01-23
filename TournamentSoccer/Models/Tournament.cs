using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.design_patterns;
using TournamentSoccer.FilesHandlers;

namespace TournamentSoccer.Models
{
    public sealed class Tournament
    {
        public string Name { get; set; }
        public List<Match> Matches { get; set; } = new List<Match>();
        public List<Team> Teams { get; set; } = new List<Team>();
        public List<Referee> Referees { get; set; } = new List<Referee>();
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
            return algorithm.DrawMatches(Teams);
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
            //klasa wczytujaca za fasada
        }

        public bool LoadTournamentFromFile()
        {
            LoadFormFile loadFromFile = new LoadFormFile(_instance);

            // if false there is no file to load
            if(!loadFromFile.LoadData())
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
    }
}