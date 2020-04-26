using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppForCsharp8.CodeWars
{
  public  class CodeWars_SetOne
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            //Try formatting into different ways .. 
            Console.WriteLine(1234.ToString("0-0-0-0")) ;
            Console.WriteLine(123.4.ToString("0-0-0-0"));
            Console.WriteLine(123.4d.ToString("0-0-0-0"));
            string phonenum = $"({numbers[0]}{numbers[1]}{numbers[2]}) {numbers[3]}{numbers[4]}{numbers[5]}-{numbers[6]}{numbers[7]}{numbers[8]}{numbers[9]}";
            Console.WriteLine($"phone no. # way1:  {phonenum}");

           string phonenum2 =  String.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}",numbers.Select(x => x.ToString()).ToArray());
            Console.WriteLine($"Phone num way 2 - {phonenum2}");
            return ((Int32.Parse(String.Concat(numbers))).ToString("(000) 000-0000"));        
        }

        public static String IsItANum(string str)
        {            
            string phonenum = new String(str.Where(x => Char.IsNumber(x)).Select(x => x).ToArray());
            return ((phonenum.Length == 11)&&(phonenum[0].Equals('0')) ? phonenum: "Not a phone number");
        }
    }
}
