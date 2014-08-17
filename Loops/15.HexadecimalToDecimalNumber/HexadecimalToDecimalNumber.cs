using System;
using System.Numerics;
class HexadecimalToDecimalNumber
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        BigInteger num = 0;
        int value;
        BigInteger pos = 1;


        for (int i = str.Length - 1; i >= 0; i--, pos *= 16)
        {
            switch (str[i])
            {
                case 'A':
                    value = 10;
                    break;
                case 'B':
                    value = 11;
                    break;
                case 'C':
                    value = 12;
                    break;
                case 'D':
                    value = 13;
                    break;
                case 'E':
                    value = 14;
                    break;
                case 'F':
                    value = 15;
                    break;
                default:
                    value = int.Parse(str[i].ToString());
                    break;
            }
            num += (ulong)(value*pos);
        }

        Console.WriteLine(num);
    }
}