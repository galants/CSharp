using System;
class TheBiggestOf3Numbers
{
    static void Main(string[] args)
    {
        double a;
        double b;
        double c;
        double max = 0;

        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        c = double.Parse(Console.ReadLine());

        if ((a > b)&&(a>c))
        {
            max = a;
        }
        else if ((b > a) && (b > c))
        {
            max = b;
        }
        else if ((c > a) && (c > b))
        {
            max = c;
        }
        Console.WriteLine(max);
    }
}