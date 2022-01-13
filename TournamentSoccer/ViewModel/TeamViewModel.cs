using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;

namespace TournamentSoccer.ViewModel
{
    public class TeamViewModel
    {
        private readonly Team _team;

        public string TeamName => _team.Name;
        public int TeamWins => _team.Wins;
        public int TeamLosses => _team.Losses;
        public int TeamDraws => _team.Draws;
        public List<Person> People => _team.People;

        public TeamViewModel(Team team)
        {
            _team = team;
        }
    }
}