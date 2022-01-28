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
        public Coach Coach { get; }

        public string Name => Coach.Name;
        public string LastName => Coach.LastName;
        public int Age => Coach.Age;
        public string Function => Coach.Function;

        public CoachViewModel(Coach coach)
        {
            Coach = coach;
        }
    }
}
