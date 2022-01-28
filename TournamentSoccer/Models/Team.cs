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
        public int Points { get; set; }
        public string Balance { get; set; } = "0-0";
        public List<Person> People { get; set; }

        public Team()
        {

        }
        public Team(string name, List<Person> people)
        {
            Name = name;
            People = new List<Person>(people);
        }

        public Team(Team team)
        {
            this.Name = team.Name;
            this.People = new List<Person>(team.People);
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Team p = (Team)obj;
                return (Name.Equals(p.Name));
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
