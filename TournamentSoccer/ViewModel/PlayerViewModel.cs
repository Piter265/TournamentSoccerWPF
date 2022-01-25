using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;

namespace TournamentSoccer.ViewModel
{
    public class PlayerViewModel : ViewModelBase
    {
        private readonly Player _player;


        public string Name => _player.Name;
        public string LastName => _player.LastName;
        public int Age => _player.Age;
        public string Function => _player.Function;

        public PlayerViewModel(Player player)
        {
            _player = player;
        }

        public override string ToString()
        {
            return Name + LastName + Age + Function;
        }
    }
}
