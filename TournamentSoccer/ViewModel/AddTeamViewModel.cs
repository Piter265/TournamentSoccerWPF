using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TournamentSoccer.Commands;
using TournamentSoccer.Models;

namespace TournamentSoccer.ViewModel
{
    class AddTeamViewModel : ViewModelBase
    {
        private ObservableCollection<PersonViewModel> _people { get; set; }
        
        public PersonViewModel SelectedPerson { get; set; }

        public IEnumerable<PersonViewModel> People => _people;

        public ICommand SubmitCommand { get; }
        public ICommand AddToTeam { get; }
        public ICommand UpdateInTeam { get; }
        public ICommand DeleteFromTeam { get; }
        public ICommand PlayerType { get; set; }
        public ICommand CoachType { get; set; }


        public AddTeamViewModel(Tournament tournament)
        {
            _people = new ObservableCollection<PersonViewModel>();
            SubmitCommand = new AddTeamCommand(this, tournament);
            AddToTeam = new AddToTeamCommand(this, tournament);
            DeleteFromTeam = new DeleteFromTeamCommand(this, tournament);
        }

        private string _teamName;
        private string _personName;
        private string _personLastName;
        private string _personFunction;
        private int _personAge;
        private string _personType;


        public string TeamName
        {
            get
            {
                return _teamName;
            }
            set
            {
                _teamName = value;
                OnPropertyChanged(nameof(TeamName));
            }
        }


        public string PersonName
        {
            get
            {
                return _personName;
            }
            set
            {
                _personName = value;
                OnPropertyChanged(nameof(PersonName));
            }
        }


        public string PersonLastName
        {
            get
            {
                return _personLastName;
            }
            set
            {
                _personLastName = value;
                OnPropertyChanged(nameof(PersonLastName));
            }
        }


        public string PersonFunction
        {
            get
            {
                return _personFunction;
            }
            set
            {
                _personFunction = value;
                OnPropertyChanged(nameof(PersonFunction));
            }
        }


        public int PersonAge
        {
            get
            {
                return _personAge;
            }
            set
            {
                _personAge = value;
                OnPropertyChanged(nameof(PersonAge));
            }
        }

        /*
        public string PersonType
        {
            get
            {
                return _personType;
            }
            set
            {
                _personType = value;
                OnPropertyChanged(nameof(PersonType));
            }
        }*/

        public void Add(Person person)
        {
            _people.Add(new PersonViewModel(person));
        }

        public void Delete(PersonViewModel person)
        {
            _people.Remove(person);
        }
    }
}
