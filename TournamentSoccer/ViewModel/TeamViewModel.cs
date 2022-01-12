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

        public string Name => _team.Name;
        public int Wins => _team.Wins;
        public int Losses => _team.Losses;
        public int Draws => _team.Draws;
        public List<Person> People => _team.People;

        public TeamViewModel(Team team)
        {
            _team = team;
        }
    }
}