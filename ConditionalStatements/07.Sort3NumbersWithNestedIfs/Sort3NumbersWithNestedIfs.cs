using System;
class Sort3NumbersWithNestedIfs
{
    static void Main(string[] args)
    {
        double a;
        double b;
        double c;

        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        c = double.Parse(Console.ReadLine());

        if (a >= b)
        {
            if (b >= c)
            {
                Console.WriteLine("{0}\n{1}\n{2}", a, b, c);
            }
            else if (a >= c)
            {
                Console.WriteLine("{0}\n{1}\n{2}", a, c, b);
            }
            else
            {
                Console.WriteLine("{0}\n{1}\n{2}", c, a, b);
            }
        }
        else
        {
            if (a >= c)
            {
                Console.WriteLine("{0}\n{1}\n{2}", b, a, c);
            }
            else if (b >= c)
            {
                Console.WriteLine("{0}\n{1}\n{2}", b, c, a);
            }
            else
            {
                Console.WriteLine("{0}\n{1}\n{2}", c, b, a);
            }
        }
    }
}
