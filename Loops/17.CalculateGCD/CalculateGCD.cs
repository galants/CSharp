using System;
class CalculateGCD
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        if (a < b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }

        while (a % b > 0)
        {
            a = a % b;

            a = a + b;
            b = a - b;
            a = a - b;
        }
        Console.WriteLine(b);
    }
}
