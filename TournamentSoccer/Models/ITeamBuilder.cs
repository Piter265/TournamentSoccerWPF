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
        public Coach CreateCoach();
        public Person CreatePlayer();
        public void AddCoach();
        public void AddPlayers();

        public void SetDisability(string disability);
        public void SetGroupAge(int age);
    }
}
