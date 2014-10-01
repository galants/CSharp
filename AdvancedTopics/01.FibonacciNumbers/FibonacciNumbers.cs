using System;

internal class FibonacciNumbers
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Fib(n);
    }

    private static void Fib(int n)
    {
        int last = 0;
        int now = 1;

        for (int i = 1; i <= n; i++)
        {
            int num = now;
            now += last;
            last = num;
        }

        Console.WriteLine(now);
    }
}