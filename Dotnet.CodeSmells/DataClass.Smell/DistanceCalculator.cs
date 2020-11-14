using System;

namespace Dotnet.CodeSmells.DataClass.Smell
{
    partial class Program
    {
        public class DistanceCalculator
        {
            public DistanceCalculator()
            {

            }

            public double GetDistance(Point a, Point b)
            {
                return Math.Sqrt(Math.Pow((a.X - b.X), 2) + Math.Pow((a.Y - b.Y), 2));
            }

            // or 

            public static double GetDistanceStatic(Point a, Point b)
            {
                return Math.Sqrt(Math.Pow((a.X - b.X), 2) + Math.Pow((a.Y - b.Y), 2));
            }
        }
    }
}
