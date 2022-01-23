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

        public void SetClosedRoof()
        {
            
        }

        public void SetName(string name)
        {
            _stadium.Name = name;
        }

        public void SetNaturalTurf()
        {
            
        }

        public void SetOpenedRoof()
        {
            
        }

        public void SetTribune()
        {
            
        }

        public void SetUnnaturalTurf()
        {
            
        }

        public Stadium GetStadium()
        {
            return _stadium;
        }
    }
}
