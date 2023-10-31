using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Service
{
    public static class Extention 
    {
        public static int Factorial(this int num)
        {
            int factorial = 1;

            if (num < 0)
            {
               return 1;
            }

            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        public static bool CheckEmail(this string text, string pattern)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return false;
            }

           
            var regex = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            return regex.IsMatch(text);
        }
    
    
        public static bool HasSpaceInMiddle(this string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }
            int middleIndex = email.Length / 2;
            return email[middleIndex] == ' ';
        }
    }

}


