using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;
using System.Text.Json;
using System.IO;

namespace TournamentSoccer.FilesHandlers
{
    public class SavetoFile
    {
        private Tournament _tournament;

        public SavetoFile(Tournament tournament)
        {
            _tournament = tournament;
        }

        public async void SaveData()
        {
            string fileName = "tournament.json";
            using FileStream createStream = File.Create(fileName);
            await JsonSerializer.SerializeAsync(createStream, _tournament);
            await createStream.DisposeAsync();
        }
    }
}