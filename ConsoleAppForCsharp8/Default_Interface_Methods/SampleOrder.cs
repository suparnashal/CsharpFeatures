using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForCsharp8.Default_Interface_Methods
{
    public class SampleOrder : IOrder
    {
        public DateTime Purchased { get; set; }

        public decimal Cost { get; set; }

        public SampleOrder(DateTime purchased,decimal cost)
        {
            Purchased = purchased;
            Cost = cost;
        }

    }
}
