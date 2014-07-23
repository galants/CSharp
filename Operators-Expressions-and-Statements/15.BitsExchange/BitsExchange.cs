using System;
class BitsExchange
{
    static void Main(string[] args)
    {
        uint n = uint.Parse(Console.ReadLine());
        uint mask = ~(uint)((7 << 3) | (7 << 24));                                          //1111 1000 1111 1111 1111 1111 1100 0111
        uint newUintWithExchengeBits = (((n >> 21) & (7 << 3)) | ((n << 21) & (7 << 24)));  //0000 0456 0000 0000 0000 0000 00(26)(25) (24)000

        n = (mask & n) | newUintWithExchengeBits;

        Console.WriteLine(n);
    }
}