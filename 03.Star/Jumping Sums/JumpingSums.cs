using System;
using System.Collections.Generic;

class JumpingSums
{
    static void Main()
    {
        string str = Console.ReadLine();
        int j = int.Parse(Console.ReadLine());

        int[] values = Array.ConvertAll(str.Split(new char[] { ' ' }), int.Parse);
        int[] flags;
        long maxSum = int.MinValue;

        for (int i = 0; i < values.Length; i++)
        {
            int k = 0;
            int sum = values[i];
            int index = (i + values[i]) % values.Length;

            while (k < j)
            {
                int value = values[index];
                sum += value;
                index = (index + value) % values.Length;

                k++;
            }

            maxSum = Math.Max(maxSum, sum);
        }
        Console.WriteLine("max sum = {0}", maxSum);
    }
}
