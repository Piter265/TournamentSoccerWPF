using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;

namespace TournamentSoccer.ViewModel
{
    public class CoachViewModel : ViewModelBase
    {
        private readonly Coach _coach;

        public string Name => _coach.Name;
        public string LastName => _coach.LastName;
        public int Age => _coach.Age;
        public string Function => _coach.Function;

        public CoachViewModel(Coach coach)
        {
            _coach = coach;
        }
    }
}
