using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TournamentSoccer.Commands;
using TournamentSoccer.Models;

namespace TournamentSoccer.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private Tournament _tournament = Tournament.GetInstance();

        public ICommand SaveTournamentCommand { get; }
        public ICommand SimulateMatchesCommand { get; }

        public MainViewModel()
        {
            SaveTournamentCommand = new SaveTournamentCommand(_tournament);
            SimulateMatchesCommand = new SimulateMatchesCommand(_tournament);
        }
    }
}
