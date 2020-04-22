using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace ConsoleAppForCsharp8.EdaBitChallenges
{
    public  static class AdvancedChallenges
    {

        public static bool Is_Valid_HexCode(string hexcode)
        {
            return Regex.Match(hexcode, "^#[0-9a-fA-F]{6}$").Success;
        }

        public static int[] Array_OF_Multiples(int num , int length)
        {
            List<int> arrayOFMul = new List<int>();
            for(int i=1;i<=length;i++)
            {
                arrayOFMul.Add(num * i);
            }
            return(arrayOFMul.ToArray());
        }

        public static bool Is_Smooth(string str)
        {
            string[] words = str.Split(' ');
                
            for(int i=0,j=1;j<words.Length;i++,j++)
            {
                string w = words[i];
                string x = words[j];

                if (Char.ToLower(w[w.Length - 1]) != Char.ToLower((x[0])))
                    return false;
            }
            return true;
        }

        public static string ReverseAndNot(int i)
        {
            //This code also works
            //List<char> str = Convert.ToString(i).ToList<char>();
            //str.Reverse();
            //return (new string(str.ToArray<char>())+Convert.ToString(i));           
         return($"{String.Concat(i.ToString().Reverse())}{i.ToString()}");
        }
        
        //good example need to look into groupby more examples
        public static int SockPairs(string socks)
        {
            socks = "CABBACCC";
            socks.ToCharArray().GroupBy(c => c);
            socks.ToCharArray().GroupBy(c => c).Select(c=>c.Count()/2);
           int count= socks.ToCharArray().GroupBy(c => c).Select(c => c.Count() / 2).Sum();
            return count;
        }

        public static void WeekdayRobWasBornInDutch(int year, int month, int day)
        {
            DateTime birthDate = new DateTime(year, month, day);
            Console.WriteLine(birthDate.DayOfWeek.ToString());
            var culture = new System.Globalization.CultureInfo("nl-NL");
            var dutchBirthday = culture.DateTimeFormat.GetDayName(birthDate.DayOfWeek);
            Console.WriteLine(dutchBirthday.ToString());
        }
    }
}

