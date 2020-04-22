using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleAppForCsharp8.LinQPractice
{
    public static class SetOne
    {

        public static void Test_GroupBy_Employees()
        {
            var grpEmployees = Employee.GetEmployees().GroupBy(x => (x.Gender,x.Department));

            foreach (var group in grpEmployees)
            {
                Console.WriteLine("{0}{1} - {2}", group.Key.Department,group.Key.Gender, group.Count());
            }
        }

        public static void Test_Employee_HavingSame_FirstNames()
        {
            var grpEmployees = Employee.GetEmployees().GroupBy(x => x.Name)
                                                      .Where(g=>g.Count()>1)
                                                       .Select(k=>new {Name=k.Key,NoOftimes=k.Count()}); // project the outputof where, just give it goodnames

            foreach (var group in grpEmployees)
            {
                Console.WriteLine("{0} - {1}", group.Name,group.NoOftimes);
            }
        }

        public static void Check_For_Palindrome()
        {
            string palindrome = "racecar1";
            if (String.Concat(palindrome.Reverse()).Equals(palindrome))
                Console.WriteLine($"String is palindrome: {palindrome}");
            else
                Console.WriteLine($"String is NOT a palindrome: {palindrome}");
        }

        public static void Find_Pairs_UsingGroupBy()
        {
           string socks = "CABBACCC";

            var result = socks.ToCharArray().OrderBy(x => x).GroupBy(x => x).Select(x=>new { Key = x.Key, Cnt = x.Count()/2 });

            foreach (var group in result)
            {
                Console.WriteLine($"{group.Key} - {group.Cnt}");
            }            
            Console.WriteLine($"{socks} -  {result.Sum(x => x.Cnt)}");
        }

    }
}
