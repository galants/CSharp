using System;
class ModifyBitAtGivenPosition
{
    static void Main(string[] args)
    {
        int n;
        int p;
        int v;
        bool expression;

        n = int.Parse(Console.ReadLine());
        p = int.Parse(Console.ReadLine());
        v = int.Parse(Console.ReadLine());

        n = (0 == v) ? (n & ~(1 << p)) : (n | (1 << p));

        Console.WriteLine(n);
    }
}