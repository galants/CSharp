using System;
class NumberComparer
{
    static void Main(string[] args)
    {
        double a, b;
        double max;

        a = double.Parse(Console.ReadLine());
        b = double.Parse(Console.ReadLine());

        max = Math.Max(a, b);

        Console.WriteLine(max);
    }
}