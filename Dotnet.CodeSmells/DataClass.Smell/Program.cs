using System;

namespace Dotnet.CodeSmells.DataClass.Smell
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Code smell - DataClass - Smell");

            var pointA = new Point(1, 1);
            var pointB = new Point(1, 2);

            var distanceCalculator = new DistanceCalculator();

            var distance = distanceCalculator.GetDistance(pointA, pointB);

            Console.WriteLine($"Distance between {pointA} and {pointB} is: {distance}");

            // or

            distance = DistanceCalculator.GetDistanceStatic(pointA, pointB);

            Console.WriteLine($"Distance between {pointA} and {pointB} is: {distance} - (staticly)");
        }
    }
}
