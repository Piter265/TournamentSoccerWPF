using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;

namespace TournamentSoccer.ViewModel
{
    public class StadiumViewModel : ViewModelBase
    {
        private readonly Stadium _stadium;

        public string StadiumName => _stadium.Name;
        public string StadiumCity => _stadium.City;
        public int StadiumTribuneSize => _stadium.TribuneSize;
        public string StadiumSize => _stadium.StadiumSize;


        public StadiumViewModel(Stadium stadium)
        {
            _stadium = stadium;
        }
    }
}
