using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using TournamentSoccer.Models;

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
            _tournament = JsonSerializer.Deserialize<Tournament>(jsonString);

            return true;
        }
    }
}