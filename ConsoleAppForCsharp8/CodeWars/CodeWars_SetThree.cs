using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleAppForCsharp8.CodeWars
{
 public class CodeWars_SetThree
    {
        public static string StringLetterCount(string str)
        {
           string output= str.Where(x=>Char.IsLetter(x))
                       .Select(x=>Char.ToLower(x))
                       .OrderBy(x=>x).GroupBy(x => x)
                       .Select(x=>new { member = x.Key, count = x.Count() })
                       .Aggregate("",(output,x)=> String.Concat(output, $"{x.count}{x.member}"));         
           return output;
        }

        public static bool IsOnionArray(int[] arr)
        {
            int len = arr.Length;

            bool status = len > 0 ? false : true; 

            for(int i=0;i<len/2;i++)
            {
                int o_index = len - 1 - i;
                if(o_index >=0 && o_index <len)
                {
                    status = arr[i] + arr[o_index] <= 10 ? true : false;                        
                }
                    
            }

            return status;
        }
    }
}
