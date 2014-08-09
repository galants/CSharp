using System;
class QuadraticEquation
{
    static void Main(string[] args)
    {
        double a, b, c;
        double diskrim;
        double sqrtDiskrim;
        double x1, x2;

        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        c = double.Parse(Console.ReadLine());

        diskrim = b * b - 4 * a * c;
        sqrtDiskrim = Math.Sqrt(diskrim);

        if (diskrim < 0)
        {
            Console.WriteLine("no real roots");
        }
        else if (0 == diskrim)
        {

            x1 = -b / (2 * a);
            x2 = x1;
            Console.WriteLine("x1 = x2 = {0}", x1);
        }
        else
        {
            x1 = (-b - sqrtDiskrim) / (2 * a);
            x2 = (-b + sqrtDiskrim) / (2 * a);

            Console.WriteLine("x1 = {0}, x2 = {1}", x1, x2);
        }
    }
}
