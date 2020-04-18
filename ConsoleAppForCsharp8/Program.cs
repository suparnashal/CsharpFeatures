using ConsoleAppForCsharp8.Default_Interface_Methods;
using System;
using System.Net;

namespace ConsoleAppForCsharp8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test_ReadOnly_In_Structs();
            Test_Default_Interface_Methods();
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
    }
}
