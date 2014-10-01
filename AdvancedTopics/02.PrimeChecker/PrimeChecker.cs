using System;

internal class PrimeChecker
{
    private static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine());

        IsPrime(n);
    }

    private static void IsPrime(long n)
    {
        double chekBorder = Math.Sqrt(n);
        bool isPrime = true;

        if (n <= 1)
        {
            isPrime = false;
        }

        for (int i = 2; i <= chekBorder; i++)
        {
            if (n%i == 0)
            {
                isPrime = false;
                break;
            }
        }

        Console.WriteLine(isPrime);
    }
}