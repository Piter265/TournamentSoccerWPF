using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentSoccer.Models
{
    public class Team
    {
        public string Name { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }
        public List<Person> People { get; set; }
        public bool Disability { get; set; }

        public Team()
        {

        }

        public Team(Team team)
        {
            this.Name = Name;
            this.People = team.People;
        }
    }
}
