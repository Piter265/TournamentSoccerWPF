using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace TournamentSoccer.ViewModel
{
    class LaunchTournamentViewModel : ViewModelBase
    {
        private ObservableCollection<TeamViewModel> _teams;
        public IEnumerable<TeamViewModel> Teams => _teams;

        public ICommand AddTeam { get; }
        public ICommand DeleteTeam { get; }
        public ICommand LoadRefeeres { get; }

        public LaunchTournamentViewModel()
        {
            _teams = new ObservableCollection<TeamViewModel>();
        }

        public void Add()
        {

        }
    }
}
