using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentSoccer.Models
{
    class TeamDirector
    {
        private ITeamBuilder _builder;

        public ITeamBuilder TeamBuilder
        {
            set { _builder = value; }
        }

        public void BuildClassicalTeam()
        {
            this._builder.AddCoach();
            this._builder.AddPlayers();
        }

        public void BuildUniqueTeam()
        {
            this._builder.AddCoach();
            this._builder.AddPlayers();
        }
    }
}
