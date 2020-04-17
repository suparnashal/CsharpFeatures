using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForCsharp8
{
    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public readonly double Distance => Math.Sqrt(X * X + Y * Y); 

        //Distance needs to be readonly because its used in readonly member and it has a non-default getter
        public readonly override string ToString() => $"{X} , {Y} is {Distance:0.000} from the origin";
       
    }
}
