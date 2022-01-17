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

        public ICommand DeleteTeam { get; }


        public LaunchTournamentViewModel()
        {
            Teams = new ObservableCollection<TeamViewModel>();
            DeleteTeam = new DeleteTeamCommand(this);
        }

        public void Add(Team team)
        {
            Teams.Add(new TeamViewModel(team));
            Tournament.AddTeam(team);
        }

        public void Delete(TeamViewModel team)
        {
            Teams.Remove(team);
            Tournament.DeleteTeam(new Team(team.TeamName, team.People));
        }

    }
}
