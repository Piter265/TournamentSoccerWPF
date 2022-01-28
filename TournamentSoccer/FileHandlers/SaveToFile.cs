using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;
using System.Text.Json;
using System.IO;
using Newtonsoft.Json;

namespace TournamentSoccer.FilesHandlers
{
    public class SavetoFile
    {
        private Tournament _tournament;

        public SavetoFile(Tournament tournament)
        {
            _tournament = tournament;
        }

        public void SaveData()
        {
            string fileName = "tournament.json";
            File.WriteAllText(fileName, JsonConvert.SerializeObject(_tournament));

            //string fileName = "tournament.json";
            //using FileStream createStream = File.Create(fileName);
            ////await JsonSerializer.SerializeAsync(createStream, _tournament);
            //await createStream.DisposeAsync();


        }
    }
}