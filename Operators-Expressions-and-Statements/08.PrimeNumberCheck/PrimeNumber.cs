using System;
class PrimeNumber
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        bool isNumPrime = true;

        if (n <= 1)
        {
            isNumPrime = false;
        }
        else
        {
            double sqrtN = Math.Sqrt(n);
            for (int i = 2; i <= sqrtN; i++)
            {
                if ((0 == n % i) && (i != n))
                    isNumPrime = false;
            }
        }

        Console.WriteLine(isNumPrime);
    }
}
