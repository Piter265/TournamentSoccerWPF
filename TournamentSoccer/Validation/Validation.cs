using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TournamentSoccer.Validation
{
    public static class Validation
    {
        public static string ChangeFirstLetterToUpper(string word)
        {
            if (word.Length > 0)
            {
                return word[0].ToString().ToUpper() + word.Substring(1).ToLower();
            }
            return "";
        }

        public static int ChangeToAppriopriateAge(int age)
        {
            if (age > 50) return 50;
            return age;
        }

        public static bool CheckIfWordContainsNumbers(string word)
        {
            return word.Any(char.IsDigit);
        }

        public static bool CheckIfNumberContainsLetters(int number)
        {
            return Regex.IsMatch(number.ToString(), "[a-zA-Z]");
        }
    }
}
