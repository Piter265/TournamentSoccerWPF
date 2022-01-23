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
    class LoadFormFile
    {
        protected Tournament _tournament;

        public LoadFormFile(Tournament tournament)
        {
            _tournament = tournament;
        }

        public bool LoadData()
        {
            string fileName = "tournament.json";

            // check is there file to load
            if(!System.IO.File.Exists(fileName))
            {
                MessageBox.Show("No Tournament to load");
                return false;
            }
           
            string jsonString = File.ReadAllText(fileName);
            _tournament = JsonSerializer.Deserialize<Tournament>(jsonString);

            return true;
        }
    }
}
