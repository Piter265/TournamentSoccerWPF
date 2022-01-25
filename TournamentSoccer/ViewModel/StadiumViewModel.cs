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
        public Stadium Stadium { get; }

        public string StadiumName => Stadium.Name;
        public string StadiumCity => Stadium.City;
        public int StadiumTribuneSize => Stadium.TribuneSize;
        public string StadiumSize => Stadium.StadiumSize;


        public StadiumViewModel(Stadium stadium)
        {
            Stadium = stadium;
        }
    }
}
