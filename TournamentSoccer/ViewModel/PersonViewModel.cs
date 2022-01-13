using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;

namespace TournamentSoccer.ViewModel
{
    public class PersonViewModel : ViewModelBase
    {
        private readonly Person _person;

        public string PersonName => _person.Name;
        public string PersonLastName => _person.LastName;
        public int PersonAge => _person.Age;
        public string PersonFunction => _person.Function;

        public PersonViewModel(Person person)
        {
            _person = person;
        }
    }
}
