using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentSoccer.Models
{
    public class TeamDirector
    {
        private ITeamBuilder _builder;

        public ITeamBuilder TeamBuilder
        {
            set { _builder = value; }
        }

        public void BuildClassicalTeam(string name, List<Person> people)
        {
            this._builder.SetName(name);
            this._builder.AddPlayersAndCoaches(people);
            this._builder.SetDisability();
        }

        public void BuildUniqueTeam(string name, List<Person> people)
        {
            this._builder.SetName(name);
            this._builder.AddPlayersAndCoaches(people);
            this._builder.SetDisability();
        }
    }
}
