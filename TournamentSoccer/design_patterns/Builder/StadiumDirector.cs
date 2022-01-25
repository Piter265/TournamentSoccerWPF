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

        public void BuildMatchStadium(string name, string city, int quantity)
        {
            this._builder.SetName(name);
            this._builder.SetTribuneSize(quantity);
            this._builder.SetCity(city);
            this._builder.SetTypeTurf();
            this._builder.SetRoof();
            this._builder.SetSize();
        }

        public void BuildTrainingStadium(string name, string city, int quantity)
        {
            this._builder.SetName(name);
            this._builder.SetTribuneSize(quantity);
            this._builder.SetCity(city);
            this._builder.SetTypeTurf();
            this._builder.SetRoof();
            this._builder.SetSize();
        }
    }
}
