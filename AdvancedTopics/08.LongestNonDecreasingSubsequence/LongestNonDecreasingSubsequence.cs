using System;
using System.Collections.Generic;
class LongestNonDecreasingSubsequence
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();

        string[] strArr = str.Split(new char[] { ' ' });
        int[] numbers = new int[strArr.Length];

        int lastNum = 0;

        List<int> numberArray = new List<int>();
        numbers = Array.ConvertAll<string, int>(strArr, int.Parse);

        numberArray.Add(numbers[0]);
        int border = numbers[0];

        int i = 1;
        for (; i < numbers.Length; i++)
        {
            lastNum = numbers[i - 1];
            int diff = lastNum - numbers[i];

            if (diff > 0)
            {
                border = lastNum;
                lastNum = numbers[i];

                numberArray.Clear();
                numberArray.Add(lastNum);

                break;
            }
            else if (diff == 0 && border == numbers[i])
            {
                border = lastNum;
                numberArray.Add(numbers[i]);
            }
        }
        for (i++; i < numbers.Length; i++)
        {
            if (lastNum <= numbers[i] && numbers[i] <= border)
            {
                numberArray.Add(numbers[i]);
                lastNum = numbers[i];
            }
        }

        foreach (int num in numberArray)
            Console.Write(num + " ");

    }
}
