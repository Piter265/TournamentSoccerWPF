using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TournamentSoccer.Models
{
    public class Referee : Person
    {
        [JsonConstructor]
        public Referee()
        {

        }


        public Referee(string name, string lastName, string function, int age) : base(name, lastName, function, age)
        {
            this.Name = Name;
            this.LastName = LastName;
            this.Age = Age;
            this.Function = Function;
        }

        public Referee(Referee referee)
        {
            this.Name = referee.Name;
            this.LastName = referee.LastName;
            this.Age = referee.Age;
            this.Function = referee.Function;
        }


    }

        //public override Person clone()
        //{
        //    return (Referee)this.MemberwiseClone();

        //}

        //public override string ToString()
        //{
        //    return Name + " " + LastName;
        //}
    
}