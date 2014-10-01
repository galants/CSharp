using System;
class MultiplicationSign
{
    static void Main(string[] args)
    {
        double a;
        double b;
        double c;

        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());
        c = double.Parse(Console.ReadLine());

        if ((0 != a) && (0 != b) && (0 != c))
        {
            if ((a < 0) && (b < 0) && (c < 0))
            {
                Console.WriteLine('-');
            }
            else if ((a < 0) && (b > 0) && (c > 0))
            {
                Console.WriteLine('-');
            }
            else if ((a > 0) && (b < 0) && (c > 0))
            {
                Console.WriteLine('-');
            }
            else if ((a > 0) && (b> 0) && (c < 0))
            {
                Console.WriteLine('-');
            }
            else
            {
                Console.WriteLine('+');
            }
        }
        else
        {
            Console.WriteLine('0');
        }
    }
}
