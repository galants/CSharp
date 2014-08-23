using System;
using System.Collections.Generic;
class InsideTheBuilding
{
    static void Main(string[] args)
    {
        int h = int.Parse(Console.ReadLine());
        int countPoint = 5;
        List<Point> listPoint = new List<Point>();
        Building building = new Building(h);

        for (int i = 0; i < countPoint; i++)
        {
            Point point = new Point();
            point.X = int.Parse(Console.ReadLine());
            point.Y = int.Parse(Console.ReadLine());

            listPoint.Add(point);
        }

        foreach (Point point in listPoint)
        {
            bool isPointInBuild = building.IsPointInBuilding(point);

            if (isPointInBuild)
            {
                Console.WriteLine("inside");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }

    }
}

public class Point
{
    int x;
    int y;

    public Point() { }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int X
    {
        get { return x; }
        set { x = value; }
    }

    public int Y
    {
        get { return y; }
        set { y = value; }
    }
}

public class Building
{
    int h;
    public Building()
    {
    }

    public Building(int h)
    {
        H = h;
    }

    public int H
    {
        get { return h; }
        set { h = value; }
    }

    public bool IsPointInBuilding(Point point)
    {
        int firstFloorLength = 3 * H;
        int Height = 4 * H;
        int size = H;

        if (point.Y <= size && point.Y >= 0)
        {
            if ((point.X >= 0) && (point.X <= firstFloorLength))
            {
                return true;
            }
        }
        else if (point.Y <= Height&&point.Y >=size)
        {
            if ((point.X >= size) && (point.X <= 2 * size))
            {
                return true;
            }
        }

        return false;
    }

}