using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForCsharp8.PatternMatchingFeature
{
    public class PointOnGraph
    {
        public int X { get; }
        public int Y { get; }

        public PointOnGraph(int x, int y) => (X, Y) = (x, y);

        public void Deconstruct(out int x, out int y) => (x, y) = (X, Y);
    }
}
