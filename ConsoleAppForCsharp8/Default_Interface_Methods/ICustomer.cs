using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppForCsharp8.Default_Interface_Methods
{
  public interface ICustomer
    {
        IEnumerable<IOrder> PreviousOrders { get; }
        DateTime DateJoined { get; }
        DateTime? LastOrder { get; }
        string Name { get; }
        IDictionary<DateTime, string> Reminders { get; }
        private static int ago { get; set; }
        private static decimal discount { get; set; }
        public decimal ComputeLoyaltyDiscount() => DefaultLoyaltyDiscount(this);
        protected static decimal DefaultLoyaltyDiscount(ICustomer c)
        {            
            DateTime YearsAgo = DateTime.Now.AddYears(ago);            
            if (c.DateJoined < YearsAgo)
                return discount;
            return 0;
        }

        public static void SetLoyaltyThresholds(int _ago,decimal _discount)
        {
            ago = _ago;
            discount = _discount;
        }
    }
}
