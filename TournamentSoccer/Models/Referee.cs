using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentSoccer.Models
{
    public class Referee : Person
    {


        public Referee(string name, string lastName, string function, int age) : base(name, lastName, function, age)
        {

        }

        public Referee(Referee referee)
        {
            this.Name = referee.Name;
            this.LastName = referee.LastName;
            this.Function = referee.Function;
            this.Age = referee.Age;
        }

        public void SetName(string name)
        {
            this.Name = name;
        }
        public string GetName()
        {
            return this.Name;
        }


        public void SetLastNameName(string lastName)
        {
            this.LastName = lastName;
        }
        public string GetLastName()
        {
            return this.Name;
        }

    }
}