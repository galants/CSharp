using System;
using System.Numerics;
class CatalanNumbers
{
    static void Main(string[] args)
    {
        double n = double.Parse(Console.ReadLine());
        double catalanNumber=1;

        for (double i = n; i >0;i--)
            catalanNumber *= (2*(2*i-1)/(i+1));

            Console.WriteLine((catalanNumber));
    }
}