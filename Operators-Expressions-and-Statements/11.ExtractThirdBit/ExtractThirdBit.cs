using System;
class ExtractThirdBit
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int thirdBit = ((n >> 3) & 1);

        Console.WriteLine(thirdBit);
    }
}
