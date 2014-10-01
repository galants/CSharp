using System;
using System.Collections.Generic;

internal class PerimeterAndAreaPolygon
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Polygon polygon = new Polygon();

        for (int i = 0; i < n; i++)
        {
            string str = Console.ReadLine();
            string[] strArr = str.Split(new char[] {' '});
            string x = strArr[0];
            string y = strArr[1];

            polygon.Add(x, y);
        }

        Console.WriteLine("perimeter = {0:F}", polygon.Perimeter());
        Console.WriteLine("area = {0:F}", polygon.Area());
    }
}

public class Point
{
    private double x;
    private double y;

    public Point()
    {
    }

    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double X
    {
        get { return x; }
        set { x = value; }
    }

    public double Y
    {
        get { return y; }
        set { y = value; }
    }
}

public class Polygon
{
    private List<Point> listPoint = new List<Point>();

    public List<Point> ListPoint
    {
        get { return listPoint; }
        set { listPoint = value; }
    }

    public void AddRange(List<Point> list)
    {
        listPoint.AddRange(list);
    }

    public void Add(Point point)
    {
        listPoint.Add(point);
    }

    public void Add(string x, string y)
    {
        double doubleX = double.Parse(x);
        double doubleY = double.Parse(y);

        Point point = new Point(doubleX, doubleY);
        listPoint.Add(point);
    }

    public double Area()
    {
        double area = 0;
        Point lastPoint = new Point();
        Point nowPoint = new Point();
        double x1, x2, y1, y2;

        for (int i = 1; i < listPoint.Count; i++)
        {
            lastPoint = listPoint[i - 1];
            nowPoint = listPoint[i];

            x1 = lastPoint.X;
            y1 = lastPoint.Y;
            x2 = nowPoint.X;
            y2 = nowPoint.Y;

            area += Area(x1, x2, y1, y2);
        }

        lastPoint = listPoint[listPoint.Count - 1];
        nowPoint = listPoint[0];

        x1 = lastPoint.X;
        y1 = lastPoint.Y;
        x2 = nowPoint.X;
        y2 = nowPoint.Y;

        area += Area(x1, x2, y1, y2);

        return Math.Abs(area);
    }

    public double Perimeter()
    {
        double perimeter = 0;
        Point lastPoint = new Point();
        Point nowPoint = new Point();
        double x1, x2, y1, y2;

        for (int i = 1; i < listPoint.Count; i++)
        {
            lastPoint = listPoint[i - 1];
            nowPoint = listPoint[i];

            x1 = lastPoint.X;
            y1 = lastPoint.Y;
            x2 = nowPoint.X;
            y2 = nowPoint.Y;

            perimeter += DistanceTwoPoint(x1, x2, y1, y2);
        }

        lastPoint = listPoint[listPoint.Count - 1];
        nowPoint = listPoint[0];

        x1 = lastPoint.X;
        y1 = lastPoint.Y;
        x2 = nowPoint.X;
        y2 = nowPoint.Y;

        perimeter += DistanceTwoPoint(x1, x2, y1, y2);

        return perimeter;
    }

    private double DistanceTwoPoint(double x1, double x2, double y1, double y2)
    {
        return Math.Sqrt((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2));
    }

    private double Area(double x1, double x2, double y1, double y2)
    {
        double area = ((x1*y2) - (y1*x2))/2;

        return area;
    }
}