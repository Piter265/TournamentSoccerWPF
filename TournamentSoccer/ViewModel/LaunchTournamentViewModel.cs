using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TournamentSoccer.Commands;
using TournamentSoccer.Models;
using TournamentSoccer.Views;

namespace TournamentSoccer.ViewModel
{
    public class LaunchTournamentViewModel : ViewModelBase
    {
        public ObservableCollection<TeamViewModel> Teams { get; set; }
        public TeamViewModel SelectedTeam { get; set; }
        public bool Disabilities { get; set; }
        public string AgeGroup { get; set; }

        public ICommand DeleteTeam { get; }
        public ICommand CreateNewTournament { get; }

        public LaunchTournamentViewModel()
        {
            Teams = new ObservableCollection<TeamViewModel>();
            DeleteTeam = new DeleteTeamCommand(this);
            CreateNewTournament = new CreateNewTournamentCommand(this); 
        }

        public void Add(Team team)
        {
            Teams.Add(new TeamViewModel(team));
        }

        public void Delete(TeamViewModel team)
        {
            Teams.Remove(team);
        }

    }
}
