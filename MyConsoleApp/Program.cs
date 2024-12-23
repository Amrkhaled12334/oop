using System;
using System.Security.Cryptography;

namespace MyConsoleApp
{
    
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the coordinates for the first point (X Y):");
        var input1 = Console.ReadLine().Split();
        Point point1 = new Point(double.Parse(input1[0]), double.Parse(input1[1]));

        Console.WriteLine("Enter the coordinates for the second point (X Y):");
        var input2 = Console.ReadLine().Split();
        Point point2 = new Point(double.Parse(input2[0]), double.Parse(input2[1]));

        double distance = Point.CalculateDistance(point1, point2);
        Console.WriteLine($"The distance between the two points is: {distance:F2}");
    }
}
}
