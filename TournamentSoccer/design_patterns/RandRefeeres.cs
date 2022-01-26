using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TournamentSoccer.Models;

namespace TournamentSoccer.design_patterns
{
    enum NamesEnum
    {
        Jack,
        Mark,
        Peter,
        Lucas
    }

    enum LastanamesEnum
    {
        White,
        Black,
        Solar,
        Adi,
        Wood
    }

    enum FunctionsEnum
    {
        Main,
        Line,
        VAR
    }

    public class RandReferees
    {
        private static string[] Names = Enum.GetValues(typeof(NamesEnum))
             .Cast<NamesEnum>()
             .Select(x => x.ToString())
             .ToArray();

        private static string[] Lastanames = Enum.GetValues(typeof(LastanamesEnum))
         .Cast<LastanamesEnum>()
         .Select(x => x.ToString())
         .ToArray();


        private static string[] Functions = Enum.GetValues(typeof(FunctionsEnum))
        .Cast<FunctionsEnum>()
        .Select(x => x.ToString())
        .ToArray();


        public RandReferees()
        {

        }

        public static List<Referee> drawReferees()
        {
            List<Referee> referees = new List<Referee>();


            Person baseRef = new Referee("A", "B", "C", 31);

            // Draw 10 referes
            for (int i = 1; i <= 10; i++)
            {
                Random rand = new Random();

                Referee referee = (Referee)baseRef.clone();
                int randNum;

                randNum = rand.Next(0, Names.Length);
                referee.Name = Names[randNum];

                randNum = rand.Next(0, Lastanames.Length);
                referee.LastName = Lastanames[randNum];

                randNum = rand.Next(0, Functions.Length);
                referee.Function = Functions[randNum];

                randNum = rand.Next(18, 65);
                referee.Age = randNum;

                referees.Add(referee);

            }


            return referees;
        }
    }
}