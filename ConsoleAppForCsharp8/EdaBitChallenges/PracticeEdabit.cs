using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//This class is for practicising edabit challenges only. Can delete later
namespace ConsoleAppForCsharp8.EdaBitChallenges
{
    public class PracticeEdabit
    {

        public static double[] FindMinMax(double[] values) => new[] {values.Min(),values.Max() };

        public static List<int> oddNumbers(int l, int r)
        {
            List<int> values = new List<int>();
            for (int i = l; i <= r; i++ )
            {
                if (i % 2 != 0)
                    values.Add(i);
            }
            return values;
            
        }

       

    }
}
