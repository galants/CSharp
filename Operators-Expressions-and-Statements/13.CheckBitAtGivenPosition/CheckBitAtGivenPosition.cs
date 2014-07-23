using System;
class CheckBitAtGivenPosition
{
    static void Main(string[] args)
    {
        int n;
        int p;
        bool expression;

        n = int.Parse(Console.ReadLine());
        p = int.Parse(Console.ReadLine());

        expression = (1 == ((n >> p) & 1));

        Console.WriteLine(expression);
    }
}