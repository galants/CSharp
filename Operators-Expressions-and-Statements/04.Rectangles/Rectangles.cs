using System;
class Rectangles
{
    static void Main(string[] args)
    {
        double width;
        double height;
        double perimeter;
        double area;

        width = double.Parse(Console.ReadLine());
        height = double.Parse(Console.ReadLine());

        perimeter = (width + height) * 2;
        area = width * height;

        Console.WriteLine("{0}\n{1}", perimeter, area);
    }
}
