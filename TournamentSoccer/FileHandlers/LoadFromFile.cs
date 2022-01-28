using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using TournamentSoccer.FileHandlers;
using TournamentSoccer.Models;
using TournamentSoccer.ViewModel;

namespace TournamentSoccer.FilesHandlers
{
    public class LoadFromFile
    {
        private Tournament _tournament;

        public LoadFromFile(Tournament tournament)
        {
            _tournament = tournament;
        }

        public bool LoadData()
        {
            string fileName = "tournament.json";

            // check is there file to load
            if (!System.IO.File.Exists(fileName))
            {
                MessageBox.Show("No Tournament to load", "Tournament", MessageBoxButton.OK, MessageBoxImage.Information);
                return false;
            }

            string jsonString = File.ReadAllText(fileName);
            DataFromJSON data = JsonConvert.DeserializeObject<DataFromJSON>(jsonString);

            data.Matches.ForEach(d =>
            {
                _tournament.Matches.Add(d);
            });
            MatchesListingViewModel.Matches = _tournament.Matches;

            data.Teams.ForEach(d =>
            {
                _tournament.Teams.Add(d);
            });
            TeamsListingViewModel.Teams = _tournament.Teams;

            data.Referees.ForEach(d =>
            {
                _tournament.Referees.Add(d);
            });

            data.Stadiums.ForEach(d =>
            {
                _tournament.Stadiums.Add(d);
            });

            return true;
        }
    }
}