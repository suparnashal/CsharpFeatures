using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppForCsharp8.Default_Interface_Methods
{
    public class SampleCustomer : ICustomer
    {
        private List<SampleOrder> Orders = new List<SampleOrder>() ; 
        public IEnumerable<IOrder> PreviousOrders => Orders;        

        public DateTime DateJoined { get; }

        public DateTime? LastOrder { get; set; }

        public string Name { get; set; }

        public IDictionary<DateTime, string> Reminders { get; set; }

        public SampleCustomer(string name, DateTime datejoined)
        {
            Name = name;
            DateJoined = datejoined;                        
        }
        public SampleCustomer(string name, DateTime datejoined,DateTime childBirthday, DateTime anniv)
        {
            Name = name;
            DateJoined = datejoined;                        
            Reminders = new Dictionary<DateTime,string>() {
                {childBirthday, "Child's birthday"},{anniv,"Anniversary"} 
            };

        }
        public void AddOrder(SampleOrder o)
        {
            Orders.Add(o);            
            LastOrder = o.Purchased;
        }

        public decimal ComputeLoyaltyDiscount()
        {
            if (PreviousOrders.Any() == false)
                return 0.50m;
            else
                return ICustomer.DefaultLoyaltyDiscount(this);
        }
    }
}
