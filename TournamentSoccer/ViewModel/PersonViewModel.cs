using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;

namespace TournamentSoccer.ViewModel
{
    class PersonViewModel : ViewModelBase
    {
        private readonly Person _person;

        public string Name => _person.Name;
        public string LastName => _person.LastName;
        public int Age => _person.Age;
        public string Function => _person.Function;

        public PersonViewModel(Person person)
        {
            _person = person;
        }


        public override string ToString()
        {
            return Name + LastName + Function + Age;
        }
    }
}
