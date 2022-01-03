using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;

namespace TournamentSoccer.ViewModel
{
    class ClubViewModel
    {
        private readonly Club _club;

        public string Name => _club.Name;
        public int Wins => _club.Wins;
        public int Losses => _club.Losses;
        public int Draws => _club.Draws;

        public ClubViewModel(Club club)
        {
            _club = club;
        }
    }
}