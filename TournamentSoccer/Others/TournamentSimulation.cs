using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;

namespace TournamentSoccer.Others
{
    public class TournamentSimulation
    {
        public TournamentSimulation()
        {
            
        }

        public static List<Match> SimulateMatches(List<Match> matches)
        {
            Random rand = new Random();

            List<Match> newMatches = new List<Match>(matches);

            newMatches.ForEach(match =>
            {
                int seed = 20;

                int shoots1 = rand.Next(0, seed);
                int shoots2 = rand.Next(0, seed);
                match.Shots = StatsFormatter(shoots1, shoots2);

                int shootsOnTarget1 = rand.Next(0, shoots1);
                int shootsOnTarget2 = rand.Next(0, shoots2);
                match.ShotsOnTarget = StatsFormatter(shootsOnTarget1, shootsOnTarget2);

                int goals1 = rand.Next(0, shootsOnTarget1);
                int goals2 = rand.Next(0, shootsOnTarget2);
                match.Goals = StatsFormatter(goals1, goals2);

                int assists1 = rand.Next(0, goals1);
                int assists2 = rand.Next(0, goals2);
                match.Assists = StatsFormatter(assists1, assists2);

                int yellowCards1 = rand.Next(0, seed / 5);
                int yellowCards2 = rand.Next(0, seed / 5);
                match.YellowCards = StatsFormatter(yellowCards1, yellowCards2);

                int redCards1 = rand.Next(0, seed / 10);
                int redCards2 = rand.Next(0, seed / 10);
                match.RedCards = StatsFormatter(yellowCards1, yellowCards2);

            });

            return newMatches;
        }

        private static string StatsFormatter(int stat1, int stat2)
        {
            return stat1.ToString() + "-" + stat2.ToString();
        }

    }
}