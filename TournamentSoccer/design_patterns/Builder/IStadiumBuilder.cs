using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentSoccer.design_patterns.Builder
{
    public interface IStadiumBuilder
    {
        public void SetName(string name);
        public void SetTribuneSize(int quantity);
        public void SetCity(string name);
        public void SetTypeTurf();
        public void SetRoof();
        public void SetSize();
    }
}
