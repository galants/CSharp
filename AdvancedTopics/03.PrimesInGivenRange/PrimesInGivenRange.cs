using System;
using System.Collections.Generic;
class PrimesInGivenRange
{
    static void Main(string[] args)
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());

        List<int> primeNumbers = FindPrimesInRange(startNum, endNum);
        if (primeNumbers.Count > 0)
        {
            for (int i = 0; i < primeNumbers.Count - 1; ++i)
            {
                Console.Write("{0}{1}", primeNumbers[i].ToString(), ", ");
            }
            Console.Write(primeNumbers[primeNumbers.Count - 1].ToString());
        }

        Console.WriteLine();
    }

    static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> primeNumbers = new List<int>();
        if (startNum < 2)
            startNum = 2;

        for (int i = startNum; i <= endNum; i++)
        {
            double chekBorder = Math.Sqrt(i);
            bool isPrime = true;

            for (int j = 2; j <= chekBorder; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
                primeNumbers.Add(i);
        }

        return primeNumbers;
    }
}
