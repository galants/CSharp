using System;
class ExtractBitFromInteger
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int extractBit = ((n >> p) & 1);

        Console.WriteLine(extractBit);
    }
}