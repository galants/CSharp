using System;
class PointInCircle
{
    static void Main(string[] args)
    {
        double x;
        double y;
        double radius=2;
        bool isPoitInCircle;

        x = double.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine());

        isPoitInCircle = ((x * x + y * y) <= radius * radius);

        Console.WriteLine(isPoitInCircle);

    }
}