using System;
class FibonacciNumbers
{
    static void Main(string[] args)
    {
        int n;
        int last = 1;
        int beforLast = 0;
        int now;

        n = int.Parse(Console.ReadLine());

        if (1 == n)
            Console.WriteLine("{0}", beforLast);
        else
        {
            Console.Write("{0} {1} ", beforLast, last);
            for (int i = 2; i < n; i++)
            {
                now = last + beforLast;
                Console.Write("{0} ", now);

                beforLast = last;
                last = now;
            }
        }
    }
}
