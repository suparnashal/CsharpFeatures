using ConsoleAppForCsharp8.Default_Interface_Methods;
using ConsoleAppForCsharp8.EdaBitChallenges;
using ConsoleAppForCsharp8.PatternMatchingFeature;
using System;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using ConsoleAppForCsharp8.LinQPractice;

namespace ConsoleAppForCsharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test_ReadOnly_In_Structs();
            //Test_Default_Interface_Methods();
            //Test_Switch_Expression();

            //string hexcode= Console.ReadLine();
            //Console.WriteLine($"{AdvancedChallenges.Is_Valid_HexCode(hexcode)}");
            //AdvancedChallenges.Array_OF_Multiples(7, 5);
            //AdvancedChallenges.ReverseAndNot(123); 
            //AdvancedChallenges.SockPairs("CABBACCC");

            //SetOne.Test_GroupBy_Employees();
            //SetOne.Find_Pairs_UsingGroupBy();

           AdvancedChallenges.WeekdayRobWasBornInDutch(1970, 9, 21);


            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }

        public static void Test_ReadOnly_In_Structs()
        {
            Point p = new Point();
            p.X = 1.2;
            p.Y = 1.2;
            Console.WriteLine(p);            
        }

        public static void Test_Default_Interface_Methods()
        {
            ICustomer.SetLoyaltyThresholds(-2, 0.20m);
            SampleCustomer c1 = new SampleCustomer("John Smith",new DateTime(2020,1,23));
            SampleCustomer c2 = new SampleCustomer("Mary Smith", new DateTime(2017, 2, 15), new DateTime(2009, 4, 15), new DateTime(2005, 6, 1));
            SampleCustomer c3 = new SampleCustomer("Kim Smith", new DateTime(2020, 3, 13));

            SampleOrder o1 = new SampleOrder(new DateTime(2019, 12, 11), 150.67m);
            SampleOrder o2 = new SampleOrder(new DateTime(2019, 10, 11), 50.67m);

            c1.AddOrder(o1);
            c2.AddOrder(o2);
            
            Console.WriteLine($"Discount for {c1.Name} is {c1.ComputeLoyaltyDiscount()}"); //calls ComputeLoyaltyDiscount of the SampleCustomer
            
            Console.WriteLine($"Discount for {c2.Name} is {c2.ComputeLoyaltyDiscount()}");
            Console.WriteLine($"Discount for {c3.Name} is {c3.ComputeLoyaltyDiscount()}");
            ICustomer c = c3;
            Console.WriteLine($"ICustomer Discount for {c3.Name} is {c.ComputeLoyaltyDiscount()}");
        }

        public static void Test_Switch_Expression()
        {
            Console.WriteLine(FromRainbow(Rainbow.Blue));
            Console.WriteLine(FromRainbow(Rainbow.Orange));
            Console.WriteLine(FromRainbow(Rainbow.Violet));
            Console.WriteLine("\n\n");

            //Test switch statement using Propertys of classes
            Console.WriteLine($"Sales tax for $100 in WA is : {ComputeSalesTax(new Address("WA"), 100M)}");
            Console.WriteLine($"Sales tax for $100 in CA is : {ComputeSalesTax(new Address("CA"), 100M)}");
            Console.WriteLine($"Sales tax for $100 in other states is : {ComputeSalesTax(new Address("TX"), 100M)}");
            Console.WriteLine("\n\n");

            //Tuple Matching in switch statement. Switch statement selecting on 2 parameters
            Console.WriteLine($"I:Rock , You:Paper : {RockPaperScissors("rock", "paper")}");
            Console.WriteLine($"I:Rock, You:Rock : {RockPaperScissors("rock", "rock")}");
            Console.WriteLine($"I:Paper You:Scissors : {RockPaperScissors("paper", "scissors")}\n\n");

            //Positional patterns
            Console.WriteLine($"Quadrant for (0,0) is : {Position_Switch_Pattern(new PointOnGraph(0,0))}");
            Console.WriteLine($"Quadrant for (20,20) is : {Position_Switch_Pattern(new PointOnGraph(20,20))}");
            Console.WriteLine($"Quadrant for (-20,20) is : {Position_Switch_Pattern(new PointOnGraph(-20,20))}\n\n");

        }

        public static string FromRainbow(Rainbow colorBand)
        {
         string favColor= colorBand switch
            {
                Rainbow.Red => new string("Red"),
                Rainbow.Orange => new string("Orange"),
                Rainbow.Blue => new string("Blue"),
                _ => new string("none")
            };
            return favColor;
        }

        public static decimal ComputeSalesTax(Address location, decimal salesPrice) =>
            location switch
            {
                { State:"WA" } => salesPrice * 0.06M,
                { State: "CA" } => salesPrice * 0.05M,
                { State: "MI" } => salesPrice * 0.05M,
                _ => salesPrice *0.01M
            };

        public static string RockPaperScissors(string first, string second) =>
        (first, second) switch
        {
            ("rock","paper") => "rock is covered by paper.Paper wins",
            ("rock","scissors") => "Rock breaks scissors.Scissors wins",
            ("paper","scissors") => "Scissors cuts paper.Scissors wins",
            (_,_) => "tie" 
        };

        public static string Position_Switch_Pattern(PointOnGraph point) =>
           point switch
           {
               (0, 0) => "Quadrant Origin",
               var (x,y) when x > 0 && y > 0 => "Quadrant One",
               var (x,y) when x < 0 && y > 0 => "Quadrant Two",
               var (_,_) => "Quadrant On Border"
           };
        

        
        
    }
}
