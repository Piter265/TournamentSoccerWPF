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
        public void AddPlayer();

        public bool SetDisability(bool isDisable);
        public void SetAgeGroup(string groupAge);
    }
}
