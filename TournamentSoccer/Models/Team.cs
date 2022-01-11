using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentSoccer.Models
{
    class Team
    {
        public string Name { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }
        public List<Player> Players { get; set; }

        public Team(string name)
        {
            Name = name;
            Players = new List<Player>();
        }

        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }
    }
}
