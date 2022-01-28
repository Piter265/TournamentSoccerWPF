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
        public Team Team { get; }

        public string TeamName => Team.Name;
        public int TeamWins => Team.Wins;
        public int TeamLosses => Team.Losses;
        public int TeamDraws => Team.Draws;
        public int PlayersQuantity => Team.People.Where(person => person is Player).Count();
        public int CoachQuantity => Team.People.Where(person => person is Coach).Count();

        public List<Person> People => Team.People;

        public TeamViewModel(Team team)
        {
            Team = team;
        }
    }
}