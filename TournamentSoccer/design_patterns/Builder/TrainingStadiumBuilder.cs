using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;

namespace TournamentSoccer.design_patterns.Builder
{
    public class TrainingStadiumBuilder : IStadiumBuilder
    {
        private Stadium _stadium;

        public TrainingStadiumBuilder()
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
            _stadium.TurfType = "Unnatural";
        }

        public void SetRoof()
        {
            _stadium.OpenedRoof = true;
        }

        public void SetSize()
        {
            _stadium.StadiumSize = "62x30m";
        }

        public Stadium GetStadium()
        {
            return _stadium;
        }

    }
}
