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
        public Player Player { get; }


        public string Name => Player.Name;
        public string LastName => Player.LastName;
        public int Age => Player.Age;
        public string Function => Player.Function;

        public PlayerViewModel(Player player)
        {
            Player = player;
        }

        public override string ToString()
        {
            return Name + LastName + Age + Function;
        }
    }
}
