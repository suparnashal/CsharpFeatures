using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleAppForCsharp8.EdaBitChallenges
{
    class HackerRankClass
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int lengthOfmatrix = 3;
            int sum1 = 0, sum2 = 0;

            sum1 = arr.Sum(x => x.ElementAt(arr.IndexOf(x)));
            sum2 = arr.Sum(x => x.ElementAt(Math.Abs(lengthOfmatrix - arr.IndexOf(x) - 1)));

            //for (int i = 1; i <= lengthOfmatrix; i++)
            //{
            //    sum1 = sum1 + arr[i][i];
            //}

            //for (int i = lengthOfmatrix-1 ; i >= 0; i--)
            //{                
            //    sum2 = sum2 + arr[i][lengthOfmatrix - i-1];

            //}
            return (Math.Abs(sum1 - sum2));

        }

        //Always use floating point for 6-7 digits after the decimal.for more decimal places use double and then 
        static void plusMinus()
        {
            int[] arr = new int[] { -4, 3, -9, 0, 4, 1 };
            int n = 6;
            float count1 = (float)(arr.Where(c => c > 0 == true).Count()) / n;
            float count2 = (float)(arr.Where(c => c < 0 == true).Count()) / n;
            float count3 = (float)(arr.Where(c => (c == 0) == true).Count()) / n;

            Console.WriteLine(String.Format("{0:0.000000}", count1));
            Console.WriteLine(String.Format("{0:0.000000}", count2));
            Console.WriteLine(String.Format("{0:0.000000}", count3));
        }

        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
        {

            var result = ar.GroupBy(x => x).Select(x => new { x.Key, cnt = x.Count() / 2 });

            foreach (var g in result)
            {
                Console.WriteLine($"{g.Key}    {g.cnt}");
            }

            Console.WriteLine($"{result.Sum(x => x.cnt)}");
            return result.Count();
        }

        public static int countingValleys(int steps, string path)
        {
            int d = 0, u = 0, valley = 0; ;
            for (int i = 0; i < steps; i++)
            {
                if (path[i] == 'D') d++;
                if (path[i] == 'U')
                {
                    d--;
                    if (d == 0) valley++;
                }

            }
            return valley;
        }
        static int jumpingOnClouds(int[] c)
        {
            int jumps = 0, i = 0;
            do
            {
                if (c[i + 2] == 0)
                {
                    i = i + 2;
                    jumps++;
                }
                else
                    if (c[i + 1] == 0)
                {
                    i++; jumps++;
                }
            } while (i < c.Length);
            return jumps;
        }

        static long repeatedString(string s, long n)
        {
            while (s.Length < n)
                s.Concat(s);

            return Regex.Matches(s.Substring(0,(int)n), "[a]").Count();
        }

        static int hourglassSum(int[][] arr)
        {
            //int[] values = new int[] { };
            //for (int i = 0, j = i + 1,k=j+1; i < 16 && j < 16 && k<16; i++,j++,k++)
            //{
            //    //find the sum of the hour glass
            //    int sum = arr[j][1] ;
            //    for (int l = 0; l < 3; l++)
            //    {
            //        sum = arr[i][l] + arr[k][l];
            //    }
            //}
            return 1;

        }

        static long arrayManipulation(int n, int[][] queries)
        {
            List<int> values = new List<int>();

            for(int i=0;i<n;i++)
            {
                values.Add(0);
            }

            for(int i=0;i<queries.Length;i++)
            {
                int j = queries[i][0];//start index
                int k = queries[i][1];//end index
                int value = queries[i][2];

                for (int m = j; m <= k; m++)
                    values[m] = values[m] + value;
                
            }
            return values.Max();

        }

      

        public static void checkMagazine(string[] magazine, string[] note, int m, int n)
        {
            magazine = new string[] { "two", "times", "threee", "is", "not", "four" };
            note = new string[] { "two", "times", "two", "is", "four" };
            n = 5;
            Array.Sort(magazine); //when there is searching involved use sort to improve performance
            Array.Sort(note);
            List<string> magazine_words = new List<string>(magazine); //create a List<string> from array of strings
            foreach (string s in note)
            {
                if (!magazine_words.Remove(s))
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");
        }


       public static Dictionary<string,int> getStringFrequency(string[] text)
        {
            Dictionary<string, int> stringNum = new Dictionary<string, int>();
            foreach(string s in text)
            {
                if (!stringNum.ContainsKey(s))
                    stringNum.Add(s, 0);
                stringNum[s]++;
            }
            return stringNum;
        }

        public static void checkMagazine2()
        {
           string [] magazine = new string[] { "give", "me", "one", "grand", "today", "night" };
           string[]  note = new string[] { "give", "times", "two", "is", "four" };
          // int n = 5;
            Dictionary<string, int> magFreq = getStringFrequency(magazine);
            Dictionary<string, int> notesFreq = getStringFrequency(note);

            foreach(KeyValuePair<string,int> n in notesFreq)
            {
                if (!magFreq.ContainsKey(n.Key) || !(magFreq[n.Key] >= n.Value))
                {
                    Console.WriteLine("No");
                    return;
                }
                 
            }
            Console.WriteLine("Yes");
        }

        // Complete the checkMagazine function below.
        static void checkMagazine3(string[] magazine, string[] note, int m, int n)
        {

            Array.Sort(magazine);
            Array.Sort(note);
            List<string> magazine_words = new List<string>(magazine);
            foreach (string s in note)
            {
                if (!magazine_words.Remove(s))
                {
                    Console.WriteLine("No");
                    return;
                }
            }
            Console.WriteLine("Yes");
        }
        static string twoStrings(string s1, string s2)
        {

            char[] c1 = s1.ToCharArray();
            char[] c2 = s2.ToCharArray();

            return (c1.Any(x => c2.Contains(x) == true) == true || c2.Any(x => c1.Contains(x) == true) ? "YES" : "NO");
            
        }

        // Complete the countTriplets function below.
       public  static long countTriplets()
        {
            long[] arr2 = new long[]{1,2,2,4};            
            List<long> arr = arr2.ToList(); 
            long[] tr = new long[3];
            int r = 2;           
            int triplets = 0;

            foreach(long l in arr)
            {
                tr[0] = arr.Contains(l) ? l : -1 ;
                tr[1] = arr.Contains(l * r) ? l * r : -1;
                tr[2] = arr.Contains(l * r * r) ? l * r * r : -1;

                triplets = tr.Contains(-1) ? triplets : triplets + 1;
            }

            return triplets;
        }

        static int alternatingCharacters(string s)
        {
            int deletions = 0;
            char[] c = s.ToArray();
            for(int i=0; i<c.Length-1;i++)
            {
                if (c[i] == c[i + 1] && c[i] != ' ')
                {
                    
                    deletions++;
                }                    

            }
            return deletions;
        }



    }

}
