using System;
class PrintLongSequence
{
    static void Main(string[] args)
    {
        int numberToPrint;

        for (int i = 0; i < 1000; i++)
        {
            if (i % 2 == 0)
                numberToPrint = i + 2;
            else
                numberToPrint = -1 * (i + 2);

            Console.WriteLine(numberToPrint);
        }
    }
}
