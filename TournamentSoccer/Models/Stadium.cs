using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentSoccer.Models
{
    public class Stadium
    {
        public string Name { get; set; }
        public string City { get; set; }
        public int TribuneSize { get; set; }
        public string TurfType { get; set; }
        public string StadiumSize { get; set; }
        public bool OpenedRoof { get; set; } = true;

        public Stadium()
        {

        }

        public Stadium(Stadium stadium)
        {
            Name = stadium.Name;
            City = stadium.City;
        }
    }
}
