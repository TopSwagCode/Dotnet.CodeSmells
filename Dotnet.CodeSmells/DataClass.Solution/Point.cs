using System;

namespace DataClass.Solution
{
    public record Point
    {
        public double X { get; }
        public double Y { get; }

        public Point(double x, double y) => (X, Y) = (x, y);

        public double GetDistanceTo(Point point)
        {
            return Math.Sqrt(Math.Pow((this.X - point.X), 2) + Math.Pow((this.Y - point.Y), 2));
        }
    }
}
