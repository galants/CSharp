using System;

internal class BitFlipper
{
    private static int SIZE = 64;

    private static void Main(string[] args)
    {
        ulong number = ulong.Parse(Console.ReadLine());
        int lastSeqPosition = SIZE - 1;
        ulong mask = ((ulong) 1 << (lastSeqPosition));
        ulong lastBit = 0;
        int count = 0;

        //PrintUlongToBin(number);
        //Console.WriteLine();

        for (int i = 1; i <= SIZE; i++)
        {
            mask = ((ulong) 1 << (SIZE - i));
            ulong nowBit = (mask & number) > 0 ? (ulong) 1 : (ulong) 0;

            if (lastBit == nowBit)
            {
                count++;
            }
            else
            {
                count = 1;
                lastBit = nowBit;
            }

            if (count == 3)
            {
                count = 0;
                number = SetBits(number, lastBit, i);
            }
            //PrintUlongToBin(number);
            //Console.WriteLine();
        }

        Console.WriteLine(number);
    }

    private static ulong SetBits(ulong number, ulong lastBit, int position)
    {
        ulong newNum = 0U;
        if (lastBit == 1)
        {
            newNum = ~((ulong) 7 << (SIZE - position)) & (ulong) number;
        }
        else
        {
            newNum = ((ulong) 7 << (SIZE - position)) | (ulong) number;
        }
        return newNum;
    }
}

//    static void PrintUlongToBin(ulong number)
//    {
//        for (int i = 1; i <= SIZE; i++)
//        {
//            ulong mask = ((ulong)1 << (SIZE - i));

//            if ((mask & number) > 0)
//            {
//                Console.Write(1);
//            }
//            else
//            {
//                Console.Write(0);
//            }
//        }
//    }
//}