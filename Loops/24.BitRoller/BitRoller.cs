using System;
class BitRoller
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int f = int.Parse(Console.ReadLine());
        int r = int.Parse(Console.ReadLine());
        int size = 19;

        r = r % size;

        for (int i = 0; i < r; i++)
        {
            int beforFNum = 0;
            int mask = 0;
            int fNum = (1 << f) & n;

            if (f < (size-1))
            {
                beforFNum = (1 << (f + 1)) & n;
                mask = 3 << f;
                fNum = (fNum << 1) | (beforFNum >> 1);
            }
            else
            {
                beforFNum = 1 & n;
                mask = (1 << f)+1;
                fNum = (fNum >> f) | (beforFNum << f);
            }
            n = (n & ~mask) | fNum;
            int newNum = n % 2;

            n = (n >> 1) | (newNum << (size-1));
        }
        Console.WriteLine(n);
    }
}
