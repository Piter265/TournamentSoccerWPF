using B_Validation_ByDataErrorInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TournamentSoccer.Others
{
    public class MatchesListValidation : ObservableObject, IDataErrorInfo
    {
        private string goals;
        public string Error { get { return null; } }

        public string this[string goals]
        {
            get
            {
                string result = null;
                Regex rx = new Regex(@"[0-9]+[-][0-9]+");
                Match con = rx.Match(goals);

                switch (goals)
                {
                    case "Goals":
                        {
                            if (!con.Success)
                            {
                                result = "Goal shoul look: eg. 3-2";
                            }
                        }
                        break;
                }

                return result;
            }
        }


        public string Goals
        {
            get {return goals; }
            set
            {
                OnPropertyChanged(ref goals, value);
            }
        }
    }
}

