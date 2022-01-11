using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;

namespace TournamentSoccer.ViewModel
{
    class TeamsListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<TeamViewModel> _teams;

        public IEnumerable<TeamViewModel> Teams => _teams;

        public TeamsListingViewModel(Tournament tournament)
        {
            _teams = new ObservableCollection<TeamViewModel>();

            //_teams.Add(new TeamViewModel(new Models.Team("Jaga", 1, 2, 3)));
        }

    }
}