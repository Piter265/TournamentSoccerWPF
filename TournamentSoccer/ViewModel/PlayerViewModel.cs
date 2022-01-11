using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;

namespace TournamentSoccer.ViewModel
{
    class PlayerViewModel : ViewModelBase
    {
        private readonly Player _player;


        public string Name => _player.Name;
        public string LastName => _player.LastName;
        public int Age => _player.Age;
        public string Function => _player.Function;
        public int Goals => _player.Goals;
        public int Asists => _player.Asists;
        public int Shots => _player.Shots;
        public int RedCards => _player.RedCards;
        public int YellowCards => _player.YellowCards;

        public PlayerViewModel(Player player)
        {
            _player = player;
        }

        public override string ToString()
        {
            return Name + LastName + Age + Function + Goals + Asists + Shots + RedCards + YellowCards;
        }
    }
}
