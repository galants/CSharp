using System;
class NumbersFrom1ToN
{
    static void Main(string[] args)
    {
        int n;

        n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
            Console.WriteLine(i);
    }
}
