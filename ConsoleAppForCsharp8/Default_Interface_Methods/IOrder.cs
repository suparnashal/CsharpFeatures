using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForCsharp8.Default_Interface_Methods
{
    public interface IOrder
    {
        DateTime Purchased { get; }
        decimal Cost { get; }
    }
}
