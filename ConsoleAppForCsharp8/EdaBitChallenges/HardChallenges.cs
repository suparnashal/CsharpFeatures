using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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
    }
}
