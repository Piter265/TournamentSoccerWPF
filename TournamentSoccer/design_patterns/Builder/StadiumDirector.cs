using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentSoccer.design_patterns.Builder
{
    public class StadiumDirector
    {
        private IStadiumBuilder _builder;

        public IStadiumBuilder Builder
        {
            set { _builder = value; }
        }

        public void BuildMatchStadium(string name, string city)
        {
            this._builder.SetName(name);
            this._builder.SetTribune();
            this._builder.SetCity(city);
            this._builder.SetNaturalTurf();
            this._builder.SetClosedRoof();
        }

        public void BuildTrainingStadium(string name, string city)
        {
            this._builder.SetName(name);
            this._builder.SetCity(city);
            this._builder.SetUnnaturalTurf();
            this._builder.SetOpenedRoof();
        }
    }
}
