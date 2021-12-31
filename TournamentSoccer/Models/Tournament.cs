using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentSoccer.Models
{
    sealed class Tournament
    {
        public readonly string Name;
        public readonly bool Rematches;
        private static readonly object _lock = new object();

        private static Tournament _instance;

        private Tournament(string name, bool rematches)
        {
            Name = name;
            Rematches = rematches;
        }

        public static Tournament GetInstance(string name, bool rematches)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Tournament(name, rematches);
                    }
                }
            }

            return _instance;
        }
    }
}
