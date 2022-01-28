using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentSoccer.Models
{
    public class Coach : Person
    {
        public Coach()
        {

        }

        public Coach(string name, string lastName, string function, int age) : base(name, lastName, function, age)
        {

        }

        public Coach(Coach coach)
        {
            this.Name = coach.Name;
            this.LastName = coach.LastName;
            this.Age = coach.Age;
            this.Function = coach.Function;
        }

        public override Person clone()
        {
            return (Coach)this.MemberwiseClone();
        }
    }
}
