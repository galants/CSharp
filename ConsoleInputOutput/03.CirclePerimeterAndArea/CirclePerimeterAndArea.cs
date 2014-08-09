using System;
class CirclePerimeterAndArea
{
    static void Main(string[] args)
    {
        double r;
        double perimeter;
        double area;

        r = double.Parse(Console.ReadLine());

        perimeter = 2 * Math.PI * r;

        area = Math.PI * r * r;

        Console.WriteLine("Perimeter is : {0:F2}, area is : {1:F2}", perimeter, area );
    }
}