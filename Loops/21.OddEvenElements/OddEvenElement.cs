using System;
using System.Globalization;
using System.Threading;
class OddEvenElement
{
    static void Main(string[] args)
    {
        double oddSum = 0;
        double oddMin = double.MaxValue;
        double oddMax = double.MinValue;

        double evenSum = 0;
        double evenMin = double.MaxValue;
        double evenMax = double.MinValue;

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
       
        string strNumbers = Console.ReadLine();
        string[] strArrNumbers = strNumbers.Split(' ');

        if (strNumbers=="")
        {
            Console.Write("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
        }
        else if (strArrNumbers.Length == 1)
        {
            double number = double.Parse(strArrNumbers[0]);
            Console.Write("OddSum={0}, OddMin={0}, OddMax={0}, EvenSum=No, EvenMin=No, EvenMax=No", (double)number);
        }
        else
        {
            for (int i = 0; i < strArrNumbers.Length; i++)
            {
                double number = double.Parse(strArrNumbers[i]);

                if (i % 2 == 0)
                {
                    oddMax = Math.Max(oddMax, number);
                    oddMin = Math.Min(oddMin, number);
                    oddSum += number;
                }
                else
                {
                    evenMax = Math.Max(evenMax, number);
                    evenMin = Math.Min(evenMin, number);
                    evenSum += number;
                }
            }

            Console.Write("OddSum={0}, OddMin={1}, OddMax={2}, ", (double)oddSum, (double)oddMin, (double)oddMax);
            Console.Write("EvenSum={0}, EvenMin={1}, EvenMax={2}", (double)evenSum, (double)evenMin, (double)evenMax);
        }

    }
}
