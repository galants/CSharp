using System;
class BitSieves
{
    static void Main(string[] args)
    {
        int bitsCount = 0;
        ulong number = ulong.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        ulong[] sieves = new ulong[n];

        for (int i = 0; i < n; i++)
        {
            sieves[i] = ulong.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            number = (number & (~sieves[i]));
        }

        while (number > 0)
        {
            if (1 == (number & 1))
                bitsCount++;

            number = number >> 1;
        }

        Console.WriteLine(bitsCount);
    }
}