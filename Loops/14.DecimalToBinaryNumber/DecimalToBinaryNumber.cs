using System;
using System.Collections.Generic;
class DecimalToBinaryNumber
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        List<int> array = new List<int>();

        for (int i = 0; num > 0; num = num / 2, i++)
        {
            array.Add(num % 2);
        }

        array.Reverse();

        foreach(int ch in array)
            Console.Write(ch);
    }
}
