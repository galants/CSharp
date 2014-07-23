using System;
class ASCIITable
{
    static void Main(string[] args)
    {
        Console.WriteLine("ASCII table");

        Console.WriteLine("{0,5}{1,5}{2,4}{3,10}{4,10}","Dec","Oct", "Hex", "Bin", "Symbol");

        for (int i = 0; i <= 255; i++)
        {
            Console.WriteLine("{0,5}{1,5}{2,4}{3,10}{4,10}", i, Convert.ToString(i,8), Convert.ToString(i,16), Convert.ToString(i,2), (char)i);
        }
    }
}