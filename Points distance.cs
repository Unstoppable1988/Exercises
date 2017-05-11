using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Point
    {
        public int x;
        public int y;
    }
    public class DistanceCalculation
    {
        public static double calculateDistance(Point point1, Point point2)
        {
            double distance = Math.Sqrt((point2.x - point1.x) * (point2.x - point1.x) + (point2.y - point1.y) * (point2.y - point1.y));
            return distance;
        }
        public static void Run()
        {
            Point point1 = new Point();
            Console.WriteLine("Enter x1");
            point1.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y1");
            point1.y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter x2");
            Point point2 = new Point();
            point2.x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter y2");
            point2.y = int.Parse(Console.ReadLine());
            Console.WriteLine(calculateDistance(point1, point2));
            Console.ReadLine();
        }
    }
}
