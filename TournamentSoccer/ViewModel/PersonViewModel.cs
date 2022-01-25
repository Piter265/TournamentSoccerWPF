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
        public Person Person { get; }

        public string PersonName => Person.Name;
        public string PersonLastName => Person.LastName;
        public int PersonAge => Person.Age;
        public string PersonFunction => Person.Function;

        public PersonViewModel(Person person)
        {
            Person = person;
        }
    }
}
