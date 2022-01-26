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
        public ObservableCollection<StadiumViewModel> Stadiums { get; set; }
        public IEnumerable<Referee> Referees => Tournament.GetInstance().Referees;

        private Tournament _tournament = Tournament.GetInstance();

        public TeamViewModel SelectedTeam { get; set; }
        public StadiumViewModel SelectedStadium { get; set; }

        public bool Rematches { get; set; }

        public ICommand DeleteTeamCommand { get; }
        public ICommand DeleteStadiumCommand { get; }

        public ICommand CreateNewTournament { get; }
        public ICommand LoadRefereesCommand { get; }

        public LaunchTournamentViewModel()
        {
            Teams = new ObservableCollection<TeamViewModel>();
            DeleteTeamCommand = new DeleteTeamCommand(this);
            CreateNewTournament = new CreateNewTournamentCommand(this, _tournament);
            Stadiums = new ObservableCollection<StadiumViewModel>();
            DeleteStadiumCommand = new DeleteStadiumCommand(this);
            LoadRefereesCommand = new LoadRefereesCommand(this);
        }

        public void AddTeam(Team team)
        {
            Teams.Add(new TeamViewModel(team));
        }

        public void DeleteTeam(TeamViewModel team)
        {
            Teams.Remove(team);
        }

        public void AddStadium(Stadium stadium)
        {
            Stadiums.Add(new StadiumViewModel(stadium));
        }

        public void DeleteStadium(StadiumViewModel stadium)
        {
            Stadiums.Remove(stadium);
        }

    }
}
