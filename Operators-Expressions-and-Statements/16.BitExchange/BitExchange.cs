using System;
class BitExchange
{
    static void Main(string[] args)
    {
        uint n;
        int p;
        int q;
        int k;
        int diff;

        n = uint.Parse(Console.ReadLine());
        p = int.Parse(Console.ReadLine());
        q = int.Parse(Console.ReadLine());
        k = int.Parse(Console.ReadLine());


       // Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));

        diff = (int)Math.Abs(p-q);

        if ((p < 0) || ((p + k) > 32) || (q < 0) || ((q + k) > 32))
        {
            Console.WriteLine("out of range");
        }
        else if (diff < k)
        {
            Console.WriteLine("overlapping");
        }
        else
        {
            uint maskValue=0;

            for (int i = 0; i < k; i++)
                maskValue = (maskValue<<1) + 1;

            uint mask = ~(uint)((maskValue << p) | (maskValue << q));
            uint newUintWithExchengeBits;
            if(q>p)
                newUintWithExchengeBits = (((n >> diff) & (maskValue << p)) | ((n << diff) & (maskValue << q)));
            else
                newUintWithExchengeBits = (((n >> diff) & (maskValue << q)) | ((n << diff) & (maskValue << p)));

            n = (mask & n) | newUintWithExchengeBits;

            Console.WriteLine(n);
        }


    }
}
