using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;

namespace TournamentSoccer.ViewModel
{
    public class TeamsListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<TeamViewModel> _teams;

        public IEnumerable<TeamViewModel> Teams => _teams;

        public TeamsListingViewModel()
        {
            _teams = new ObservableCollection<TeamViewModel>();
        }

    }
}