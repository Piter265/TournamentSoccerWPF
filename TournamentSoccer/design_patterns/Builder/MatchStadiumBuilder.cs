using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;

namespace TournamentSoccer.design_patterns.Builder
{
    public class MatchStadiumBuilder : IStadiumBuilder
    {
        private Stadium _stadium;

        public MatchStadiumBuilder()
        {
            _stadium = new Stadium();
        }

        public void SetCity(string city)
        {
            _stadium.City = city;
        }

        public void SetName(string name)
        {
            _stadium.Name = name;
        }

        public void SetTribune(int quantity)
        {
            _stadium.TribuneSize = quantity;
        }

        public void SetTypeTurf()
        {
            _stadium.TurfType = "Natural";
        }

        public void SetRoof()
        {
            _stadium.OpenedRoof = false;
        }

        public void SetSize()
        {
            _stadium.StadiumSize = "105x68m";
        }

        public Stadium GetStadium()
        {
            return _stadium;
        }

    }
}
