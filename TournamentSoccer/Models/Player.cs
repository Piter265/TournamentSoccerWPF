using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentSoccer.Models
{
    public class Player : Person
    {
        public Player()
        {

        }


        public Player(string name, string lastName, string function, int age) : base(name, lastName, function, age)
        {

        }

        public override Person clone()
        {
            return (Player)this.MemberwiseClone();
        }
    }
}
