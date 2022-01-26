using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentSoccer.Models
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Function { get; set; }

        public Person()
        {

        }

        public Person(string name, string lastName, string function, int age)
        {
            Name = name;
            LastName = lastName;
            Function = function;
            Age = age;
        }
        
        public abstract Person clone();
    }
}