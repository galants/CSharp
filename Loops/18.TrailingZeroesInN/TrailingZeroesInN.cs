using System;
class TrailingZeroesInN
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int countZeros = 0;
        int five = 5;

        while (n >= five)
        {
            countZeros += n / five;
            five *= 5;
        }

        Console.WriteLine(countZeros);
    }
}
