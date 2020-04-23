using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppForCsharp8.LinQPractice
{
    public class SetTwo
    {

        public static void Test_Select_Many()
        {
            var result = Student.GetAllStudetns().SelectMany(s => s.Subjects).OrderBy(s=>s).Distinct();

            foreach(var v in result)
            {
                Console.WriteLine($"{v}");
            }

        }

        public static void Test_Select_Many2()
        {
            var result = Student.GetAllStudetns().Where(s => s.Gender == "Male")
                        .SelectMany(s => s.Subjects, (student, subject) => new { Name = student.Name, Subject = subject });
                        
            foreach (var v in result)
            {
                Console.WriteLine($"{v.Name} -  {v.Subject}");
            }

        }

        public static void Test_Select_Many_WithGroupBy()
        {
            var result = Student.GetAllStudetns().SelectMany(s => s.Subjects, (student, subject) => new { Name = student.Name, Subject = subject })
                        .GroupBy(s=>s.Subject);

            foreach (var v in result)
            {
                Console.WriteLine($"{v.Key} -  {v.Count()}");
            }

        }
        public static void Find_All_Students_ASP_NET()
        {
            var result = Student.GetAllStudetns().Where(s => s.Subjects.Contains("ASP.NET")).Count();
            Console.WriteLine($"No. of students taking ASP.NET is:{result}");
                       
            //foreach (var v in result)
            //{
            //    Console.WriteLine($"{v.Name}");
            //}

        }
    }
}
