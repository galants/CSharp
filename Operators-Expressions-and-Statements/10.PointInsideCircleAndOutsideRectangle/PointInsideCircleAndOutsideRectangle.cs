using System;
class PointInsideCircleAndOutsideRectangle
{
    static void Main(string[] args)
    {
        double x, y;
        double circleX, circleY, circleR;
        double rectangleTop, rectangleLeft, rectangleWidth, rectangleHeight;
        bool isPointInsideCircleAndOutsideRectangle;

        circleX = 1.0;
        circleY = 1.0;
        circleR = 1.5;

        rectangleTop = 1.0;
        rectangleLeft = -1.0;
        rectangleWidth = 6.0;
        rectangleHeight = 2.0;

        x = double.Parse(Console.ReadLine());
        y = double.Parse(Console.ReadLine());

        isPointInsideCircleAndOutsideRectangle = (y > rectangleTop) && (((x - circleX) * (x - circleX) + (y - circleY) * (y - circleY)) <= (circleR * circleR));

        if (isPointInsideCircleAndOutsideRectangle)
            Console.WriteLine("yes");
        else
            Console.WriteLine("no");
    }
}