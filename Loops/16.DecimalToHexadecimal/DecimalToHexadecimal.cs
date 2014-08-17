using System;
using System.Collections.Generic;
class DecimalToHexadecimal
{
    static void Main(string[] args)
    {
        long num = long.Parse(Console.ReadLine());
        List<int> array = new List<int>();
        char ch;

        for (int i = 0; num > 0; num = num / 16, i++)
        {
            switch(num % 16)
            {
                case 10:
                    ch = 'A';
                    break;
                case 11:
                    ch = 'B';
                    break;
                case 12:
                    ch = 'C';
                    break;
                case 13:
                    ch = 'D';
                    break;
                case 14:
                    ch = 'E';
                    break;
                case 15:
                    ch = 'F';
                    break;
                default:
                    ch = char.Parse((num%16).ToString());
                    break;
            }
            array.Add(ch);
        }

        array.Reverse();

        foreach (char element in array)
            Console.Write(element);
    }
}
