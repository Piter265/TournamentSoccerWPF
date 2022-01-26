using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TournamentSoccer.Commands;
using TournamentSoccer.Models;
using static TournamentSoccer.Validation.Validation;

namespace TournamentSoccer.ViewModel
{
    public class AddTeamViewModel : ViewModelBase
    {
        private ObservableCollection<PersonViewModel> _people { get; set; }

        public PersonViewModel SelectedPerson { get; set; }

        public IEnumerable<PersonViewModel> People => _people;
        public bool PlayerType { get; set; }

        public ICommand Submit { get; }
        public ICommand AddToTeam { get; }
        public ICommand DeleteFromTeam { get; }
        public bool Disabilities { get; set; }

        public AddTeamViewModel(LaunchTournamentViewModel launchTournamentViewModel)
        {
            _people = new ObservableCollection<PersonViewModel>();
            Submit = new AddTeamCommand(this, launchTournamentViewModel);
            AddToTeam = new AddToTeamCommand(this);
            DeleteFromTeam = new DeleteFromTeamCommand(this);
        }

        private string _teamName;
        private string _personName;
        private string _personLastName;
        private string _personFunction;
        private int _personAge;

        public string TeamName
        {
            get
            {
                return _teamName;
            }
            set
            {
                _teamName = ChangeFirstLetterToUpper(value);
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
                _personName = ChangeFirstLetterToUpper(value);
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
                _personLastName = ChangeFirstLetterToUpper(value);
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
                _personFunction = ChangeFirstLetterToUpper(value);
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
                _personAge = ChangeToAppriopriateAge(value);
                OnPropertyChanged(nameof(PersonAge));
            }
        }

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

