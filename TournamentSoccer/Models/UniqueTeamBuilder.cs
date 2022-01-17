using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentSoccer.Models
{
    public class UniqueTeamBuilder : ITeamBuilder
    {
        private LinkedList<Person> _people = new LinkedList<Person>();

        public UniqueTeamBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._people = new LinkedList<Person>();
        }

        public void AddCoach()
        {
            _people.AddFirst(CreatePlayer());
        }

        public void AddPlayer()
        {
            _people.AddFirst(CreatePlayer());
        }

        public Coach CreateCoach()
        {
            throw new NotImplementedException();
        }

        public Person CreatePlayer()
        {
            throw new NotImplementedException();
        }

        public void SetName(string name)
        {
            throw new NotImplementedException();
        }


        public bool SetDisability(bool isDisable)
        {
            throw new NotImplementedException();
        }

        public void SetGroupAge(string groupAge)
        {
            throw new NotImplementedException();
        }
    }
}
