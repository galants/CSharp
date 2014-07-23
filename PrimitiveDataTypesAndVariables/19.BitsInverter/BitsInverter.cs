/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 * You are given a sequence of bytes. Consider each byte as sequences of exactly 8 bits.
 * You are given also a number step. Write a program to invert the bits at positions: 
 * 1, 1 + step, 1 + 2*step, ... Print the output as a sequence of bytes.
 * Bits in each byte are counted from the leftmost to the rightmost. Bits are numbered starting from 1. 
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
using System;
class BitsInverter
{
    byte n;
    byte step;
    byte[][] bytes;

    void SetBytesArray()
    {
        this.bytes = new byte[2][];
        this.bytes[0]=new byte[n];
        this.bytes[1]=new byte[n];

        for (byte i = 0; i < this.n; i++)
        {
            this.bytes[0][i] = byte.Parse(Console.ReadLine());
            this.bytes[1][i] = 0;
        }
    }
    void PrintBytesArray()
    {
        foreach (byte byteWord in bytes[0])
            Console.WriteLine(byteWord);
            //Console.WriteLine(Convert.ToString(byteWord, 2).PadLeft(8, '0'));
    }

    void SetBytesMask()
    {
        int index = 1;

        for (int i = 0; i <n; i++)
        {
            for (int j = 0; j < 8;j++ )
            {
                if ((1 == step) || (1 == index % step))
                {
                    this.bytes[1][i] = (byte)(this.bytes[1][i] ^ (1 << (7-j)));
                }
                index++;
            }         
        }
    }

    void BytesInvert()
    {
        for (int i = 0; i < n; i++)
        {
            this.bytes[0][i] = (byte)(this.bytes[0][i] ^ this.bytes[1][i]);
        }
    }
    void Run()
    {
        n = byte.Parse(Console.ReadLine());
        step = byte.Parse(Console.ReadLine());

        SetBytesArray();
        SetBytesMask();
        BytesInvert();
        PrintBytesArray();
    }
    static void Main(string[] args)
    {
        BitsInverter bitsInverter = new BitsInverter();

        bitsInverter.Run();
    }
}