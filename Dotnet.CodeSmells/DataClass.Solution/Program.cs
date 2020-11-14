using System;

namespace DataClass.Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Code smell - DataClass - Solution");

            var pointA = new Point(1, 1);
            var pointB = new Point(1, 2);

            var distance = pointA.GetDistanceTo(pointB);

            Console.WriteLine($"Distance between {pointA} and {pointB} is: {distance}");
        }
    }
}
