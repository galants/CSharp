using System;
class ExchangeIfGreater
{
    static void Main(string[] args)
    {
        int a;
        int b;

        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }

        Console.WriteLine("{0} {1}", a, b);

    }
}
