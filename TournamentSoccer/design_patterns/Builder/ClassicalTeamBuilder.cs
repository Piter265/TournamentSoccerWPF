using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentSoccer.Models
{
    public class ClassicalTeamBuilder : ITeamBuilder
    {
        private Team team;
        //private List<Person> _people = new List<Person>();

        public ClassicalTeamBuilder()
        {
            team = new Team(); 
        }

        public void AddPlayersAndCoaches(List <Person> people)
        {
            team.People = people;
        }

        public void SetName(string name)
        {
            team.Name = name;
        }


        public void SetDisability()
        {
            team.Disability = false;
        }


        public void SetGroupAge()
        {
            throw new NotImplementedException();
        }

        public Team GetTeam()
        {
            return team;
        }
    }
}
