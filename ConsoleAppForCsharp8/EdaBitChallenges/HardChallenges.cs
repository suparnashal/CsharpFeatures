using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleAppForCsharp8.EdaBitChallenges
{
    public class HardChallenges
    {
        public static void ConvertTime(string time)
        {
            DateTime givenDate = DateTime.Parse(time);

            if(Regex.IsMatch(time,"[am]|[pm]"))
            Console.WriteLine(givenDate.ToString("H:mm"));
            else
                Console.WriteLine(givenDate.ToString("h:mm tt").ToLower());
        }

        public static void DuplicateCount(string str)
        {
           Console.WriteLine(str.ToCharArray().GroupBy(x => x).Count(y=>y.Count()>1));
        }
        
        public static bool Brackets(string str)
        {
            int countOfBrackets = 0;

            foreach(char c in str)
            {
                if (c.Equals('(') || c.Equals(')'))
                {
                    if (c.Equals('('))
                        countOfBrackets++;
                    else
                        if (countOfBrackets > 0)
                    { countOfBrackets--; }
                    else
                    {
                        countOfBrackets = -1; break;
                    }
                }
            }
            return ((countOfBrackets == 0) ? true : false);
        }

        public static void ToCamelCase(string str)
        {          
            MatchCollection _matches = Regex.Matches(str, "[_]");
            
            foreach(Match m in _matches)
            {              
              str=str.Replace(str[m.Index + 1], Char.ToUpper(str[m.Index + 1]));
            }    
            string result = String.Concat(str.ToCharArray().Where(x => !x.Equals('_')).Select(x => x).ToArray());
            Console.WriteLine(result);            
        }
    }
}
