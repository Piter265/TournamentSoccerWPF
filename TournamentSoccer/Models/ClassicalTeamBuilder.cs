using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentSoccer.Models
{
    public class ClassicalTeamBuilder : ITeamBuilder
    {

        private Coach _coach = new Coach();
        private LinkedList<Person> _players = new LinkedList<Person>();

        public ClassicalTeamBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._coach = new Coach();
            this._players = new LinkedList<Person>();
        }

        public void AddCoach()
        {
            _coach = new Coach(CreateCoach());
            _players.AddFirst(CreatePlayer());
        }

        public void AddPlayers()
        {
            _players.AddFirst(CreatePlayer());
        }

        public Coach CreateCoach()
        {
            throw new NotImplementedException();
        }

        public Person CreatePlayer()
        {
            throw new NotImplementedException();
        }

        public void SetDisability(string disability)
        {
            throw new NotImplementedException();
        }

        public void SetGroupAge(int age)
        {
            throw new NotImplementedException();
        }

        public void SetName(string name)
        {
            throw new NotImplementedException();
        }


        public Coach GetCoach()
        {
            Coach result = this._coach;
            LinkedList<Person> players = _players;//return
            this.Reset();

            return result;
        }

    }
}
