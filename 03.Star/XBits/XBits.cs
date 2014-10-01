using System;
using System.Runtime.CompilerServices;
using System.Threading;

class XBits
{
    static void Main()
    {
        int size = 8;
        int[] numbers = new int[size];
        int count = 0;

        for (int i = 0; i < size; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int matrix1 = 5;
        int matrix2 = 2;
        int matrix3 = 5;

        for (int i = 0; i < size - 2; i++)
        {
            for (int j = 0; j < 32 - 2; j++)
            {
                bool row1 = (isEquallyBits(numbers[i] >> j, matrix1));
                bool row2 = (isEquallyBits(numbers[i + 1] >> j, matrix2));
                bool row3 = (isEquallyBits(numbers[i + 2] >> j, matrix3));
                if (row1 && row2 && row3)
                {
                    count++;
                }
                if ((numbers[i] >> j) == 0 && (numbers[i+1] >> j) == 0 && (numbers[i+2] >> j )== 0)
                {
                    break;
                }
            }
        }
        Console.WriteLine(count);
    }

    public static bool isEquallyBits(int num, int mask)
    {
        bool isTrue = false;

        isTrue = ((num & 7)^ mask)==0;

        return isTrue;
    }
}
