using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;

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
    }
}

