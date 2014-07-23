using System;
class Trapezoid
{
    static void Main(string[] args)
    {
        double a, b, h, trapezoidArea;

        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        h = double.Parse(Console.ReadLine());

        trapezoidArea = (a + b) * h / 2;


        Console.WriteLine(trapezoidArea);
    }
}