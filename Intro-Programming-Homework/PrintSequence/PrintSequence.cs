using System;
class PrintSequence
{
    static void Main(string[] args)
    {
        int numberToPrint;

        for (int i = 2; i < 12; i++)
        {
            if (i % 2 == 0)
                numberToPrint = i;
            else
                numberToPrint = -1 * i;

            Console.WriteLine(numberToPrint);
        }
    }
}
