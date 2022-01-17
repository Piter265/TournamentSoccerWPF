using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentSoccer.Models
{
    public interface ITeamBuilder
    {
        public void SetName(string name);
        public void AddPlayersAndCoaches(List<Person> people);

        public void SetDisability();
        public void SetGroupAge();
    }
}
