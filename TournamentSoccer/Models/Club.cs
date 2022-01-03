using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentSoccer.Models
{
    class Club
    {
        public string Name;
        public int Wins;
        public int Losses;
        public int Draws;
        private List<Player> Players;

        public Club(string name, int wins, int losses, int draws)
        {
            Name = name;
            Wins = wins;
            Losses = losses;
            Draws = draws;
            Players = new List<Player>();
        }

        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }
    }
}
