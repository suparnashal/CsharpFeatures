using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppForCsharp8.EdaBitChallenges
{
  public static class HackerRank_HardChallenges
    {

        public static long findGeometricProgression(long[] numbers,long number, int cratio,Dictionary<long,int> numberFreq)
        {
            long[] progression = new long[3];
            progression[0] = number / cratio;
            progression[1] = number;
            progression[2] = number * cratio;

            if (progression.Any(x => !numbers.Contains(x))) 
            return 0;
            else
                 return numberFreq[progression[0]] * numberFreq[progression[2]];
        }

        public static Dictionary<long,int> CountOfNumber(long[] numbers)
        {
            Dictionary<long, int> frequencyOfNumber = new Dictionary<long, int>();
            foreach(int n in numbers)
            {
                if(!frequencyOfNumber.ContainsKey(n))
                    frequencyOfNumber.Add(n, 0);
                frequencyOfNumber[n]++;
            }
            return frequencyOfNumber;
        }
        

        public static void countTriplets2()
        {
            int cratio = 3;
            long[] numbers = new long[] {1,3,9,9,27,81};

            Dictionary<long, int> numberFrquency = CountOfNumber(numbers);            
            long counter=0;

            foreach(int val in numbers)
            {
                counter += findGeometricProgression(numbers, val, cratio, numberFrquency);
            }
            Console.WriteLine(counter);
        }
    }
}
